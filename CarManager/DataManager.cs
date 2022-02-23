using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear();
                foreach(DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot = int.Parse(item["ParkingSpot"].ToString());
                    car.CarNumber = item["CarNumber"].ToString();
                    car.DriverName = item["DriverName"].ToString();
                    car.PhoneNumber = item["PhoneNumber"].ToString();
                    car.ParkingTime = item["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());
                    Cars.Add(car);
                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message+Environment.NewLine+ex.StackTrace);
            }
        }
        public static void save(string parkingSpotText,string driverNameText, string carNumberText, string phoneNumber, bool isRemove = false)
        {
            try
            {
                //주차 or 출차로 인하여 상태가 변하였으므로 update문을 호출하여 db table
                DBHelper.updateQuery(parkingSpotText, carNumberText, driverNameText, phoneNumber, isRemove);
            }
            catch (Exception exception)
            {

                System.Windows.Forms.MessageBox.Show(exception.Message+Environment.NewLine+exception.StackTrace);
            }
        }

        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");

            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new  StreamWriter("ParkingHistory" + "\\" + "ParkingHistory" + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
