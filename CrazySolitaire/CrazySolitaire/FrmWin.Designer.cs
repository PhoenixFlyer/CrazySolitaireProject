namespace CrazySolitaire
{
    partial class FrmWin
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
            pbConfetti = new PictureBox();
            btnExit = new Button();
            btnWinNewGame = new Button();
            lblWin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbConfetti).BeginInit();
            SuspendLayout();
            // 
            // pbConfetti
            // 
            pbConfetti.Dock = DockStyle.Fill;
            pbConfetti.Image = Properties.Resources.Confetti;
            pbConfetti.Location = new Point(0, 0);
            pbConfetti.Name = "pbConfetti";
            pbConfetti.Size = new Size(662, 373);
            pbConfetti.SizeMode = PictureBoxSizeMode.StretchImage;
            pbConfetti.TabIndex = 12;
            pbConfetti.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(25, 218);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 100);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnWinNewGame
            // 
            btnWinNewGame.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWinNewGame.Location = new Point(537, 218);
            btnWinNewGame.Name = "btnWinNewGame";
            btnWinNewGame.Size = new Size(100, 100);
            btnWinNewGame.TabIndex = 14;
            btnWinNewGame.Text = "New Game";
            btnWinNewGame.UseVisualStyleBackColor = true;
            btnWinNewGame.Click += btnWinNewGame_Click;
            // 
            // lblWin
            // 
            lblWin.Anchor = AnchorStyles.None;
            lblWin.AutoSize = true;
            lblWin.Font = new Font("Old English Text MT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWin.Location = new Point(80, 54);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(490, 53);
            lblWin.TabIndex = 13;
            lblWin.Text = "Congratulations, you won!";
            lblWin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(662, 373);
            Controls.Add(btnExit);
            Controls.Add(btnWinNewGame);
            Controls.Add(lblWin);
            Controls.Add(pbConfetti);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmWin";
            Text = "Congratulations!";
            TopMost = true;
            Load += frmWin_Load;
            ((System.ComponentModel.ISupportInitialize)pbConfetti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbConfetti;
        private Button btnExit;
        private Button btnWinNewGame;
        private Label lblWin;
    }
}