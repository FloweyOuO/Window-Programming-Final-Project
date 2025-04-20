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
    public partial class LabelForm : Form
    {

        public string ColorSelection;
        public string LabelSelection;

        public LabelForm()
        {
            InitializeComponent();
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            ColorSelection = "Red";
            LabelSelection = txred.Text;
            Properties.Settings.Default.RedText = txred.Text; //儲存文字
            Properties.Settings.Default.Save(); //儲存設定
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnorange_Click(object sender, EventArgs e)
        {
            ColorSelection = "Orange";
            LabelSelection = txorange.Text;
            Properties.Settings.Default.OrangeText = txorange.Text;
            Properties.Settings.Default.Save(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnyellow_Click(object sender, EventArgs e)
        {
            ColorSelection = "Yellow";
            LabelSelection = txyellow.Text;
            Properties.Settings.Default.YellowText = txyellow.Text; 
            Properties.Settings.Default.Save(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btngreen_Click(object sender, EventArgs e)
        {
            ColorSelection = "Green";
            LabelSelection = txgreen.Text;
            Properties.Settings.Default.GreenText = txgreen.Text; 
            Properties.Settings.Default.Save(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            ColorSelection = "Blue";
            LabelSelection = txblue.Text;
            Properties.Settings.Default.BlueText = txblue.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnpurple_Click(object sender, EventArgs e)
        {
            ColorSelection = "Purple";
            LabelSelection = txpurple.Text;
            Properties.Settings.Default.PurpleText = txpurple.Text; 
            Properties.Settings.Default.Save(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnpink_Click(object sender, EventArgs e)
        {
            ColorSelection = "Pink";
            LabelSelection = txpink.Text;
            Properties.Settings.Default.PinkText = txpink.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelForm_Load(object sender, EventArgs e)
        {
            // 設置 TextBox 預設值為已儲存的設定
            txred.Text = Properties.Settings.Default.RedText;
            txorange.Text = Properties.Settings.Default.OrangeText;
            txyellow.Text = Properties.Settings.Default.YellowText;
            txgreen.Text = Properties.Settings.Default.GreenText;
            txblue.Text = Properties.Settings.Default.BlueText;
            txpurple.Text = Properties.Settings.Default.PurpleText;
            txpink.Text = Properties.Settings.Default.PinkText;
        }
    }
}
