using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wp_final_template_v1
{
    public partial class Calendar : Form
    {
        int month, year;
        //let's create a static variable that we can pass to another form for month and year
        public static int static_month, static_year;
        public Calendar(Form1 form1)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;

            static_month = month;
            static_year = year;

            //獲取這個月的第一天
            DateTime startofthemonth = new DateTime(year, month, 1);

            //獲取這個月有幾天
            int days = DateTime.DaysInMonth(year, month);

            //把startofthemonth轉成整數
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //首先創造一個空白的使用者控制項
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //再創造使用者控制項給days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //清空container
            daycontainer.Controls.Clear();

            //月份-1觀看上個月的行事曆
            month--;
            if (month < 1)
            {
                month = 12; // 前一年 12 月
                year--;     // 調整年份
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            //獲取這個月有幾天
            int days = DateTime.DaysInMonth(year, month);

            //把startofthemonth轉成整數
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //首先創造一個空白的使用者控制項
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //再創造使用者控制項給days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //清空container
            daycontainer.Controls.Clear();

            //月份+1觀看下個月的行事曆
            month++;
            if (month > 12)
            {
                month = 1; // 下一年 1 月
                year++;    // 調整年份
            }
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            //獲取這個月有幾天
            int days = DateTime.DaysInMonth(year, month);

            //把startofthemonth轉成整數
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //首先創造一個空白的使用者控制項
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //再創造使用者控制項給days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
