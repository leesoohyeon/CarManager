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

namespace Study_DB
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" +
                "initial Catalog = {1};" +
                "Integrated Security={2};" +
                "Timeout=3",
                "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        private void Query_Select()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM TB_CUST";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TB_CUST");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TB_CUST";

            conn.Close();
        }

        private void Query_Insert()
        {
            //기본키 중복될 수 있으니, try catch로 묶는다.
            //try 하고 tap tap 누르면 됨
            try
            {
                ConnectDB();

                string sqlcommand = "Insert into TB_CUST (CUST_ID, BIRTH_DT) values (@param1, @p2)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection= conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@param1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);

                cmd.CommandText= sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                //Environment.NewLine
                // \n이랑 똑같은거
                //os마다 개향 문자가 다른데, 그걸 자동으로 맞춰주는 것이라고 버면됨
                conn.Close();
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                //throw;
            }
        }

        private void Query_Update()
        {
            try
            {
                ConnectDB();

                string sqlcommand = "UPDATE TB_CUST SET BIRTH_DT=@P1 WHERE CUST_ID=@P2";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@P1", textBox2.Text);
                cmd.Parameters.AddWithValue("@P2", textBox1.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                //Environment.NewLine
                // \n이랑 똑같은거
                //os마다 개향 문자가 다른데, 그걸 자동으로 맞춰주는 것이라고 버면됨
                conn.Close();
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                //throw;
            }
        }

        private void Query_Delete()
        {
            try
            {
                ConnectDB();

                string sqlcommand = "DELETE TB_CUST WHERE CUST_ID=@P1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@P1", textBox1.Text);
               

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                //Environment.NewLine
                // \n이랑 똑같은거
                //os마다 개향 문자가 다른데, 그걸 자동으로 맞춰주는 것이라고 버면됨
                conn.Close();
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query_Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query_Insert();
            Query_Select();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query_Update();
            Query_Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Query_Delete();
            Query_Select();
        }
    }
}
