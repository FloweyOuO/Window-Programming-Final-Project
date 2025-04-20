namespace wp_final_template_v1
{
    partial class Form2
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
            System.Windows.Forms.Label label1;
            this.base1Box = new System.Windows.Forms.TextBox();
            this.base2Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.digitBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // base1Box
            // 
            this.base1Box.Location = new System.Drawing.Point(145, 58);
            this.base1Box.Name = "base1Box";
            this.base1Box.Size = new System.Drawing.Size(100, 25);
            this.base1Box.TabIndex = 0;
            // 
            // base2Box
            // 
            this.base2Box.Location = new System.Drawing.Point(455, 58);
            this.base2Box.Name = "base2Box";
            this.base2Box.Size = new System.Drawing.Size(100, 25);
            this.base2Box.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(84, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 15);
            label1.TabIndex = 2;
            label1.Text = "由";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "進制轉換為";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "進制";
            // 
            // digitBox
            // 
            this.digitBox.Location = new System.Drawing.Point(227, 185);
            this.digitBox.Name = "digitBox";
            this.digitBox.Size = new System.Drawing.Size(328, 25);
            this.digitBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "輸入值:";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(227, 250);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(328, 25);
            this.resultBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "輸出值:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(599, 185);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(153, 90);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(362, 367);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "返回";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.digitBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.base2Box);
            this.Controls.Add(this.base1Box);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox base1Box;
        private System.Windows.Forms.TextBox base2Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox digitBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button menuButton;
    }
}