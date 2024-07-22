namespace pos
{
    partial class frm_Main
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
            menuStrip1 = new MenuStrip();
            masterFileToolStripMenuItem = new ToolStripMenuItem();
            cAategoryFileToolStripMenuItem = new ToolStripMenuItem();
            itemFileToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            salesFormToolStripMenuItem = new ToolStripMenuItem();
            customerFormToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterFileToolStripMenuItem
            // 
            masterFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cAategoryFileToolStripMenuItem, itemFileToolStripMenuItem, userToolStripMenuItem, stockToolStripMenuItem, salesFormToolStripMenuItem, customerFormToolStripMenuItem });
            masterFileToolStripMenuItem.Name = "masterFileToolStripMenuItem";
            masterFileToolStripMenuItem.Size = new Size(76, 20);
            masterFileToolStripMenuItem.Text = "Master File";
            // 
            // cAategoryFileToolStripMenuItem
            // 
            cAategoryFileToolStripMenuItem.Name = "cAategoryFileToolStripMenuItem";
            cAategoryFileToolStripMenuItem.Size = new Size(180, 22);
            cAategoryFileToolStripMenuItem.Text = "Category Form";
            cAategoryFileToolStripMenuItem.Click += cAategoryFileToolStripMenuItem_Click;
            // 
            // itemFileToolStripMenuItem
            // 
            itemFileToolStripMenuItem.Name = "itemFileToolStripMenuItem";
            itemFileToolStripMenuItem.Size = new Size(180, 22);
            itemFileToolStripMenuItem.Text = "Product Form";
            itemFileToolStripMenuItem.Click += itemFileToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(180, 22);
            userToolStripMenuItem.Text = "User Registeration";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(180, 22);
            stockToolStripMenuItem.Text = "Purchase Form";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // salesFormToolStripMenuItem
            // 
            salesFormToolStripMenuItem.Name = "salesFormToolStripMenuItem";
            salesFormToolStripMenuItem.Size = new Size(180, 22);
            salesFormToolStripMenuItem.Text = "Sales Form";
            salesFormToolStripMenuItem.Click += salesFormToolStripMenuItem_Click;
            // 
            // customerFormToolStripMenuItem
            // 
            customerFormToolStripMenuItem.Name = "customerFormToolStripMenuItem";
            customerFormToolStripMenuItem.Size = new Size(180, 22);
            customerFormToolStripMenuItem.Text = "Customer Form";
            customerFormToolStripMenuItem.Click += customerFormToolStripMenuItem_Click;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_Main";
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterFileToolStripMenuItem;
        private ToolStripMenuItem cAategoryFileToolStripMenuItem;
        private ToolStripMenuItem itemFileToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem salesFormToolStripMenuItem;
        private ToolStripMenuItem customerFormToolStripMenuItem;
    }
}