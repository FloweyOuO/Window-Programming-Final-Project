namespace wp_final_template_v1
{
    partial class EventForm
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
            this.components = new System.ComponentModel.Container();
            this.txdate = new System.Windows.Forms.TextBox();
            this.txevent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活動DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活動BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendar_DatabaseDataSet = new wp_final_template_v1.Calendar_DatabaseDataSet();
            this.活動TableAdapter = new wp_final_template_v1.Calendar_DatabaseDataSetTableAdapters.活動TableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlabel = new System.Windows.Forms.Button();
            this.calendar_DatabaseDataSet1 = new wp_final_template_v1.Calendar_DatabaseDataSet1();
            this.活動BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.活動TableAdapter1 = new wp_final_template_v1.Calendar_DatabaseDataSet1TableAdapters.活動TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.活動BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.活動BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txdate.Location = new System.Drawing.Point(66, 160);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(587, 46);
            this.txdate.TabIndex = 0;
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txevent.Location = new System.Drawing.Point(66, 59);
            this.txevent.Name = "txevent";
            this.txevent.Size = new System.Drawing.Size(587, 46);
            this.txevent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "活動";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("標楷體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(704, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.活動DataGridViewTextBoxColumn,
            this.日期DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.活動BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(66, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.Size = new System.Drawing.Size(776, 355);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // 活動DataGridViewTextBoxColumn
            // 
            this.活動DataGridViewTextBoxColumn.DataPropertyName = "活動";
            this.活動DataGridViewTextBoxColumn.HeaderText = "活動";
            this.活動DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.活動DataGridViewTextBoxColumn.Name = "活動DataGridViewTextBoxColumn";
            this.活動DataGridViewTextBoxColumn.Width = 200;
            // 
            // 日期DataGridViewTextBoxColumn
            // 
            this.日期DataGridViewTextBoxColumn.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn";
            this.日期DataGridViewTextBoxColumn.Width = 200;
            // 
            // 活動BindingSource
            // 
            this.活動BindingSource.DataMember = "活動";
            this.活動BindingSource.DataSource = this.calendar_DatabaseDataSet;
            // 
            // calendar_DatabaseDataSet
            // 
            this.calendar_DatabaseDataSet.DataSetName = "Calendar_DatabaseDataSet";
            this.calendar_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 活動TableAdapter
            // 
            this.活動TableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("標楷體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(704, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 54);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(61, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "標籤";
            // 
            // btnlabel
            // 
            this.btnlabel.Font = new System.Drawing.Font("標楷體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnlabel.Location = new System.Drawing.Point(66, 270);
            this.btnlabel.Name = "btnlabel";
            this.btnlabel.Size = new System.Drawing.Size(138, 56);
            this.btnlabel.TabIndex = 8;
            this.btnlabel.Text = "(無)";
            this.btnlabel.UseVisualStyleBackColor = true;
            this.btnlabel.Click += new System.EventHandler(this.btnlabel_Click);
            // 
            // calendar_DatabaseDataSet1
            // 
            this.calendar_DatabaseDataSet1.DataSetName = "Calendar_DatabaseDataSet1";
            this.calendar_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 活動BindingSource1
            // 
            this.活動BindingSource1.DataMember = "活動";
            this.活動BindingSource1.DataSource = this.calendar_DatabaseDataSet1;
            // 
            // 活動TableAdapter1
            // 
            this.活動TableAdapter1.ClearBeforeFill = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 724);
            this.Controls.Add(this.btnlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.txdate);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.活動BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.活動BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Calendar_DatabaseDataSet calendar_DatabaseDataSet;
        private System.Windows.Forms.BindingSource 活動BindingSource;
        private Calendar_DatabaseDataSetTableAdapters.活動TableAdapter 活動TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 活動DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlabel;
        private Calendar_DatabaseDataSet1 calendar_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource 活動BindingSource1;
        private Calendar_DatabaseDataSet1TableAdapters.活動TableAdapter 活動TableAdapter1;
    }
}