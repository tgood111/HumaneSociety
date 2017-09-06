namespace HumaneSociety.CustomerUser
{
    partial class CustomerMainMenu
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
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(17, 31);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(103, 47);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(126, 31);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(103, 47);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 98);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Name = "CustomerMainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
    }
}