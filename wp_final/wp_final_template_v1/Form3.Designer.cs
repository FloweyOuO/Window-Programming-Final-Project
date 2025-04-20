namespace wp_final_template_v1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coloredBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RtrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GtrackBar = new System.Windows.Forms.TrackBar();
            this.BtrackBar = new System.Windows.Forms.TrackBar();
            this.Rlabel = new System.Windows.Forms.Label();
            this.Glabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.hexcodeLabel = new System.Windows.Forms.Label();
            this.hexcodeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coloredBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // coloredBox
            // 
            this.coloredBox.Location = new System.Drawing.Point(272, 33);
            this.coloredBox.Name = "coloredBox";
            this.coloredBox.Size = new System.Drawing.Size(308, 164);
            this.coloredBox.TabIndex = 0;
            this.coloredBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "當前顏色:";
            // 
            // RtrackBar
            // 
            this.RtrackBar.Location = new System.Drawing.Point(175, 226);
            this.RtrackBar.Name = "RtrackBar";
            this.RtrackBar.Size = new System.Drawing.Size(394, 56);
            this.RtrackBar.TabIndex = 2;
            this.RtrackBar.ValueChanged += new System.EventHandler(this.RtrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // GtrackBar
            // 
            this.GtrackBar.Location = new System.Drawing.Point(175, 277);
            this.GtrackBar.Name = "GtrackBar";
            this.GtrackBar.Size = new System.Drawing.Size(394, 56);
            this.GtrackBar.TabIndex = 6;
            this.GtrackBar.ValueChanged += new System.EventHandler(this.GtrackBar_ValueChanged);
            // 
            // BtrackBar
            // 
            this.BtrackBar.Location = new System.Drawing.Point(175, 330);
            this.BtrackBar.Name = "BtrackBar";
            this.BtrackBar.Size = new System.Drawing.Size(394, 56);
            this.BtrackBar.TabIndex = 7;
            this.BtrackBar.ValueChanged += new System.EventHandler(this.BtrackBar_ValueChanged);
            // 
            // Rlabel
            // 
            this.Rlabel.AutoSize = true;
            this.Rlabel.Location = new System.Drawing.Point(110, 241);
            this.Rlabel.Name = "Rlabel";
            this.Rlabel.Size = new System.Drawing.Size(14, 15);
            this.Rlabel.TabIndex = 8;
            this.Rlabel.Text = "0";
            // 
            // Glabel
            // 
            this.Glabel.AutoSize = true;
            this.Glabel.Location = new System.Drawing.Point(110, 291);
            this.Glabel.Name = "Glabel";
            this.Glabel.Size = new System.Drawing.Size(14, 15);
            this.Glabel.TabIndex = 9;
            this.Glabel.Text = "0";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Location = new System.Drawing.Point(110, 343);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(14, 15);
            this.Blabel.TabIndex = 10;
            this.Blabel.Text = "0";
            // 
            // hexcodeLabel
            // 
            this.hexcodeLabel.AutoSize = true;
            this.hexcodeLabel.Location = new System.Drawing.Point(77, 388);
            this.hexcodeLabel.Name = "hexcodeLabel";
            this.hexcodeLabel.Size = new System.Drawing.Size(59, 15);
            this.hexcodeLabel.TabIndex = 11;
            this.hexcodeLabel.Text = "HexCode";
            // 
            // hexcodeBox
            // 
            this.hexcodeBox.Location = new System.Drawing.Point(175, 385);
            this.hexcodeBox.Name = "hexcodeBox";
            this.hexcodeBox.Size = new System.Drawing.Size(394, 25);
            this.hexcodeBox.TabIndex = 12;
            this.hexcodeBox.Text = "#";
            this.hexcodeBox.TextChanged += new System.EventHandler(this.hexcodeBox_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hexcodeBox);
            this.Controls.Add(this.hexcodeLabel);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Glabel);
            this.Controls.Add(this.Rlabel);
            this.Controls.Add(this.BtrackBar);
            this.Controls.Add(this.GtrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coloredBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coloredBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coloredBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TrackBar BtrackBar;
        private System.Windows.Forms.Label Rlabel;
        private System.Windows.Forms.Label Glabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Label hexcodeLabel;
        private System.Windows.Forms.TextBox hexcodeBox;
    }
}