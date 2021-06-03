using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_DM_Sender
{
    public partial class MainForm : Form
    {
        string ServerInvite = "N/A";

        public MainForm()
        {
            InitializeComponent();
            WebClient WC = new WebClient();
            ServerInvite = WC.DownloadString("https://raw.githubusercontent.com/Dollar3795/Discord-Invite/main/README.md");
            InviteTextBox.Text = ServerInvite;
            MessageBox.Show("This software was released free-of-charge by Dollar3795!\n이 소프트웨어는 무료로 배포되었습니다! (by Dollar3795)", "Discord DM Sender", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LogListBox.Items.Add("This software was released");
            LogListBox.Items.Add("free-of-charge by Dollar3795!");
            LogListBox.Items.Add("이 소프트웨어는 무료로");
            LogListBox.Items.Add("배포되었습니다! (by Dollar3795)");
            Process.Start(ServerInvite);
        }

        private Random Random = new Random();
        public string RandomInt(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        private WebClient WC(string Token, string Cookie, string Referer, string XCP)
        {
            WebClient WC = new WebClient();
            WC.Encoding = Encoding.UTF8;
            WC.Headers["Authorization"] = Token;
            WC.Headers["Cookie"] = Cookie;
            WC.Headers["Content-Type"] = "application/json";
            WC.Headers["Host"] = "discord.com";
            WC.Headers["Origin"] = "https://discord.com";
            if (Referer != string.Empty) WC.Headers["Referer"] = Referer;
            WC.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.198 Safari/537.36";
            if (XCP != string.Empty) WC.Headers["X-Context-Properties"] = XCP;
            WC.Headers["X-Super-Properties"] = "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzg2LjAuNDI0MC4xOTggU2FmYXJpLzUzNy4zNiIsImJyb3dzZXJfdmVyc2lvbiI6Ijg2LjAuNDI0MC4xOTgiLCJvc192ZXJzaW9uIjoiMTAiLCJyZWZlcnJlciI6IiIsInJlZmVycmluZ19kb21haW4iOiIiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMzNjQsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9";
            return WC;
        }

        private async void DMButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DMButton.Text == "Start Sending DMs")
                {
                    DMButton.Enabled = false;
                    if (InviteTextBox.Text.Contains("/")) InviteTextBox.Text = InviteTextBox.Text.Split('/').Last();
                    WebClient _WC = new WebClient();
                    _WC.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.198 Safari/537.36";
                    LogListBox.Items.Add("Receiving Cookies...");
                    await _WC.DownloadStringTaskAsync("https://discord.com/");
                    string Cookie = string.Empty;
                    for (int i = 0; i < _WC.ResponseHeaders.Count; i++)
                    {
                        if (_WC.ResponseHeaders.GetKey(i) == "Set-Cookie")
                        {
                            if (_WC.ResponseHeaders.GetValues(i).Length < 2) throw new Exception("Not enough cookies were received. Please restart and try again.");
                            if (_WC.ResponseHeaders.GetValues(i).Length > 2) throw new Exception("Too many cookies were received. Please restart and try again.");
                            foreach (string CookieValue in _WC.ResponseHeaders.GetValues(i))
                            {
                                Cookie += CookieValue.Split(' ')[0] + " ";
                            }
                        }
                    }
                    if (Cookie == string.Empty) throw new Exception("No cookie was received. Please try again.");
                    Cookie += "locale=en-US";
                    string[] Tokens = File.ReadAllLines(TokensTextBox.Text);
                    LogListBox.Items.Add("Loaded " + Tokens.Length + " Tokens!");
                    string[] UserIDs = IDTextBox.Text.Split('|');
                    Random Random = new Random();
                    LogListBox.Items.Add("Receiving Invite Data...");
                    string InviteData = await WC(Tokens[0], Cookie, string.Empty, "https://discord.com/channels/@me").UploadStringTaskAsync("https://discord.com/api/v9/invites/" + InviteTextBox.Text + "?inputValue=" + InviteTextBox.Text + "&with_counts=true&with_expiration=true", "POST", string.Empty);
                    string[] InviteChannel = InviteData.Split(new string[] { "{\"id\": \"" }, StringSplitOptions.None)[2].Split('"');
                    for (int i = 0; i < UserIDs.Length; i++)
                    {
                        string Token = Tokens[Convert.ToInt32(Math.Floor(i / DMNumericUpDown.Value))];
                        try
                        {
                            if (i % DMNumericUpDown.Value == 0)
                            {
                                LogListBox.Items.Add("Joining Guild...");
                                await WC(Token, Cookie, "https://discord.com/channels/@me", Convert.ToBase64String(Encoding.UTF8.GetBytes("{\"location\":\"Join Guild\",\"location_guild_id\":\"" + InviteData.Split('"')[9] + "\",\"location_channel_id\":\"" + InviteChannel[0] + "\",\"location_channel_type\":" + InviteChannel[7].Split('}')[0].Split(' ')[1] + "}"))).UploadStringTaskAsync("https://discord.com/api/v9/invites/" + InviteTextBox.Text, "POST", string.Empty);
                            }
                            string DMChannel = await WC(Token, Cookie, string.Empty, "e30=").UploadStringTaskAsync("https://discord.com/api/v9/users/@me/channels", "POST", "{\"recipients\":[\"" + UserIDs[i] + "\"]}");
                            await WC(Token, Cookie, "https://discord.com/channels/@me/" + DMChannel.Split('"')[3], string.Empty).UploadStringTaskAsync("https://discord.com/api/v9/channels/" + DMChannel.Split('"')[3] + "/messages", "POST", "{\"content\":\"" + MessageTextBox.Text.Replace("\n", "\\n") + "\",\"nonce\":\"85" + RandomInt(16).ToString() + "\",\"tts\":false}");
                            LogListBox.Items.Add("Success '" + UserIDs[i] + "'!");
                        }
                        catch (Exception Exception)
                        {
                            if (Exception.Message.ToString().Contains("400"))
                            {
                                LogListBox.Items.Add("Bad Request!");
                                DialogResult ErrorDialogResult = MessageBox.Show("Please send this error in the discord server! (Click OK To Join)\nInvite: " + ServerInvite + "\n\n" + Exception.Message.ToString(), "Discord DM Sender", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (DialogResult == DialogResult.Yes) Process.Start(ServerInvite);
                            }
                            else if (Exception.Message.ToString().Contains("401")) LogListBox.Items.Add("Invalid Token!");
                            else if (Exception.Message.ToString().Contains("403")) LogListBox.Items.Add("DM OFF '" + UserIDs[i] + "'!");
                            else
                            {
                                LogListBox.Items.Add("Error '" + UserIDs[i] + "'!");
                                DialogResult ErrorDialogResult = MessageBox.Show("Please send this error in the discord server! (Click OK To Join)\nInvite: " + ServerInvite + "\n\n" + Exception.Message.ToString(), "Discord DM Sender", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (DialogResult == DialogResult.Yes) Process.Start(ServerInvite);
                            }
                        }
                        await Task.Delay(Convert.ToInt32(DelayNumericUpDown.Value));
                    }
                    LogListBox.Items.Add("Completed!");
                    DMButton.Enabled = true;
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message.ToString(), "Discord DM Sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DMButton.Enabled = true;
            }
        }

        private void TokensBrowseButton_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            if (OFD.FileName != string.Empty) TokensTextBox.Text = OFD.FileName;
        }

        private void MainForm_Load(object sender, EventArgs e) => LogListBox.Items.Add("Discord DM Sender Loaded!");

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/Dollar3795/Discord-DM-Sender");
    }
}