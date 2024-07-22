using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace pos
{
    public partial class Form1 : Form
    {

        SqlConnection string_con;
        SqlCommand sql_command;
        public Form1()
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
                string sql = "INSERT INTO product_category (product_cat) VALUES('" + txt_cat.Text + "')";
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
    }
}