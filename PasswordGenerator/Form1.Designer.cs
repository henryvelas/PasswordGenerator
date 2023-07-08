namespace PasswordGenerator
{
    partial class Form1
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
            txtpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkuppercase = new CheckBox();
            chklowercase = new CheckBox();
            chknumber = new CheckBox();
            chksymbols = new CheckBox();
            txtlength = new TextBox();
            btngenerate = new Button();
            SuspendLayout();
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(36, 58);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(345, 110);
            txtpassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 45);
            label1.TabIndex = 1;
            label1.Text = "PASSWORD GENERATOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 184);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Password length";
            // 
            // chkuppercase
            // 
            chkuppercase.AutoSize = true;
            chkuppercase.CheckAlign = ContentAlignment.MiddleRight;
            chkuppercase.Location = new Point(59, 215);
            chkuppercase.Name = "chkuppercase";
            chkuppercase.Size = new Size(157, 19);
            chkuppercase.TabIndex = 3;
            chkuppercase.Text = "Include uppercase letters";
            chkuppercase.UseVisualStyleBackColor = true;
            // 
            // chklowercase
            // 
            chklowercase.AutoSize = true;
            chklowercase.CheckAlign = ContentAlignment.MiddleRight;
            chklowercase.Location = new Point(59, 246);
            chklowercase.Name = "chklowercase";
            chklowercase.Size = new Size(158, 19);
            chklowercase.TabIndex = 4;
            chklowercase.Text = "Include lowercase letters ";
            chklowercase.UseVisualStyleBackColor = true;
            // 
            // chknumber
            // 
            chknumber.AutoSize = true;
            chknumber.CheckAlign = ContentAlignment.MiddleRight;
            chknumber.Location = new Point(59, 277);
            chknumber.Name = "chknumber";
            chknumber.Size = new Size(157, 19);
            chknumber.TabIndex = 5;
            chknumber.Text = "Include numbers              ";
            chknumber.UseVisualStyleBackColor = true;
            // 
            // chksymbols
            // 
            chksymbols.AutoSize = true;
            chksymbols.CheckAlign = ContentAlignment.MiddleRight;
            chksymbols.Location = new Point(59, 308);
            chksymbols.Name = "chksymbols";
            chksymbols.Size = new Size(157, 19);
            chksymbols.TabIndex = 6;
            chksymbols.Text = "Include symbols               ";
            chksymbols.UseVisualStyleBackColor = true;
            // 
            // txtlength
            // 
            txtlength.Location = new Point(200, 181);
            txtlength.Name = "txtlength";
            txtlength.Size = new Size(100, 23);
            txtlength.TabIndex = 7;
            txtlength.KeyPress += txtlength_KeyPress;
            // 
            // btngenerate
            // 
            btngenerate.BackColor = Color.Teal;
            btngenerate.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btngenerate.FlatAppearance.BorderSize = 3;
            btngenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btngenerate.ForeColor = Color.White;
            btngenerate.Location = new Point(123, 333);
            btngenerate.Name = "btngenerate";
            btngenerate.Size = new Size(137, 36);
            btngenerate.TabIndex = 8;
            btngenerate.Text = "Generate";
            btngenerate.UseVisualStyleBackColor = false;
            btngenerate.Click += btngenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(427, 381);
            Controls.Add(btngenerate);
            Controls.Add(txtlength);
            Controls.Add(chksymbols);
            Controls.Add(chknumber);
            Controls.Add(chklowercase);
            Controls.Add(chkuppercase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpassword;
        private Label label1;
        private Label label2;
        private CheckBox chkuppercase;
        private CheckBox chklowercase;
        private CheckBox chknumber;
        private CheckBox chksymbols;
        private TextBox txtlength;
        private Button btngenerate;
    }
}