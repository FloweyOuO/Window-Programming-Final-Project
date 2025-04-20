using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wp_final_template_v1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Color changedColor;
        private void Form3_Load(object sender, EventArgs e)
        {
            RtrackBar.Maximum = 255; 
            GtrackBar.Maximum = 255;
            BtrackBar.Maximum = 255;

        }

        private void RtrackBar_ValueChanged(object sender, EventArgs e)
        {
            Rlabel.Text = RtrackBar.Value.ToString();
            changedColor = Color.FromArgb(RtrackBar.Value,GtrackBar.Value,BtrackBar.Value);
            coloredBox.BackColor = changedColor;
            hexcodeBox.Text = RgbToHex();
        }

        private void GtrackBar_ValueChanged(object sender, EventArgs e)
        {
            Glabel.Text = GtrackBar.Value.ToString();
            changedColor = Color.FromArgb(RtrackBar.Value, GtrackBar.Value, BtrackBar.Value);
            coloredBox.BackColor = changedColor;
            hexcodeBox.Text = RgbToHex();

        }

        private void BtrackBar_ValueChanged(object sender, EventArgs e)
        {
            Blabel.Text = BtrackBar.Value.ToString();
            changedColor = Color.FromArgb(RtrackBar.Value, GtrackBar.Value, BtrackBar.Value);
            coloredBox.BackColor = changedColor;
            hexcodeBox.Text = RgbToHex();

        }
        private string RgbToHex()
        {
            int RValue, GValue, BValue;
            string hexCode;
            RValue = changedColor.R; 
            GValue = changedColor.G;
            BValue = changedColor.B;
            string tempR = "", tempG = "", tempB = "";
            string result1 = string.Empty;
            string result2 = string.Empty;
            string result3 = string.Empty;


            const string digits = "0123456789ABCDEF";
            if (RValue < 16) tempR += '0';
            if (GValue < 16) tempG += '0';
            if (BValue < 16) tempB += '0';
            do
            {
                int remainder = RValue % 16;
                result1 = digits[remainder] + result1;
                RValue /= 16;
            } while (RValue > 0);
            
            tempR += result1;
            do
            {
                int remainder = GValue % 16;
                result2 = digits[remainder] + result2;
                GValue /= 16;
            } while (GValue > 0);
            tempG += result2;
            do
            {
                int remainder = BValue % 16;
                result3 = digits[remainder] + result3;
                BValue /= 16;
            } while (BValue > 0);
            tempB += result3;
            hexCode = "#" + tempR + tempG + tempB;
            return hexCode;
        }

        private void hexcodeBox_TextChanged(object sender, EventArgs e)
        {
            
            char[] hexindex = hexcodeBox.Text.ToCharArray();
            if (hexindex[0] != '#')
            {
                MessageBox.Show("請先輸入#再輸入hexCode", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hexcodeBox.Text = "#";
            }
            if (hexindex.Length < 7) return;
            if (hexindex.Length > 7)
            {
                MessageBox.Show("字符過長", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hexcodeBox.Text = "#";
                return;
            }
            int RValue, GValue, BValue;
            RValue = letterConverter(hexindex[1]) * 16 + letterConverter(hexindex[2]);
            GValue = letterConverter(hexindex[3]) * 16 + letterConverter(hexindex[4]);
            BValue = letterConverter(hexindex[5]) * 16 + letterConverter(hexindex[6]);
            changedColor = Color.FromArgb(RValue, GValue, BValue);
            RtrackBar.Value = RValue;
            Rlabel.Text = RValue.ToString();
            GtrackBar.Value = GValue;
            Glabel.Text = GValue.ToString();
            BtrackBar.Value = BValue;
            Glabel.Text = BValue.ToString();
        }
        private int letterConverter(char ch)
        {
            ch = char.ToUpper(ch);
            try
            {
                int num = int.Parse(ch.ToString());
                if (num >= 16)
                {
                    MessageBox.Show("the digit " + num.ToString() + " is invalid for base " + 16);
                    throw new FormatException();
                }
                return num;
            }
            catch (FormatException)
            {
                int num = ch - 'A' + 10;
                if (num >= 16)
                {
                    MessageBox.Show("the letter " + ch + " is invalid for base " + 16);
                    throw new FormatException();
                }
                return num;
            }
        }
    }
}
