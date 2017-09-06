namespace HumaneSociety.CustomerUser
{
    partial class LoginForm
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
            this.Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(187, 31);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(185, 31);
            this.Number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone Number";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(31, 104);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(150, 57);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(222, 104);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(150, 57);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 229);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Close;
    }
}