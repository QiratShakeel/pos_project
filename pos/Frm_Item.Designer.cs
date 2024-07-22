namespace pos
{
    partial class Frm_Item
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
            product_item_name = new TextBox();
            product_item_desc = new TextBox();
            product_item_avaliblity = new TextBox();
            btn_product = new Button();
            comboBox1 = new ComboBox();
            product_barcode_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // product_item_name
            // 
            product_item_name.Location = new Point(391, 32);
            product_item_name.Name = "product_item_name";
            product_item_name.Size = new Size(156, 23);
            product_item_name.TabIndex = 0;
            // 
            // product_item_desc
            // 
            product_item_desc.Location = new Point(391, 74);
            product_item_desc.Name = "product_item_desc";
            product_item_desc.Size = new Size(156, 23);
            product_item_desc.TabIndex = 0;
            // 
            // product_item_avaliblity
            // 
            product_item_avaliblity.Location = new Point(391, 116);
            product_item_avaliblity.Name = "product_item_avaliblity";
            product_item_avaliblity.Size = new Size(156, 23);
            product_item_avaliblity.TabIndex = 0;
            // 
            // btn_product
            // 
            btn_product.Location = new Point(439, 216);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(75, 23);
            btn_product.TabIndex = 1;
            btn_product.Text = "Submit";
            btn_product.UseVisualStyleBackColor = true;
            btn_product.Click += btn_product_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(390, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 2;
            // 
            // product_barcode_id
            // 
            product_barcode_id.Location = new Point(390, 145);
            product_barcode_id.Name = "product_barcode_id";
            product_barcode_id.Size = new Size(158, 23);
            product_barcode_id.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 124);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 7;
            label4.Text = "Product Availabilty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 153);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 8;
            label5.Text = "Barcode ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 185);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 9;
            label6.Text = "Product Category";
            // 
            // Frm_Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(product_barcode_id);
            Controls.Add(comboBox1);
            Controls.Add(btn_product);
            Controls.Add(product_item_avaliblity);
            Controls.Add(product_item_desc);
            Controls.Add(product_item_name);
            Name = "Frm_Item";
            Text = "Frm_Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox product_item_name;
        private TextBox product_item_desc;
        private TextBox product_item_avaliblity;
        private Button btn_product;
        private ComboBox comboBox1;
        private TextBox product_barcode_id;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}