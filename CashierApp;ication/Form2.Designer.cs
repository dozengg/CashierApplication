namespace CashierApp_ication
{
    partial class Form2
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
            this.usename = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.Passw = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usename
            // 
            this.usename.AutoSize = true;
            this.usename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usename.Location = new System.Drawing.Point(40, 38);
            this.usename.Name = "usename";
            this.usename.Size = new System.Drawing.Size(173, 37);
            this.usename.TabIndex = 0;
            this.usename.Text = "Username:";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(47, 78);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(323, 46);
            this.Log.TabIndex = 1;
            this.Log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(40, 139);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(167, 37);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Password:";
            // 
            // Passw
            // 
            this.Passw.Location = new System.Drawing.Point(47, 179);
            this.Passw.Multiline = true;
            this.Passw.Name = "Passw";
            this.Passw.Size = new System.Drawing.Size(323, 46);
            this.Passw.TabIndex = 3;
            // 
            // LOGIN
            // 
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(47, 258);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(297, 49);
            this.LOGIN.TabIndex = 4;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 341);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.Passw);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.usename);
            this.Name = "Form2";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usename;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox Passw;
        private System.Windows.Forms.Button LOGIN;
    }
}