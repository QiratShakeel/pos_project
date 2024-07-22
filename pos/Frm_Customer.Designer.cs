namespace pos
{
    partial class Frm_Customer
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
            button1 = new Button();
            label13 = new Label();
            customer_email = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label12 = new Label();
            customer_name = new TextBox();
            customer_number = new TextBox();
            customer_address = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(371, 262);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(281, 216);
            label13.Name = "label13";
            label13.Size = new Size(60, 21);
            label13.TabIndex = 57;
            label13.Text = "Email";
            // 
            // customer_email
            // 
            customer_email.Location = new Point(378, 214);
            customer_email.Name = "customer_email";
            customer_email.PlaceholderText = "Email";
            customer_email.Size = new Size(149, 23);
            customer_email.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(289, 173);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 55;
            label5.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(241, 130);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 54;
            label8.Text = "Phone Number ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(241, 91);
            label12.Name = "label12";
            label12.Size = new Size(146, 21);
            label12.TabIndex = 53;
            label12.Text = "Customer Name";
            // 
            // customer_name
            // 
            customer_name.Location = new Point(393, 89);
            customer_name.Name = "customer_name";
            customer_name.PlaceholderText = "Customer Name ";
            customer_name.Size = new Size(149, 23);
            customer_name.TabIndex = 52;
            // 
            // customer_number
            // 
            customer_number.Location = new Point(393, 130);
            customer_number.Name = "customer_number";
            customer_number.PlaceholderText = "Phone Number";
            customer_number.Size = new Size(149, 23);
            customer_number.TabIndex = 51;
            // 
            // customer_address
            // 
            customer_address.Location = new Point(393, 171);
            customer_address.Name = "customer_address";
            customer_address.PlaceholderText = "Address";
            customer_address.Size = new Size(149, 23);
            customer_address.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(325, 44);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 58;
            label1.Text = "Customer Form";
            label1.Click += label1_Click;
            // 
            // Frm_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(customer_email);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(customer_name);
            Controls.Add(customer_number);
            Controls.Add(customer_address);
            Controls.Add(button1);
            Name = "Frm_Customer";
            Text = "Frm_Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label13;
        private TextBox customer_email;
        private Label label5;
        private Label label8;
        private Label label12;
        private TextBox customer_name;
        private TextBox customer_number;
        private TextBox customer_address;
        private Label label1;
    }
}