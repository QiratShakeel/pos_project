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
    public partial class Form_Sale : Form
    {
        SqlConnection string_con;
        SqlCommand sql_command;
        public Form_Sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection cn = new connection();
                string_con = new SqlConnection(cn.connec);
                string_con.Open();
                string sql = "INSERT INTO tbl_sale_details (product_barcode_id,product_price,product_qty) VALUES('" + product_item_id_fk.Text + "','" + Convert.ToDecimal(product_price.Text) + "','" + product_qty.Text + "')";
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
        public void clear()
        {
            product_item_name.Text = "";
            product_item_desc.Text = "";
            product_item_avaliblity.Text = "";
            product_barcode_id.Text = "";
            //comboBox1.SelectedValue = null;

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


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection cn = new connection();
                string_con = new SqlConnection(cn.connec);
                string_con.Open();
                string sql = "INSERT INTO tbl_sales_master (sales_id,customer_name,customer_email,customer_address,customer_number) VALUES('" + sales_id.Text + "','" + customer_name.Text + "','" + customer_email.Text + "','" + customer_address.Text + "','" + customer_number.Text + "')";
                sql_command = new SqlCommand();
                sql_command.Connection = string_con;
                sql_command.CommandText = sql;
                int result = sql_command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data has been saved in the SQL database");
                    product_item_id_fk.Enabled = true;
                    product_price.Enabled = true; ;
                    product_qty.Enabled = true;
                    button2.Enabled = false;
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



        public void get_saleid()
        {

            connection cn = new connection();
            string_con = new SqlConnection(cn.connec);
            string_con.Open();
            SqlCommand da = new SqlCommand("Select  isnull(max(sales_id),0) sale_id from tbl_sales_master", string_con);
            SqlDataReader sda = da.ExecuteReader();
            if (sda.Read())
            {
                if (Convert.ToInt32(sda["sale_id"]) + 1 < 10)
                {
                    sales_id.Text = "00000" + (Convert.ToInt32(sda["sale_id"]) + 1);
                }
                else if (Convert.ToInt32(sda["sale_id"]) + 1 < 100)
                {
                    sales_id.Text = "0000" + (Convert.ToInt32(sda["sale_id"]) + 1);
                }
                else if (Convert.ToInt32(sda["sale_id"]) + 1 < 1000)
                {
                    sales_id.Text = "000" + (Convert.ToInt32(sda["sale_id"]) + 1);
                }
                else if (Convert.ToInt32(sda["sale_id"]) + 1 < 10000)
                {
                    sales_id.Text = "00" + (Convert.ToInt32(sda["sale_id"]) + 1);
                }
                else if (Convert.ToInt32(sda["sale_id"]) + 1 < 100000)
                {
                    sales_id.Text = "0" + (Convert.ToInt32(sda["sale_id"]) + 1);
                }
                else if (Convert.ToInt32(sda["sale_id"]) + 1 < 1000000)
                {
                    sales_id.Text = "" + (Convert.ToInt32(sda["sale_id"]) + 1);
                }
                //sales_id.Text = (Convert.ToInt32(sda["sale_id"]) + 1).ToString();
            }

        }

        private void Form_Sale_Load(object sender, EventArgs e)
        {
            get_saleid();
            sales_id.Enabled = false;
            product_item_id_fk.Enabled = false;
            product_price.Enabled = false; ;
            product_qty.Enabled = false;

        }
    }
}
