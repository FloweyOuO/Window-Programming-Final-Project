using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wp_final_template_v1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int base1 = int.Parse(base1Box.Text);
                int base2 = int.Parse(base2Box.Text);
                long inputValue1 = 0;
                char[] inputIndex = digitBox.Text.ToCharArray();
                for (int i = 0; i < digitBox.TextLength; i++)
                {
                    inputValue1 += letterConverter(inputIndex[i], base1) * (long)Math.Pow(base1, digitBox.TextLength - i - 1);
                    if (inputValue1 > int.MaxValue)
                    {
                        throw new OverflowException("input value exceeds the maximum allowed value");
                    }
                }
                string result = ConvertToBaseN((int)inputValue1, base2);
                resultBox.Text = result;
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入適當的數值", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultBox.Text = string.Empty;
            }
            catch (OverflowException)
            {
                MessageBox.Show("數值過大，無法處理", "溢出錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultBox.Text = string.Empty;
            }
        }
        private string ConvertToBaseN(int value, int base2)
        {
            if (base2 < 2 || base2 > 16) MessageBox.Show("base應在2到16之間","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            string result = string.Empty;
            const string digits = "0123456789ABCDEF";
            do
            {
                int remainder = value % base2;
                result = digits[remainder] + result;
                value /= base2;
            } while (value > 0);
            return result;
        }
        private int letterConverter(char ch, int base1)
        {
            ch = char.ToUpper(ch);
            try
            {
                int num = int.Parse(ch.ToString());
                if (num >= base1) {
                    MessageBox.Show("the digit " + num.ToString() + " is invalid for base " + base1);
                    throw new FormatException(); 
                }
                return num;
            }
            catch (FormatException)
            {
                int num = ch - 'A' + 10;
                if (num >= base1 || base1 < 10) {
                    MessageBox.Show("the letter " + ch + " is invalid for base " + base1);
                    throw new FormatException();
                }
                return num;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
