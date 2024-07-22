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

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pos
{
    public partial class Frm_Purchase : Form
    {
        SqlConnection string_con;
        SqlCommand sql_command;
        public Frm_Purchase()
        {
            InitializeComponent();
            fill_combo();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection cn = new connection();
                string_con = new SqlConnection(cn.connec);
                string_con.Open();
                string sql = "INSERT INTO tbl_stock (product_barcode_id,product_price,product_qty) VALUES('" + product_item_id_fk.Text + "','" + Convert.ToDecimal(product_price.Text) + "','" + product_qty.Text + "')";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void product_item_id_fk_TextChanged(object sender, EventArgs e)
        {

            if (product_item_id_fk.TextLength == 7)
            {
                connection cn = new connection();
                string_con = new SqlConnection(cn.connec);
                string_con.Open();
                string selectquery = "select * from product_item where product_barcode_id ='" + product_item_id_fk.Text + "'";
                SqlCommand cmd = new SqlCommand(selectquery, string_con);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {

                    product_item_name.Text = reader1["product_item_name"].ToString();
                    product_item_desc.Text = reader1["product_item_desc"].ToString();
                    product_item_avaliblity.Text = reader1["product_item_avaliblity"].ToString();
                    product_barcode_id.Text = reader1["product_barcode_id"].ToString();
                    comboBox1.SelectedValue = reader1["product_cat_fk_id"].ToString();

                }
                else
                {
                    MessageBox.Show("PLEASE FIRST REGISTER YOUR PRODUCT IN ITEM LIST");
                }
                string_con.Close();
            }
            else
            {

                clear();
            }


        }
        public void clear()
        {
            product_item_name.Text = "";
            product_item_desc.Text = "";
            product_item_avaliblity.Text = "";
            product_barcode_id.Text = "";
            //comboBox1.SelectedValue = null;

        }
        private void product_qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
