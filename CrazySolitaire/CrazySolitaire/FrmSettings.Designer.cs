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
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(845, 714);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 59);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRulse
            // 
            btnRulse.Location = new Point(715, 85);
            btnRulse.Name = "btnRulse";
            btnRulse.Size = new Size(197, 67);
            btnRulse.TabIndex = 1;
            btnRulse.Text = "How to Play";
            btnRulse.UseVisualStyleBackColor = true;
            // 
            // lblAutoplay
            // 
            lblAutoplay.AutoSize = true;
            lblAutoplay.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutoplay.Location = new Point(54, 85);
            lblAutoplay.Name = "lblAutoplay";
            lblAutoplay.Size = new Size(137, 38);
            lblAutoplay.TabIndex = 2;
            lblAutoplay.Text = "Autoplay";
            lblAutoplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMusic.Location = new Point(54, 185);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(94, 38);
            lblMusic.TabIndex = 3;
            lblMusic.Text = "Music";
            lblMusic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.Location = new Point(54, 280);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(190, 38);
            lblMode.TabIndex = 4;
            lblMode.Text = "Theme Mode";
            lblMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAutoplayDesc
            // 
            lblAutoplayDesc.AutoSize = true;
            lblAutoplayDesc.Location = new Point(54, 123);
            lblAutoplayDesc.Name = "lblAutoplayDesc";
            lblAutoplayDesc.Size = new Size(235, 25);
            lblAutoplayDesc.TabIndex = 5;
            lblAutoplayDesc.Text = "Moves cards with just a click";
            // 
            // lblMusicDesc
            // 
            lblMusicDesc.AutoSize = true;
            lblMusicDesc.Location = new Point(54, 223);
            lblMusicDesc.Name = "lblMusicDesc";
            lblMusicDesc.Size = new Size(102, 25);
            lblMusicDesc.TabIndex = 6;
            lblMusicDesc.Text = "Add music ";
            // 
            // lblModeDesc
            // 
            lblModeDesc.AutoSize = true;
            lblModeDesc.Location = new Point(54, 329);
            lblModeDesc.Name = "lblModeDesc";
            lblModeDesc.Size = new Size(95, 25);
            lblModeDesc.TabIndex = 7;
            lblModeDesc.Text = "Dark/Light";
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(1000, 800);
            ControlBox = false;
            Controls.Add(lblModeDesc);
            Controls.Add(lblMusicDesc);
            Controls.Add(lblAutoplayDesc);
            Controls.Add(lblMode);
            Controls.Add(lblMusic);
            Controls.Add(lblAutoplay);
            Controls.Add(btnRulse);
            Controls.Add(btnClose);
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
    }
}