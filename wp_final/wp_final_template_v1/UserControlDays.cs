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
using System.Data.SqlClient;  // 引用 MySQL 資料庫連接

namespace wp_final_template_v1
{
    public partial class UserControlDays : UserControl
    {

        //日期成為靜態變數
        public static string static_day;

        // 資料庫連線字串（與 EventForm 相同的設定）
        String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Calendar_Database.mdf;" +
                            "Integrated Security=True";

        private string lastEventContent = string.Empty;

        public UserControlDays()
        {
            InitializeComponent();
        }


        private void UserControlDays_Load(object sender, EventArgs e)
        {
            // 初始化事件顯示
            displayEvent();
        }
        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            //start timer if usercontroldays is click
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        //在行事曆展示加入的活動
        private void displayEvent()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // 查詢指定日期的活動
                    string sql = "SELECT 活動, 顏色 FROM 活動 WHERE 日期 = @日期";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // 使用參數化查詢，避免 SQL Injection
                        cmd.Parameters.AddWithValue("@日期", $"{Calendar.static_year}-{Calendar.static_month}-{lbdays.Text}");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 暫存新的活動內容
                            StringBuilder newContent = new StringBuilder();
                            List<(string Event, string Color)> eventList = new List<(string, string)>();

                            while (reader.Read())
                            {
                                string eventContent = reader["活動"].ToString();
                                string colorName = reader["顏色"].ToString();
                                if (!string.IsNullOrWhiteSpace(eventContent))
                                {
                                    newContent.AppendLine(eventContent);
                                    eventList.Add((eventContent, colorName));
                                }
                            }
                            // 比較新舊內容是否不同
                            string newContentString = newContent.ToString().Trim();
                            if (newContentString != lastEventContent)
                            {
                                // 如果有變更，更新內容並記錄
                                lastEventContent = newContentString;
                                rtbevent.Clear();

                                // 更新 RichTextBox
                                foreach (var (eventcontent, colorname) in eventList)
                                {
                                    rtbevent.SelectionStart = rtbevent.TextLength;
                                    rtbevent.SelectionLength = 0;

                                    // 設定顏色
                                    try
                                    {
                                        rtbevent.SelectionColor = Color.FromName(colorname);
                                    }
                                    catch
                                    {
                                        rtbevent.SelectionColor = Color.Black; // 預設顏色
                                    }
                                    rtbevent.AppendText(eventcontent + Environment.NewLine); 
                                }               
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //create a timer for auto display event if new event is added
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}


