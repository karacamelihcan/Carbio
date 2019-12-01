namespace CarBio_30._11._2019
{
    partial class Personel_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Login));
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnRegistergLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSıgnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(324, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 98);
            this.label3.TabIndex = 20;
            this.label3.Text = "Personel Login Panel";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPassword.Location = new System.Drawing.Point(500, 327);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(403, 50);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEmail.Location = new System.Drawing.Point(500, 268);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(403, 50);
            this.tbEmail.TabIndex = 1;
            // 
            // btnRegistergLogIn
            // 
            this.btnRegistergLogIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegistergLogIn.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegistergLogIn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistergLogIn.Location = new System.Drawing.Point(676, 446);
            this.btnRegistergLogIn.Name = "btnRegistergLogIn";
            this.btnRegistergLogIn.Size = new System.Drawing.Size(247, 78);
            this.btnRegistergLogIn.TabIndex = 4;
            this.btnRegistergLogIn.Text = "Register";
            this.btnRegistergLogIn.UseVisualStyleBackColor = false;
            this.btnRegistergLogIn.Click += new System.EventHandler(this.btnRegistergLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(256, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 43);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password:";
            // 
            // btnSıgnIn
            // 
            this.btnSıgnIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSıgnIn.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıgnIn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSıgnIn.Location = new System.Drawing.Point(362, 446);
            this.btnSıgnIn.Name = "btnSıgnIn";
            this.btnSıgnIn.Size = new System.Drawing.Size(247, 78);
            this.btnSıgnIn.TabIndex = 3;
            this.btnSıgnIn.Text = "SignIn";
            this.btnSıgnIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(331, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email:";
            // 
            // Personel_Login
            // 
            this.AcceptButton = this.btnSıgnIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1268, 708);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnRegistergLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSıgnIn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personel_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnRegistergLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSıgnIn;
        private System.Windows.Forms.Label label1;
    }
}