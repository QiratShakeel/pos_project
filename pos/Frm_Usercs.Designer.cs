namespace pos
{
    partial class Frm_Usercs
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
            users_name = new TextBox();
            users_email = new TextBox();
            users_password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // users_name
            // 
            users_name.Location = new Point(356, 79);
            users_name.Name = "users_name";
            users_name.Size = new Size(100, 23);
            users_name.TabIndex = 0;
            users_name.TextChanged += users_name_TextChanged;
            // 
            // users_email
            // 
            users_email.Location = new Point(356, 122);
            users_email.Name = "users_email";
            users_email.Size = new Size(100, 23);
            users_email.TabIndex = 1;
            users_email.TextChanged += users_email_TextChanged;
            // 
            // users_password
            // 
            users_password.Location = new Point(356, 167);
            users_password.Name = "users_password";
            users_password.Size = new Size(100, 23);
            users_password.TabIndex = 2;
            users_password.TextChanged += users_password_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(369, 217);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 87);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 125);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 31);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "User Form";
            label4.Click += label4_Click;
            // 
            // Frm_Usercs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(users_password);
            Controls.Add(users_email);
            Controls.Add(users_name);
            Name = "Frm_Usercs";
            Text = "Frm_Usercs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox users_name;
        private TextBox users_email;
        private TextBox users_password;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}