namespace CrazySolitaire
{
    partial class FrmQTE
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
            Text = new TextBox();
            QteBtn = new Button();
            SuspendLayout();
            // 
            // Text
            // 
            Text.Location = new Point(31, 12);
            Text.Name = "Text";
            Text.Size = new Size(132, 23);
            Text.TabIndex = 0;
            Text.Text = "CLICK ON ME NOW!!!";
            Text.TextChanged += textBox1_TextChanged;
            // 
            // QteBtn
            // 
            QteBtn.Location = new Point(57, 54);
            QteBtn.Name = "QteBtn";
            QteBtn.Size = new Size(75, 23);
            QteBtn.TabIndex = 1;
            QteBtn.Text = "OKAY!!!";
            QteBtn.UseVisualStyleBackColor = true;
            QteBtn.Click += QteBtn_Click;
            // 
            // FrmQTE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 89);
            ControlBox = false;
            Controls.Add(QteBtn);
            Controls.Add(Text);
            Name = "FrmQTE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Text;
        private Button QteBtn;
    }
}