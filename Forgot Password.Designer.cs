
namespace Digital_Book_Ordering_System_GUI
{
    partial class frmForgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgot_Password));
            this.grpForgotPassword = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSearchPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpForgotPassword
            // 
            this.grpForgotPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpForgotPassword.BackgroundImage")));
            this.grpForgotPassword.Controls.Add(this.button1);
            this.grpForgotPassword.Controls.Add(this.txtUsername);
            this.grpForgotPassword.Controls.Add(this.btnSearchPassword);
            this.grpForgotPassword.Controls.Add(this.label1);
            this.grpForgotPassword.Location = new System.Drawing.Point(721, 390);
            this.grpForgotPassword.Name = "grpForgotPassword";
            this.grpForgotPassword.Size = new System.Drawing.Size(569, 244);
            this.grpForgotPassword.TabIndex = 0;
            this.grpForgotPassword.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(392, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(232, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(247, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.BackColor = System.Drawing.Color.Tan;
            this.btnSearchPassword.Location = new System.Drawing.Point(232, 166);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Size = new System.Drawing.Size(82, 49);
            this.btnSearchPassword.TabIndex = 1;
            this.btnSearchPassword.Text = "Search";
            this.btnSearchPassword.UseVisualStyleBackColor = false;
            this.btnSearchPassword.Click += new System.EventHandler(this.btnSearchPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username:";
            // 
            // frmForgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 808);
            this.Controls.Add(this.grpForgotPassword);
            this.Name = "frmForgot_Password";
            this.Text = "Forgot_Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmForgot_Password_Load);
            this.grpForgotPassword.ResumeLayout(false);
            this.grpForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForgotPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSearchPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}