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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pos
{
    public partial class Frm_Usercs : Form
    {
        SqlConnection string_con;
        SqlCommand sql_command;
        public Frm_Usercs()
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
                string sql = "INSERT INTO tbl_user (users_name,users_email,users_password) VALUES('" + users_name.Text + "','" + users_email.Text + "','" + users_password.Text + "')";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void users_password_TextChanged(object sender, EventArgs e)
        {
        }

        private void users_email_TextChanged(object sender, EventArgs e)
        {
        }

        private void users_name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
