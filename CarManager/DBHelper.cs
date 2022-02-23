using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager
{
    
    public class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" +
                "initial Catalog = {1};" +
                "Integrated Security={2};" +
                "Timeout=3",
                "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void selectQuery(int parkingSpot = -1)
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (parkingSpot < 0)
            {
                //모든 값을 조회
                cmd.CommandText = "select*from CarManager";
            }
            else
            {
                //내가 지정한 값만 조회
                cmd.CommandText = "select * from CarManager where ParkingSpot = " + parkingSpot;
            }

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "CarManager");
            dt = ds.Tables[0];

            conn.Close();
        }

        public static void insertQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                string sqlcommand = "insert into carManager (parkingSpot) values (@p1)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection= conn;
                cmd.CommandType= CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close(); //테이블 연결  후 뭔가 잘못되면 무조건 db 연결부터 닫는다.
                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine+ex.StackTrace);
                //throw;
            }
        }

        //주차 및 출차
        public static void updateQuery(string parkingSpotText, string carNumberText,string driverNameText, string phoneNumber, bool isRemove = false)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand;
                if (isRemove)//출차
                {
                    sqlcommand = "UPDATE CarManager set CarNumber='', DriverName='', phoneNumber='', parkingTime= null where ParkingSpot=@p1";
                    cmd.Parameters.AddWithValue("@p1", parkingSpotText);
                }
                else//주차
                {
                    sqlcommand = "update CarManager set CarNumber=@p1, DriverName=@p2, PhoneNumber=@p3, ParkingTime=@p4 where ParkingSpot=@p5";

                    cmd.Parameters.AddWithValue("@p1", carNumberText);
                    cmd.Parameters.AddWithValue("@p2", driverNameText);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpotText);
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close ();
            }
            catch (Exception ex)
            {
                conn.Close ();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
