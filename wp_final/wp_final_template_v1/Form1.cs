using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wp_final_template_v1
{
    public partial class Form1 : Form
    {
        private Point labelPoint;
        public PictureBox icon;
        public SoundPlayer sound1, sound2;
        public CheckBox soundTrigger = new CheckBox();
        public int background = 0;
        Image mainIcon = new Bitmap("..\\..\\Images\\toolbox.png");
        Image mainBack = new Bitmap("..\\..\\Images\\main.jpg");
        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = mainBack;
            pictureBox2.Image = mainIcon;

            sound1 = new SoundPlayer();
            sound2 = new SoundPlayer();
            icon = new PictureBox();
            labelPoint = descriptionLabel.Location;
            icon.Image = null;
            icon.Location = new Point(0, 0);
            icon.Size = new Size(20, 15);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;

            soundTrigger.Text = "sound ON";
            soundTrigger.Size = new Size(100, 50);
            soundTrigger.Location = new Point(250, 125);
            soundTrigger.Checked = true;
            soundTrigger.Visible = false;

            this.Controls.Add(icon);
            this.Text = "個人化工具";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (soundTrigger.Checked && background == 1) sound2.Play();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            if (soundTrigger.Checked && background == 1) sound2.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            if (soundTrigger.Checked && background == 1) sound2.Play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;

            menuButton.Visible = true;
            button1.Visible = false;
            convertionButton.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            if (soundTrigger.Checked && background == 1) sound2.Play();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            descriptionLabel.Visible = false;
            menuButton.Visible = true;
            button1.Visible = false;
            convertionButton.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            checkBox1.Size = new Size(100, 50);
            checkBox1.Text = "default";
            checkBox2.Size = new Size(100, 50);
            checkBox2.Text = "undertale";
            checkBox1.Location = new Point(250, 125);
            checkBox2.Location = new Point(250, 175);
            checkBox1.CheckedChanged += checkBox_checkChanged;
            checkBox2.CheckedChanged += checkBox_checkChanged;

            this.Controls.Add(checkBox1);
            this.Controls.Add(checkBox2);

            checkBox1.BringToFront();
            checkBox2.BringToFront();

            if (background == 1)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = Color.DarkBlue;
                        button.ForeColor = Color.Cyan;
                    }
                    if (control is Label label)
                    {
                        label.BackColor = Color.DarkBlue;
                        label.ForeColor = Color.Cyan;
                    }
                    if (control is CheckBox check)
                    {
                        check.BackColor = Color.DarkBlue;
                        check.ForeColor = Color.Cyan;
                    }
                }
            }
            if (soundTrigger.Checked && background == 1) sound2.Play();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (soundTrigger.Checked && background == 1) sound2.Play();
            Calendar calendar = new Calendar(this);
            calendar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            descriptionLabel.Visible = false;

            menuButton.Visible = true;
            button1.Visible = false;
            convertionButton.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            if (soundTrigger.Checked && background == 1) sound2.Play();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            descriptionLabel.Visible = false;
            pictureBox2.Visible = false;
            menuButton.Visible = true;
            button1.Visible = false;
            convertionButton.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            soundTrigger.Visible = true;
            this.Controls.Add(soundTrigger);
            if (background == 1)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = Color.DarkBlue;
                        button.ForeColor = Color.Cyan;
                    }
                    if (control is Label label)
                    {
                        label.BackColor = Color.DarkBlue;
                        label.ForeColor = Color.Cyan;
                    }
                    if (control is CheckBox check)
                    {
                        check.BackColor = Color.DarkBlue;
                        check.ForeColor = Color.Cyan;
                    }
                }
            }
            else if (background == 0)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = Color.White;
                        button.ForeColor = Color.Black;
                    }
                    if (control is Label label)
                    {
                        label.BackColor = Color.White;
                        label.ForeColor = Color.Black;
                    }
                    if (control is CheckBox check)
                    {
                        check.BackColor = Color.White;
                        check.ForeColor = Color.Black;
                    }
                }
            }
            if (soundTrigger.Checked && background == 1) sound2.Play();

            //if (!soundTrigger.Checked)
            //{
            //    sound1.SoundLocation = null;
            //    sound2.SoundLocation = null;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuButton.Visible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            menuButton.Visible = false;
            button1.Visible = true;
            convertionButton.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            descriptionLabel.Visible = true;
            soundTrigger.Visible = false;
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is CheckBox)
                {
                    this.Controls.RemoveAt(i);
                }
            }
            if (background == 1)
            {
                sound1.SoundLocation = @"..\..\Sounds\undertale-move-selection-sound-effect.wav";
                sound2.SoundLocation = @"..\..\Sounds\undertale-select-sound.wav";
            }
            if (soundTrigger.Checked && background == 1) sound2.Play();


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            icon.Location = new Point(button1.Location.X - 20, button1.Location.Y + 10);
            descriptionLabel.Text = "提供各種記帳功能";
            if (soundTrigger.Checked && background == 1) sound1.Play();

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            descriptionLabel.Text = "提供由2至16的進制轉換";
            icon.Location = new Point(convertionButton.Location.X - 20, convertionButton.Location.Y + 10);
            if (soundTrigger.Checked && background == 1) sound1.Play();

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            descriptionLabel.Text = "由HexCode查詢色碼，或拖動拉桿查詢顏色";
            icon.Location = new Point(button3.Location.X - 20, button3.Location.Y + 10);
            if (soundTrigger.Checked && background == 1) sound1.Play();

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            descriptionLabel.Text = "轉換背景";
            icon.Location = new Point(button5.Location.X - 20, button5.Location.Y + 10);
            if (soundTrigger.Checked && background == 1) sound1.Play();

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            descriptionLabel.Text = "提供基本的行事曆工具";
            icon.Location = new Point(button6.Location.X - 20, button6.Location.Y + 10);
            if (soundTrigger.Checked && background == 1) sound1.Play();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            descriptionLabel.Text = "離開應用程式";
            icon.Location = new Point(button7.Location.X - 20, button7.Location.Y + 10);
            if (soundTrigger.Checked && background == 1) sound1.Play();

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            descriptionLabel.Text = "調整音效設定";
            icon.Location = new Point(button8.Location.X - 20, button8.Location.Y + 10);
            if (soundTrigger.Checked && background == 1) sound1.Play();

        }
        private void centerLabel(Label label)
        {
            int centerX = (this.ClientSize.Width - descriptionLabel.Width) / 2;
            int centerY = (this.ClientSize.Height - descriptionLabel.Height) / 2 - 18;
            label.Location = new Point(centerX, centerY);
        }
        private void descriptionLabel_TextChanged(object sender, EventArgs e)
        {
            //descriptionLabel.PerformLayout();
            //centerLabel(descriptionLabel);
            this.BeginInvoke(new Action(() => centerLabel(descriptionLabel)));
        }

        private void menuButton_MouseHover(object sender, EventArgs e)
        {
            if (soundTrigger.Checked && background == 1) sound1.Play();
            icon.Location = new Point(menuButton.Location.X - 20, menuButton.Location.Y + 10);

        }

        private void checkBox_checkChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Text == "default")
                {
                    this.BackgroundImage = null;
                    background = 0;
                    icon.Image = null;
                    icon.BackColor = Color.White;
                    sound1.Stop();
                    sound2.Stop();
                    foreach (Control control in this.Controls)
                    {
                        if (control is Button button)
                        {
                            button.BackColor = Color.White;
                            button.ForeColor = Color.Black;
                        }
                        if (control is Label label)
                        {
                            label.BackColor = Color.White;
                            label.ForeColor = Color.Black;
                        }
                        if (control is CheckBox check)
                        {
                            check.BackColor = Color.White;
                            check.ForeColor = Color.Black;
                        }
                    }
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                }
                else if (checkBox.Text == "undertale")
                {
                    this.BackgroundImage = Image.FromFile(@"..\..\Images\back1.jpg");
                    background = 1;
                    icon.Image = Image.FromFile(@"..\..\Images\heart.png");
                    icon.BackColor = Color.Black;
                    if (soundTrigger.Checked)
                    {
                        sound1.SoundLocation = @"..\..\Sounds\undertale-move-selection-sound-effect.wav";
                        sound2.SoundLocation = @"..\..\Sounds\undertale-select-sound.wav";
                    }
                    foreach (Control control in this.Controls)
                    {
                        if (control is Button button)
                        {
                            button.BackColor = Color.DarkBlue;
                            button.ForeColor = Color.Cyan;
                        }
                        if (control is Label label)
                        {
                            label.BackColor = Color.DarkBlue;
                            label.ForeColor = Color.Cyan;
                        }
                        if (control is CheckBox check)
                        {
                            check.BackColor = Color.DarkBlue;
                            check.ForeColor = Color.Cyan;
                        }
                    }
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                }

            }
        }
    }
}
