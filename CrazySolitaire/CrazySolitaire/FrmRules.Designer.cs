namespace CrazySolitaire
{
    partial class FrmRules
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
            txtRules = new RichTextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtRules
            // 
            txtRules.Location = new Point(12, 23);
            txtRules.Name = "txtRules";
            txtRules.ReadOnly = true;
            txtRules.Size = new Size(681, 702);
            txtRules.TabIndex = 0;
            txtRules.Text = "";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(610, 745);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 43);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmRules
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(778, 798);
            Controls.Add(btnClose);
            Controls.Add(txtRules);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRules";
            Load += FrmRules_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtRules;
        private Button btnClose;
    }
}