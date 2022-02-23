using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                textBox_parkingspot.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carnumber.Text = DataManager.Cars[0].CarNumber.ToString();
                textBox_drivername.Text = DataManager.Cars[0].DriverName.ToString();
                textBox_phonenumber.Text = DataManager.Cars[0].PhoneNumber.ToString();
            }
            catch (Exception ex) //메모장에 로그를 남김
            {
                DataManager.PrintLog("초창기 데이터가 없습니다.");
                DataManager.PrintLog(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
             //   throw;
            }
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }
        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_parkingadd_Click(object sender, EventArgs e)
        {
            if (textBox_parkingspot.Text.Trim() == "")
                MessageBox.Show("주차공간을 입력하세요.");
            else if(textBox_carnumber.Text.Trim() =="")
                MessageBox.Show("차량 번호 입력해주세요.");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingspot.Text);
                    if(car.CarNumber.Trim() != "")
                    {
                        MessageBox.Show("해당 공간에 이미 차가 있습니다.");
                    }
                    else
                    {
                        car.CarNumber = textBox_carnumber.Text;
                        car.DriverName = textBox_drivername.Text;
                        car.PhoneNumber = textBox_phonenumber.Text;
                        car.ParkingTime = DateTime.Now;

                        //새로고침
                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.save(textBox_parkingspot.Text, textBox_carnumber.Text, textBox_drivername.Text, textBox_phonenumber.Text);
                        
                        string contents = $"주차공간 {textBox_parkingspot.Text}에 {textBox_carnumber.Text}차를 주차했습니다.";

                        WriteLog(contents);

                    }
                }
                catch (Exception ex) //존재하지 않는 주차 공간에 접근한 경우
                {
                    string contents = $"주차공간 {textBox_parkingspot.Text}은(는)없습니다.";
                    MessageBox.Show(contents);

                }
            }
        }

        private void WriteLog(string contents)
        {
            //이 함수 구현 안 되었다는 에러 메시지임
            //throw new NotImplementedException();

            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff")}]{contents}";
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0, logContents);
            //listBox_logPrint.Items.Add(logContents);
        }

        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;
                textBox_parkingspot.Text = car.ParkingSpot.ToString();
                textBox_carnumber.Text = car.CarNumber;
                textBox_drivername.Text = car.DriverName;
                textBox_phonenumber.Text = car.PhoneNumber;
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void timer_DisplayNow_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_now.Text =
                "현재시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //내가 추가할 주차공간 번호를 적는다.
            int.TryParse(textBox_parkingspot_lookup.Text, out int parkingspot);
            if (parkingspot <= 0)
            {
                MessageBox.Show("주차공간번호는 0 이상의 숫자여야 합니다.");
                WriteLog("주차공간번호는 0 이상의 숫자여야 합니다."); 
                return; //함수 종료됨
            }

            DBHelper.selectQuery(parkingspot); //해당하는 주차공간을 찾는다.

            //해당공간이 없는거
            if(DBHelper.dt.Rows.Count < 1)
            {
                DBHelper.insertQuery(parkingspot);
                string contents = $"주차공간 {parkingspot}이/가 추가되었습니다.";
                WriteLog(contents);
                
                button_allLookup.PerformClick();
            }
            else
            {
                string contents = "해당 주차 공간 이미 존재";
                MessageBox.Show(contents);
                WriteLog(contents);
            }
        }

        private void button_allLookup_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            try
            {
                int parkingspot = int.Parse(textBox_parkingspot_lookup.Text);
                string ParkedCar = lookUpParkingSpot(parkingspot); //해당공간에 주차된 차 찾는 함수
                if(ParkedCar != "")
                {
                    string contents = $"주차공간 {parkingspot}에 주차되어 있는 차는 {ParkedCar}입니다.";
                    WriteLog(contents);
                }
                else
                {
                    string contents = $"주차공간 {parkingspot}에 주차되어 있는 차는 없습니다.";
                    WriteLog(contents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private string lookUpParkingSpot(int parkingspot)
        {
            try
            {
                //공간번호를 받는 방법 2가지
                //Single 메소드
                //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot == parkingspot);
                //return car.CarNumber;

                //foreach문
                string parkedCarNum = "";
                foreach (var item in DataManager.Cars)
                {
                    if (item.ParkingSpot == parkingspot)
                        parkedCarNum = item.CarNumber;
                }
                return parkedCarNum;
            }
            catch (Exception ex)
            {
                return "";
                //throw;// new Exception("차 없음");
            }
            //throw new NotImplementedException();
        }

        private void button_parkingremove_Click(object sender, EventArgs e)
        {
            if (textBox_parkingspot.Text.Trim() == "")
                MessageBox.Show("주차공간을 입력하세요.");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingspot.Text);
                    if (car.CarNumber.Trim() == "")
                    {
                        MessageBox.Show("해당 공간에 아직 차가 없습니다.");
                    }
                    else
                    {
                        string oldCar = car.CarNumber; //기존에 있는 차
                        car.CarNumber = "";
                        car.DriverName = "";
                        car.PhoneNumber = "";
                        car.ParkingTime = new DateTime();

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;
 
                        DataManager.save(textBox_parkingspot.Text, "", "", "",true);

                        string contents = $"주차공간 {textBox_parkingspot.Text}에서 {oldCar}차가 출차했습니다.";

                        WriteLog(contents);

                    }
                }
                catch (Exception ex)
                {
                    string contents = $"주차공간 {textBox_parkingspot.Text}은(는)없습니다.";
                    MessageBox.Show(contents);

                }
            }
        }
    }
}