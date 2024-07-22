using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void itemFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Item frm_Item = new Frm_Item();
            frm_Item.Show();
        }

        private void cAategoryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usercs frm = new Frm_Usercs();
            frm.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Purchase frm = new Frm_Purchase();
            frm.Show();
        }

        private void salesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sale frm = new Form_Sale();
            frm.Show();
        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Customer frm = new Frm_Customer();
            frm.Show();
        }
    }
}
