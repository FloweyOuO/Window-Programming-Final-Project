namespace wp_final_template_v1
{
    partial class UserControlDays
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbevent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbdays.Location = new System.Drawing.Point(3, 5);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(46, 32);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbevent
            // 
            this.rtbevent.BackColor = System.Drawing.Color.White;
            this.rtbevent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbevent.Location = new System.Drawing.Point(5, 57);
            this.rtbevent.Name = "rtbevent";
            this.rtbevent.ReadOnly = true;
            this.rtbevent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbevent.Size = new System.Drawing.Size(215, 96);
            this.rtbevent.TabIndex = 3;
            this.rtbevent.Text = "";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtbevent);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(227, 156);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbevent;
    }
}
