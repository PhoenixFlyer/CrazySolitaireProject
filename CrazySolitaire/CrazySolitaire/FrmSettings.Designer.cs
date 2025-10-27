namespace CrazySolitaire
{
    partial class FrmSettings
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
            btnClose = new Button();
            btnRulse = new Button();
            lblAutoplay = new Label();
            lblMusic = new Label();
            lblMode = new Label();
            lblAutoplayDesc = new Label();
            lblMusicDesc = new Label();
            lblModeDesc = new Label();
            chkAutoplay = new CheckBox();
            MusicChk = new CheckBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(592, 428);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 35);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRulse
            // 
            btnRulse.Location = new Point(500, 51);
            btnRulse.Margin = new Padding(2);
            btnRulse.Name = "btnRulse";
            btnRulse.Size = new Size(138, 40);
            btnRulse.TabIndex = 1;
            btnRulse.Text = "How to Play";
            btnRulse.UseVisualStyleBackColor = true;
            btnRulse.Click += btnRulse_Click;
            // 
            // lblAutoplay
            // 
            lblAutoplay.AutoSize = true;
            lblAutoplay.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutoplay.Location = new Point(38, 51);
            lblAutoplay.Margin = new Padding(2, 0, 2, 0);
            lblAutoplay.Name = "lblAutoplay";
            lblAutoplay.Size = new Size(93, 25);
            lblAutoplay.TabIndex = 2;
            lblAutoplay.Text = "Autoplay";
            lblAutoplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMusic.Location = new Point(38, 111);
            lblMusic.Margin = new Padding(2, 0, 2, 0);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(64, 25);
            lblMusic.TabIndex = 3;
            lblMusic.Text = "Music";
            lblMusic.TextAlign = ContentAlignment.MiddleCenter;
            lblMusic.Click += lblMusic_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.Location = new Point(38, 168);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(128, 25);
            lblMode.TabIndex = 4;
            lblMode.Text = "Theme Mode";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAutoplayDesc
            // 
            lblAutoplayDesc.AutoSize = true;
            lblAutoplayDesc.Location = new Point(38, 74);
            lblAutoplayDesc.Margin = new Padding(2, 0, 2, 0);
            lblAutoplayDesc.Name = "lblAutoplayDesc";
            lblAutoplayDesc.Size = new Size(157, 15);
            lblAutoplayDesc.TabIndex = 5;
            lblAutoplayDesc.Text = "Moves cards with just a click";
            // 
            // lblMusicDesc
            // 
            lblMusicDesc.AutoSize = true;
            lblMusicDesc.Location = new Point(38, 134);
            lblMusicDesc.Margin = new Padding(2, 0, 2, 0);
            lblMusicDesc.Name = "lblMusicDesc";
            lblMusicDesc.Size = new Size(67, 15);
            lblMusicDesc.TabIndex = 6;
            lblMusicDesc.Text = "Add music ";
            // 
            // lblModeDesc
            // 
            lblModeDesc.AutoSize = true;
            lblModeDesc.Location = new Point(38, 197);
            lblModeDesc.Margin = new Padding(2, 0, 2, 0);
            lblModeDesc.Name = "lblModeDesc";
            lblModeDesc.Size = new Size(63, 15);
            lblModeDesc.TabIndex = 7;
            lblModeDesc.Text = "Dark/Light";
            // 
            // chkAutoplay
            // 
            chkAutoplay.AutoSize = true;
            chkAutoplay.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAutoplay.Location = new Point(219, 59);
            chkAutoplay.Margin = new Padding(2);
            chkAutoplay.Name = "chkAutoplay";
            chkAutoplay.Size = new Size(15, 14);
            chkAutoplay.TabIndex = 8;
            chkAutoplay.UseVisualStyleBackColor = true;
            chkAutoplay.CheckedChanged += chkAutoplay_CheckedChanged;
            // 
            // MusicChk
            // 
            MusicChk.AutoSize = true;
            MusicChk.Checked = true;
            MusicChk.CheckState = CheckState.Checked;
            MusicChk.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MusicChk.Location = new Point(219, 122);
            MusicChk.Margin = new Padding(2);
            MusicChk.Name = "MusicChk";
            MusicChk.Size = new Size(15, 14);
            MusicChk.TabIndex = 9;
            MusicChk.UseVisualStyleBackColor = true;
            MusicChk.CheckedChanged += MusicChk_CheckedChanged;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(700, 480);
            ControlBox = false;
            Controls.Add(MusicChk);
            Controls.Add(chkAutoplay);
            Controls.Add(lblModeDesc);
            Controls.Add(lblMusicDesc);
            Controls.Add(lblAutoplayDesc);
            Controls.Add(lblMode);
            Controls.Add(lblMusic);
            Controls.Add(lblAutoplay);
            Controls.Add(btnRulse);
            Controls.Add(btnClose);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FrmSettings";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += FrmSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnRulse;
        private Label lblAutoplay;
        private Label lblMusic;
        private Label lblMode;
        private Label lblAutoplayDesc;
        private Label lblMusicDesc;
        private Label lblModeDesc;
        private CheckBox chkAutoplay;
        private CheckBox MusicChk;
    }
}