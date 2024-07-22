namespace pos
{
    partial class Form_Sale
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
            label1 = new Label();
            label11 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            product_barcode_id = new TextBox();
            comboBox1 = new ComboBox();
            product_item_avaliblity = new TextBox();
            product_item_desc = new TextBox();
            product_item_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            product_item_id_fk = new TextBox();
            button1 = new Button();
            product_price = new TextBox();
            product_qty = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            sales_id = new TextBox();
            button2 = new Button();
            label13 = new Label();
            customer_email = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label12 = new Label();
            customer_name = new TextBox();
            customer_number = new TextBox();
            customer_address = new TextBox();
            tabPage2 = new TabPage();
            label14 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(92, 300);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 41;
            label1.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(109, 272);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 40;
            label11.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 384);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 39;
            label6.Text = "Product Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 352);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 38;
            label5.Text = "Barcode ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 323);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 37;
            label7.Text = "Product Availabilty";
            // 
            // product_barcode_id
            // 
            product_barcode_id.BackColor = SystemColors.InactiveCaption;
            product_barcode_id.Location = new Point(545, 344);
            product_barcode_id.Name = "product_barcode_id";
            product_barcode_id.Size = new Size(158, 23);
            product_barcode_id.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(546, 376);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 33;
            // 
            // product_item_avaliblity
            // 
            product_item_avaliblity.BackColor = SystemColors.InactiveCaption;
            product_item_avaliblity.Location = new Point(545, 315);
            product_item_avaliblity.Name = "product_item_avaliblity";
            product_item_avaliblity.Size = new Size(156, 23);
            product_item_avaliblity.TabIndex = 30;
            // 
            // product_item_desc
            // 
            product_item_desc.BackColor = SystemColors.InactiveCaption;
            product_item_desc.Location = new Point(545, 270);
            product_item_desc.Name = "product_item_desc";
            product_item_desc.Size = new Size(156, 23);
            product_item_desc.TabIndex = 31;
            // 
            // product_item_name
            // 
            product_item_name.BackColor = SystemColors.InactiveCaption;
            product_item_name.Location = new Point(545, 233);
            product_item_name.Name = "product_item_name";
            product_item_name.Size = new Size(156, 23);
            product_item_name.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 32);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 29;
            label4.Text = "Sales Form ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 235);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 28;
            label3.Text = "Barcode Id";
            // 
            // product_item_id_fk
            // 
            product_item_id_fk.Location = new Point(196, 233);
            product_item_id_fk.Name = "product_item_id_fk";
            product_item_id_fk.PlaceholderText = "Product Barcode ID";
            product_item_id_fk.Size = new Size(197, 23);
            product_item_id_fk.TabIndex = 6;
            product_item_id_fk.TextChanged += product_item_id_fk_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(242, 343);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // product_price
            // 
            product_price.Location = new Point(196, 269);
            product_price.Name = "product_price";
            product_price.PlaceholderText = "Product Price";
            product_price.Size = new Size(197, 23);
            product_price.TabIndex = 7;
            // 
            // product_qty
            // 
            product_qty.Location = new Point(196, 298);
            product_qty.Name = "product_qty";
            product_qty.PlaceholderText = "Product Quantity";
            product_qty.Size = new Size(197, 23);
            product_qty.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(32, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(746, 166);
            tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(sales_id);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(customer_email);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(customer_name);
            tabPage1.Controls.Add(customer_number);
            tabPage1.Controls.Add(customer_address);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(738, 138);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cash Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(66, 109);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 52;
            label9.Text = "Sales Id";
            // 
            // sales_id
            // 
            sales_id.Location = new Point(160, 109);
            sales_id.Name = "sales_id";
            sales_id.PlaceholderText = "Enter Sales Id";
            sales_id.Size = new Size(149, 23);
            sales_id.TabIndex = 51;
            // 
            // button2
            // 
            button2.Location = new Point(320, 76);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(425, 14);
            label13.Name = "label13";
            label13.Size = new Size(60, 21);
            label13.TabIndex = 49;
            label13.Text = "Email";
            // 
            // customer_email
            // 
            customer_email.Location = new Point(516, 12);
            customer_email.Name = "customer_email";
            customer_email.PlaceholderText = "Email";
            customer_email.Size = new Size(149, 23);
            customer_email.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 46);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 47;
            label2.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(358, 43);
            label8.Name = "label8";
            label8.Size = new Size(143, 21);
            label8.TabIndex = 46;
            label8.Text = "Phone Number ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(30, 9);
            label12.Name = "label12";
            label12.Size = new Size(146, 21);
            label12.TabIndex = 45;
            label12.Text = "Customer Name";
            // 
            // customer_name
            // 
            customer_name.Location = new Point(182, 9);
            customer_name.Name = "customer_name";
            customer_name.PlaceholderText = "Customer Name ";
            customer_name.Size = new Size(149, 23);
            customer_name.TabIndex = 1;
            // 
            // customer_number
            // 
            customer_number.Location = new Point(516, 44);
            customer_number.Name = "customer_number";
            customer_number.PlaceholderText = "Phone Number";
            customer_number.Size = new Size(149, 23);
            customer_number.TabIndex = 4;
            // 
            // customer_address
            // 
            customer_address.Location = new Point(182, 47);
            customer_address.Name = "customer_address";
            customer_address.PlaceholderText = "Address";
            customer_address.Size = new Size(149, 23);
            customer_address.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(738, 138);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Member";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(399, 235);
            label14.Name = "label14";
            label14.Size = new Size(140, 21);
            label14.TabIndex = 43;
            label14.Text = "Product Name ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(399, 269);
            label10.Name = "label10";
            label10.Size = new Size(115, 21);
            label10.TabIndex = 44;
            label10.Text = "Description ";
            // 
            // Form_Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(product_barcode_id);
            Controls.Add(comboBox1);
            Controls.Add(product_item_avaliblity);
            Controls.Add(product_item_desc);
            Controls.Add(product_item_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(product_item_id_fk);
            Controls.Add(button1);
            Controls.Add(product_price);
            Controls.Add(product_qty);
            Name = "Form_Sale";
            Text = "Form_Sale";
            Load += Form_Sale_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox product_barcode_id;
        private ComboBox comboBox1;
        private TextBox product_item_avaliblity;
        private TextBox product_item_desc;
        private TextBox product_item_name;
        private Label label4;
        private Label label3;
        private TextBox product_item_id_fk;
        private Button button1;
        private TextBox product_price;
        private TextBox product_qty;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label8;
        private Label label12;
        private TextBox customer_name;
        private TextBox customer_number;
        private TextBox customer_address;
        private TabPage tabPage2;
        private Label label13;
        private TextBox customer_email;
        private Label label14;
        private Label label10;
        private Button button2;
        private Label label9;
        private TextBox sales_id;
    }
}