namespace CrazySolitaire
{
    partial class FrmGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            pbStock = new PictureBox();
            panTalon = new Panel();
            panFoundationStack_Clubs = new Panel();
            panFoundationStack_Hearts = new Panel();
            panFoundationStack_Spades = new Panel();
            panFoundationStack_Diamonds = new Panel();
            panTableauStack_0 = new Panel();
            UndoBtn = new Button();
            panTableauStack_1 = new Panel();
            panTableauStack_2 = new Panel();
            panTableauStack_3 = new Panel();
            panTableauStack_4 = new Panel();
            panTableauStack_5 = new Panel();
            panTableauStack_6 = new Panel();
            lblTime = new Label();
            lblMoves = new Label();
            lblNumMoves = new Label();
            btnSettings = new Button();
            btnNewGame = new Button();
            btnHint = new Button();
            lblNumOfHints = new Label();
            lblPowerups = new Label();
            ExplodeTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbStock).BeginInit();
            SuspendLayout();
            // 
            // pbStock
            // 
            pbStock.BackgroundImage = Properties.Resources.back_green;
            pbStock.BackgroundImageLayout = ImageLayout.Stretch;
            pbStock.BorderStyle = BorderStyle.Fixed3D;
            pbStock.Location = new Point(40, 53);
            pbStock.Name = "pbStock";
            pbStock.Size = new Size(90, 126);
            pbStock.TabIndex = 0;
            pbStock.TabStop = false;
            pbStock.Click += pbStock_Click;
            // 
            // panTalon
            // 
            panTalon.Location = new Point(153, 53);
            panTalon.Name = "panTalon";
            panTalon.Size = new Size(166, 126);
            panTalon.TabIndex = 1;
            // 
            // panFoundationStack_Clubs
            // 
            panFoundationStack_Clubs.AllowDrop = true;
            panFoundationStack_Clubs.BackgroundImage = Properties.Resources.FoundationStackBg_Clubs;
            panFoundationStack_Clubs.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Clubs.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Clubs.Location = new Point(341, 53);
            panFoundationStack_Clubs.Margin = new Padding(2);
            panFoundationStack_Clubs.Name = "panFoundationStack_Clubs";
            panFoundationStack_Clubs.Size = new Size(81, 101);
            panFoundationStack_Clubs.TabIndex = 2;
            // 
            // panFoundationStack_Hearts
            // 
            panFoundationStack_Hearts.BackgroundImage = Properties.Resources.FoundationStackBg_Hearts;
            panFoundationStack_Hearts.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Hearts.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Hearts.Location = new Point(444, 53);
            panFoundationStack_Hearts.Margin = new Padding(2);
            panFoundationStack_Hearts.Name = "panFoundationStack_Hearts";
            panFoundationStack_Hearts.Size = new Size(81, 101);
            panFoundationStack_Hearts.TabIndex = 3;
            // 
            // panFoundationStack_Spades
            // 
            panFoundationStack_Spades.BackgroundImage = Properties.Resources.FoundationStackBg_Spades;
            panFoundationStack_Spades.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Spades.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Spades.Location = new Point(548, 53);
            panFoundationStack_Spades.Margin = new Padding(2);
            panFoundationStack_Spades.Name = "panFoundationStack_Spades";
            panFoundationStack_Spades.Size = new Size(81, 101);
            panFoundationStack_Spades.TabIndex = 3;
            // 
            // panFoundationStack_Diamonds
            // 
            panFoundationStack_Diamonds.BackgroundImage = Properties.Resources.FoundationStackBg_Diamonds;
            panFoundationStack_Diamonds.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Diamonds.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Diamonds.Location = new Point(651, 53);
            panFoundationStack_Diamonds.Margin = new Padding(2);
            panFoundationStack_Diamonds.Name = "panFoundationStack_Diamonds";
            panFoundationStack_Diamonds.Size = new Size(81, 101);
            panFoundationStack_Diamonds.TabIndex = 3;
            // 
            // panTableauStack_0
            // 
            panTableauStack_0.AllowDrop = true;
            panTableauStack_0.Location = new Point(32, 239);
            panTableauStack_0.Margin = new Padding(2);
            panTableauStack_0.Name = "panTableauStack_0";
            panTableauStack_0.Size = new Size(80, 301);
            panTableauStack_0.TabIndex = 4;
            // 
            // UndoBtn
            // 
            UndoBtn.BackColor = Color.Transparent;
            UndoBtn.BackgroundImage = Properties.Resources.Undo;
            UndoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            UndoBtn.Location = new Point(99, 566);
            UndoBtn.Margin = new Padding(2);
            UndoBtn.Name = "UndoBtn";
            UndoBtn.Size = new Size(70, 60);
            UndoBtn.TabIndex = 13;
            UndoBtn.UseVisualStyleBackColor = false;
            UndoBtn.Visible = false;
            // 
            // panTableauStack_1
            // 
            panTableauStack_1.Location = new Point(135, 239);
            panTableauStack_1.Margin = new Padding(2);
            panTableauStack_1.Name = "panTableauStack_1";
            panTableauStack_1.Size = new Size(80, 301);
            panTableauStack_1.TabIndex = 5;
            // 
            // panTableauStack_2
            // 
            panTableauStack_2.Location = new Point(239, 239);
            panTableauStack_2.Margin = new Padding(2);
            panTableauStack_2.Name = "panTableauStack_2";
            panTableauStack_2.Size = new Size(80, 301);
            panTableauStack_2.TabIndex = 5;
            // 
            // panTableauStack_3
            // 
            panTableauStack_3.Location = new Point(341, 239);
            panTableauStack_3.Margin = new Padding(2);
            panTableauStack_3.Name = "panTableauStack_3";
            panTableauStack_3.Size = new Size(80, 301);
            panTableauStack_3.TabIndex = 5;
            // 
            // panTableauStack_4
            // 
            panTableauStack_4.Location = new Point(444, 239);
            panTableauStack_4.Margin = new Padding(2);
            panTableauStack_4.Name = "panTableauStack_4";
            panTableauStack_4.Size = new Size(80, 301);
            panTableauStack_4.TabIndex = 5;
            // 
            // panTableauStack_5
            // 
            panTableauStack_5.Location = new Point(548, 239);
            panTableauStack_5.Margin = new Padding(2);
            panTableauStack_5.Name = "panTableauStack_5";
            panTableauStack_5.Size = new Size(80, 301);
            panTableauStack_5.TabIndex = 5;
            // 
            // panTableauStack_6
            // 
            panTableauStack_6.Location = new Point(651, 239);
            panTableauStack_6.Margin = new Padding(2);
            panTableauStack_6.Name = "panTableauStack_6";
            panTableauStack_6.Size = new Size(80, 301);
            panTableauStack_6.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Old English Text MT", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(633, 8);
            lblTime.Margin = new Padding(2, 0, 2, 0);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.Yes;
            lblTime.Size = new Size(99, 38);
            lblTime.TabIndex = 6;
            lblTime.Text = "0:00";
            // 
            // lblMoves
            // 
            lblMoves.Font = new Font("Old English Text MT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoves.Location = new Point(32, 8);
            lblMoves.Margin = new Padding(2, 0, 2, 0);
            lblMoves.Name = "lblMoves";
            lblMoves.Size = new Size(149, 38);
            lblMoves.TabIndex = 7;
            lblMoves.Text = "Moves: ";
            // 
            // lblNumMoves
            // 
            lblNumMoves.Font = new Font("Old English Text MT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumMoves.Location = new Point(163, 8);
            lblNumMoves.Margin = new Padding(2, 0, 2, 0);
            lblNumMoves.Name = "lblNumMoves";
            lblNumMoves.Size = new Size(126, 38);
            lblNumMoves.TabIndex = 8;
            lblNumMoves.Text = "0";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Image = Properties.Resources.GearIcon;
            btnSettings.Location = new Point(880, 555);
            btnSettings.Margin = new Padding(2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(86, 74);
            btnSettings.TabIndex = 6;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(773, 555);
            btnNewGame.Margin = new Padding(3, 2, 3, 2);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(86, 74);
            btnNewGame.TabIndex = 9;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnHint
            // 
            btnHint.BackColor = Color.Transparent;
            btnHint.BackgroundImageLayout = ImageLayout.None;
            btnHint.Image = (Image)resources.GetObject("btnHint.Image");
            btnHint.Location = new Point(9, 566);
            btnHint.Margin = new Padding(2);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(70, 60);
            btnHint.TabIndex = 10;
            btnHint.UseVisualStyleBackColor = false;
            btnHint.Click += btnHint_Click;
            // 
            // lblNumOfHints
            // 
            lblNumOfHints.AutoSize = true;
            lblNumOfHints.Font = new Font("Old English Text MT", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOfHints.Location = new Point(95, 574);
            lblNumOfHints.Margin = new Padding(2, 0, 2, 0);
            lblNumOfHints.Name = "lblNumOfHints";
            lblNumOfHints.Size = new Size(0, 45);
            lblNumOfHints.TabIndex = 11;
            // 
            // lblPowerups
            // 
            lblPowerups.Font = new Font("Old English Text MT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPowerups.Location = new Point(761, 239);
            lblPowerups.Name = "lblPowerups";
            lblPowerups.Size = new Size(191, 126);
            lblPowerups.TabIndex = 12;
            lblPowerups.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExplodeTimer
            // 
            ExplodeTimer.Interval = 1000;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(976, 633);
            Controls.Add(UndoBtn);
            Controls.Add(lblPowerups);
            Controls.Add(lblNumOfHints);
            Controls.Add(btnHint);
            Controls.Add(btnNewGame);
            Controls.Add(lblNumMoves);
            Controls.Add(lblMoves);
            Controls.Add(lblTime);
            Controls.Add(btnSettings);
            Controls.Add(panTableauStack_6);
            Controls.Add(panTableauStack_5);
            Controls.Add(panTableauStack_4);
            Controls.Add(panTableauStack_3);
            Controls.Add(panTableauStack_2);
            Controls.Add(panTableauStack_1);
            Controls.Add(panTableauStack_0);
            Controls.Add(panFoundationStack_Diamonds);
            Controls.Add(panFoundationStack_Spades);
            Controls.Add(panFoundationStack_Hearts);
            Controls.Add(panFoundationStack_Clubs);
            Controls.Add(panTalon);
            Controls.Add(pbStock);
            Margin = new Padding(2);
            Name = "FrmGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crazy Solitaire";
            FormClosing += FrmGame_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStock;
        private Panel panTalon;
        private Panel panFoundationStack_Clubs;
        private Panel panFoundationStack_Hearts;
        private Panel panFoundationStack_Spades;
        private Panel panFoundationStack_Diamonds;
        private Panel panTableauStack_0;
        private Panel panTableauStack_1;
        private Panel panTableauStack_2;
        private Panel panTableauStack_3;
        private Panel panTableauStack_4;
        private Panel panTableauStack_5;
        private Panel panTableauStack_6;
        private Button btnSettings;
        private Button btnNewGame;
        private Button btnHint;
        private Label lblNumOfHints;
        public Label lblPowerups;
        public Label lblTime;
        public Label lblMoves;
        public Label lblNumMoves;
        private Button UndoBtn;
        private System.Windows.Forms.Timer ExplodeTimer;
    }
}
