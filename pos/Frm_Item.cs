using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class Frm_Item : Form
    {
        SqlConnection string_con;
        SqlCommand sql_command;
        public Frm_Item()
        {
            InitializeComponent();
            fill_combo();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }


        public void fill_combo()
        {


            connection cn = new connection();
            string_con = new SqlConnection(cn.connec);
            string_con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from product_category", string_con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "product_cat";
            comboBox1.ValueMember = "product_cat_id";

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            try
            {
                connection cn = new connection();
                string_con = new SqlConnection(cn.connec);
                string_con.Open();
                string sql = "INSERT INTO product_item (product_item_name,product_item_desc,product_item_avaliblity,product_cat_fk_id,product_barcode_id) VALUES('" + product_item_name.Text + "','" + product_item_desc.Text + "','" + product_item_avaliblity.Text + "','" + comboBox1.SelectedValue.ToString() + "','" + product_barcode_id.Text + "')";
                sql_command = new SqlCommand();
                sql_command.Connection = string_con;
                sql_command.CommandText = sql;
                int result = sql_command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data has been saved in the SQL database");
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
                //closing connection
                string_con.Close();

            }
            catch (Exception ex)//catch exeption
            {
                //displaying errors message.
                MessageBox.Show(ex.Message);
            }
        }

        private void product_item_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
