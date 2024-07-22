namespace pos
{
    partial class Frm_Purchase
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
            product_qty = new TextBox();
            product_price = new TextBox();
            button1 = new Button();
            product_item_id_fk = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            product_barcode_id = new TextBox();
            comboBox1 = new ComboBox();
            product_item_avaliblity = new TextBox();
            product_item_desc = new TextBox();
            product_item_name = new TextBox();
            label11 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // product_qty
            // 
            product_qty.Location = new Point(183, 187);
            product_qty.Name = "product_qty";
            product_qty.PlaceholderText = "Product Quantity";
            product_qty.Size = new Size(197, 23);
            product_qty.TabIndex = 0;
            product_qty.TextChanged += product_qty_TextChanged;
            // 
            // product_price
            // 
            product_price.Location = new Point(183, 130);
            product_price.Name = "product_price";
            product_price.PlaceholderText = "Product Price";
            product_price.Size = new Size(197, 23);
            product_price.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(228, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // product_item_id_fk
            // 
            product_item_id_fk.Location = new Point(183, 75);
            product_item_id_fk.Name = "product_item_id_fk";
            product_item_id_fk.PlaceholderText = "Product Barcode ID";
            product_item_id_fk.Size = new Size(197, 23);
            product_item_id_fk.TabIndex = 4;
            product_item_id_fk.TextChanged += product_item_id_fk_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 77);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 7;
            label3.Text = "Barcode Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 29);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "Purchase Form ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 226);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 21;
            label6.Text = "Product Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 194);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 20;
            label5.Text = "Barcode ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 165);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 19;
            label7.Text = "Product Availabilty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(416, 120);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 17;
            label9.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(416, 78);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 16;
            label10.Text = "Product Name";
            // 
            // product_barcode_id
            // 
            product_barcode_id.BackColor = SystemColors.InactiveCaption;
            product_barcode_id.Location = new Point(524, 186);
            product_barcode_id.Name = "product_barcode_id";
            product_barcode_id.Size = new Size(158, 23);
            product_barcode_id.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(524, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 14;
            // 
            // product_item_avaliblity
            // 
            product_item_avaliblity.BackColor = SystemColors.InactiveCaption;
            product_item_avaliblity.Location = new Point(524, 157);
            product_item_avaliblity.Name = "product_item_avaliblity";
            product_item_avaliblity.Size = new Size(156, 23);
            product_item_avaliblity.TabIndex = 10;
            // 
            // product_item_desc
            // 
            product_item_desc.BackColor = SystemColors.InactiveCaption;
            product_item_desc.Location = new Point(524, 117);
            product_item_desc.Name = "product_item_desc";
            product_item_desc.Size = new Size(156, 23);
            product_item_desc.TabIndex = 12;
            // 
            // product_item_name
            // 
            product_item_name.BackColor = SystemColors.InactiveCaption;
            product_item_name.Location = new Point(524, 75);
            product_item_name.Name = "product_item_name";
            product_item_name.Size = new Size(156, 23);
            product_item_name.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(89, 132);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 22;
            label11.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 191);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 23;
            label1.Text = "Quantity";
            // 
            // Frm_Purchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label10);
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
            Name = "Frm_Purchase";
            Text = "Frm_Stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox product_qty;
        private TextBox product_price;
        private Button button1;
        private TextBox product_item_id_fk;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label10;
        private TextBox product_barcode_id;
        private ComboBox comboBox1;
        private TextBox product_item_avaliblity;
        private TextBox product_item_desc;
        private TextBox product_item_name;
        private Label label11;
        private Label label1;
    }
}