
namespace Discord_DM_Sender
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.DMButton = new System.Windows.Forms.Button();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.TokensTextBox = new System.Windows.Forms.TextBox();
            this.TokensBrowseButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.DMNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InviteTextBox = new System.Windows.Forms.TextBox();
            this.NumericUpDownLabel = new System.Windows.Forms.Label();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DMNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(28, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(529, 31);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Discord DM Sender Skidded by Dollar3795";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(10, 100);
            this.MessageTextBox.MaxLength = 2000;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(370, 220);
            this.MessageTextBox.TabIndex = 5;
            this.MessageTextBox.Text = "DM Message";
            // 
            // DMButton
            // 
            this.DMButton.Location = new System.Drawing.Point(390, 330);
            this.DMButton.Name = "DMButton";
            this.DMButton.Size = new System.Drawing.Size(185, 25);
            this.DMButton.TabIndex = 6;
            this.DMButton.Text = "Start Sending DMs";
            this.DMButton.UseVisualStyleBackColor = true;
            this.DMButton.Click += new System.EventHandler(this.DMButton_Click);
            // 
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.ItemHeight = 16;
            this.LogListBox.Location = new System.Drawing.Point(390, 60);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(185, 180);
            this.LogListBox.TabIndex = 9;
            // 
            // TokensTextBox
            // 
            this.TokensTextBox.Location = new System.Drawing.Point(10, 60);
            this.TokensTextBox.Name = "TokensTextBox";
            this.TokensTextBox.Size = new System.Drawing.Size(280, 23);
            this.TokensTextBox.TabIndex = 10;
            // 
            // TokensBrowseButton
            // 
            this.TokensBrowseButton.Location = new System.Drawing.Point(300, 60);
            this.TokensBrowseButton.Name = "TokensBrowseButton";
            this.TokensBrowseButton.Size = new System.Drawing.Size(75, 25);
            this.TokensBrowseButton.TabIndex = 11;
            this.TokensBrowseButton.Text = "Browse";
            this.TokensBrowseButton.UseVisualStyleBackColor = true;
            this.TokensBrowseButton.Click += new System.EventHandler(this.TokensBrowseButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(10, 330);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(370, 23);
            this.IDTextBox.TabIndex = 12;
            this.IDTextBox.Text = "User IDs (Split with |)";
            // 
            // OFD
            // 
            this.OFD.Filter = "TXT Files|*.txt|All Files|*.*";
            // 
            // DMNumericUpDown
            // 
            this.DMNumericUpDown.Location = new System.Drawing.Point(390, 295);
            this.DMNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DMNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DMNumericUpDown.Name = "DMNumericUpDown";
            this.DMNumericUpDown.Size = new System.Drawing.Size(90, 23);
            this.DMNumericUpDown.TabIndex = 13;
            this.DMNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // DelayNumericUpDown
            // 
            this.DelayNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNumericUpDown.Location = new System.Drawing.Point(485, 295);
            this.DelayNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DelayNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNumericUpDown.Name = "DelayNumericUpDown";
            this.DelayNumericUpDown.Size = new System.Drawing.Size(90, 23);
            this.DelayNumericUpDown.TabIndex = 14;
            this.DelayNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // InviteTextBox
            // 
            this.InviteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InviteTextBox.Location = new System.Drawing.Point(390, 250);
            this.InviteTextBox.Name = "InviteTextBox";
            this.InviteTextBox.Size = new System.Drawing.Size(185, 21);
            this.InviteTextBox.TabIndex = 15;
            this.InviteTextBox.Text = "Loading...";
            // 
            // NumericUpDownLabel
            // 
            this.NumericUpDownLabel.AutoSize = true;
            this.NumericUpDownLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericUpDownLabel.Location = new System.Drawing.Point(390, 275);
            this.NumericUpDownLabel.Name = "NumericUpDownLabel";
            this.NumericUpDownLabel.Size = new System.Drawing.Size(190, 17);
            this.NumericUpDownLabel.TabIndex = 16;
            this.NumericUpDownLabel.Text = "DM Per Token Delay Per DM";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(255, 40);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(322, 17);
            this.GitHubLinkLabel.TabIndex = 17;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "https://github.com/Dollar3795/Discord-DM-Sender";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.NumericUpDownLabel);
            this.Controls.Add(this.InviteTextBox);
            this.Controls.Add(this.DelayNumericUpDown);
            this.Controls.Add(this.DMNumericUpDown);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.TokensBrowseButton);
            this.Controls.Add(this.TokensTextBox);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.DMButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord DM Sender";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DMNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Button DMButton;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.TextBox TokensTextBox;
        private System.Windows.Forms.Button TokensBrowseButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.NumericUpDown DMNumericUpDown;
        private System.Windows.Forms.NumericUpDown DelayNumericUpDown;
        private System.Windows.Forms.TextBox InviteTextBox;
        private System.Windows.Forms.Label NumericUpDownLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
    }
}

