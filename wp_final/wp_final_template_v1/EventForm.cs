using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Xml.Linq;

namespace wp_final_template_v1
{
    public partial class EventForm : Form
    {
        //create a connectionstring
        String connString = "server = localhost;user id = root;database = db_calender;sslmode = none";

        string selectedColor;


        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'calendar_DatabaseDataSet1.活動' 資料表。
            this.活動TableAdapter1.Fill(this.calendar_DatabaseDataSet1.活動);

            //let's call the static variables we declare
            txdate.Text = Calendar.static_year + "-" + Calendar.static_month + "-" + UserControlDays.static_day;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // 檢查活動輸入欄位是否為空
            if (string.IsNullOrWhiteSpace(txevent.Text))
            {
                MessageBox.Show("請輸入活動名稱！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // 終止儲存動作
            }


            // 建立與資料庫的連線
            using (SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Calendar_Database.mdf;" +
                    "Integrated Security=True"))
            {
                try
                {
                    db.Open();

                    // 使用參數化查詢
                    string sql = "INSERT INTO [活動] ([活動], [日期], [顏色]) VALUES (@活動, @日期, @顏色)";

                    using (SqlCommand cmd = new SqlCommand(sql, db))
                    {
                        // 將參數化查詢中的值進行綁定
                        cmd.Parameters.AddWithValue("@活動", txevent.Text.Trim());
                        cmd.Parameters.AddWithValue("@日期", DateTime.Parse(txdate.Text));
                        cmd.Parameters.AddWithValue("@顏色", selectedColor ?? (object)DBNull.Value);

                        // 執行 SQL 語句
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // 提示儲存成功
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("活動已成功儲存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("未能儲存活動，請檢查輸入資料。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 錯誤處理
                    MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 檢查活動輸入欄位是否為空
            if (string.IsNullOrWhiteSpace(txevent.Text))
            {
                MessageBox.Show("請輸入活動名稱！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // 終止刪除動作
            }

            // 建立與資料庫的連線
            using (SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Calendar_Database.mdf;" +
                    "Integrated Security=True"))
            {
                try
                {
                    db.Open();

                    // 使用參數化查詢
                    string sql = "DELETE FROM [活動] WHERE [活動] = @活動 AND [日期] = @日期";

                    using (SqlCommand cmd = new SqlCommand(sql, db))
                    {
                        // 將參數化查詢中的值進行綁定
                        cmd.Parameters.AddWithValue("@活動", txevent.Text.Trim());
                        cmd.Parameters.AddWithValue("@日期", DateTime.Parse(txdate.Text));

                        // 執行 SQL 語句，返回受影響的行數
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // 提示刪除成功
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("活動已成功刪除！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("未能找到符合條件的活動，請檢查輸入的資料！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 錯誤處理
                    MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnlabel_Click(object sender, EventArgs e)
        {
            using (LabelForm labelForm = new LabelForm())
            {
                if (labelForm.ShowDialog() == DialogResult.OK) // 確保返回後執行
                {
                    selectedColor = labelForm.ColorSelection;
                    btnlabel.Text = labelForm.LabelSelection;
                    btnlabel.ForeColor = Color.FromName(selectedColor);
                }
            }
        }
    }
}
