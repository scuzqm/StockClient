namespace StockClient
{
    partial class Stock_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_userSelect = new System.Windows.Forms.GroupBox();
            this.comboBox_stock = new System.Windows.Forms.ComboBox();
            this.groupBox_baseInfo = new System.Windows.Forms.GroupBox();
            this.panel_KLine = new System.Windows.Forms.Panel();
            this.radioButton_month = new System.Windows.Forms.RadioButton();
            this.radioButton_week = new System.Windows.Forms.RadioButton();
            this.radioButton_day = new System.Windows.Forms.RadioButton();
            this.listBox_min = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_mainBuyers = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButton_fiveD = new System.Windows.Forms.RadioButton();
            this.radioButton_detail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar_now = new System.Windows.Forms.ProgressBar();
            this.progressBar_5day = new System.Windows.Forms.ProgressBar();
            this.progressBar_month = new System.Windows.Forms.ProgressBar();
            this.groupBox_userSelect.SuspendLayout();
            this.panel_KLine.SuspendLayout();
            this.panel_mainBuyers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_userSelect
            // 
            this.groupBox_userSelect.Controls.Add(this.comboBox_stock);
            this.groupBox_userSelect.Location = new System.Drawing.Point(12, 22);
            this.groupBox_userSelect.Name = "groupBox_userSelect";
            this.groupBox_userSelect.Size = new System.Drawing.Size(180, 118);
            this.groupBox_userSelect.TabIndex = 0;
            this.groupBox_userSelect.TabStop = false;
            this.groupBox_userSelect.Text = "自选股";
            // 
            // comboBox_stock
            // 
            this.comboBox_stock.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_stock.FormattingEnabled = true;
            this.comboBox_stock.Location = new System.Drawing.Point(18, 43);
            this.comboBox_stock.Name = "comboBox_stock";
            this.comboBox_stock.Size = new System.Drawing.Size(121, 20);
            this.comboBox_stock.TabIndex = 0;
            this.comboBox_stock.SelectedIndexChanged += new System.EventHandler(this.comboBox_stock_SelectedIndexChanged);
            // 
            // groupBox_baseInfo
            // 
            this.groupBox_baseInfo.Location = new System.Drawing.Point(13, 184);
            this.groupBox_baseInfo.Name = "groupBox_baseInfo";
            this.groupBox_baseInfo.Size = new System.Drawing.Size(179, 235);
            this.groupBox_baseInfo.TabIndex = 1;
            this.groupBox_baseInfo.TabStop = false;
            this.groupBox_baseInfo.Text = "自选股基本信息";
            // 
            // panel_KLine
            // 
            this.panel_KLine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_KLine.Controls.Add(this.radioButton_month);
            this.panel_KLine.Controls.Add(this.radioButton_week);
            this.panel_KLine.Controls.Add(this.radioButton_day);
            this.panel_KLine.Controls.Add(this.listBox_min);
            this.panel_KLine.Controls.Add(this.label1);
            this.panel_KLine.Location = new System.Drawing.Point(210, 32);
            this.panel_KLine.Name = "panel_KLine";
            this.panel_KLine.Size = new System.Drawing.Size(252, 223);
            this.panel_KLine.TabIndex = 2;
            // 
            // radioButton_month
            // 
            this.radioButton_month.AutoSize = true;
            this.radioButton_month.Location = new System.Drawing.Point(117, 197);
            this.radioButton_month.Name = "radioButton_month";
            this.radioButton_month.Size = new System.Drawing.Size(35, 16);
            this.radioButton_month.TabIndex = 5;
            this.radioButton_month.TabStop = true;
            this.radioButton_month.Text = "月";
            this.radioButton_month.UseVisualStyleBackColor = true;
            this.radioButton_month.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton_week
            // 
            this.radioButton_week.AutoSize = true;
            this.radioButton_week.Location = new System.Drawing.Point(59, 197);
            this.radioButton_week.Name = "radioButton_week";
            this.radioButton_week.Size = new System.Drawing.Size(35, 16);
            this.radioButton_week.TabIndex = 4;
            this.radioButton_week.TabStop = true;
            this.radioButton_week.Text = "周";
            this.radioButton_week.UseVisualStyleBackColor = true;
            this.radioButton_week.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton_day
            // 
            this.radioButton_day.AutoSize = true;
            this.radioButton_day.Location = new System.Drawing.Point(6, 197);
            this.radioButton_day.Name = "radioButton_day";
            this.radioButton_day.Size = new System.Drawing.Size(35, 16);
            this.radioButton_day.TabIndex = 3;
            this.radioButton_day.TabStop = true;
            this.radioButton_day.Text = "日";
            this.radioButton_day.UseVisualStyleBackColor = true;
            this.radioButton_day.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox_min
            // 
            this.listBox_min.FormattingEnabled = true;
            this.listBox_min.ItemHeight = 12;
            this.listBox_min.Items.AddRange(new object[] {
            "60分",
            "30分",
            "15分",
            "5分",
            "1分"});
            this.listBox_min.Location = new System.Drawing.Point(182, 197);
            this.listBox_min.Name = "listBox_min";
            this.listBox_min.Size = new System.Drawing.Size(44, 16);
            this.listBox_min.TabIndex = 2;
            this.listBox_min.SelectedIndexChanged += new System.EventHandler(this.listBox_min_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "K线图";
            // 
            // panel_mainBuyers
            // 
            this.panel_mainBuyers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_mainBuyers.Controls.Add(this.progressBar_month);
            this.panel_mainBuyers.Controls.Add(this.progressBar_5day);
            this.panel_mainBuyers.Controls.Add(this.progressBar_now);
            this.panel_mainBuyers.Controls.Add(this.label5);
            this.panel_mainBuyers.Controls.Add(this.label4);
            this.panel_mainBuyers.Controls.Add(this.label3);
            this.panel_mainBuyers.Controls.Add(this.label2);
            this.panel_mainBuyers.Location = new System.Drawing.Point(210, 274);
            this.panel_mainBuyers.Name = "panel_mainBuyers";
            this.panel_mainBuyers.Size = new System.Drawing.Size(252, 145);
            this.panel_mainBuyers.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(505, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(124, 346);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "卖5:\n\n卖4:\n\n卖3:\n\n卖2:\n\n卖1:\n\n\n买1:\n\n买2:\n\n买3:\n\n买4:\n\n买5:";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButton_fiveD
            // 
            this.radioButton_fiveD.AutoSize = true;
            this.radioButton_fiveD.Location = new System.Drawing.Point(505, 36);
            this.radioButton_fiveD.Name = "radioButton_fiveD";
            this.radioButton_fiveD.Size = new System.Drawing.Size(47, 16);
            this.radioButton_fiveD.TabIndex = 5;
            this.radioButton_fiveD.TabStop = true;
            this.radioButton_fiveD.Text = "五档";
            this.radioButton_fiveD.UseVisualStyleBackColor = true;
            this.radioButton_fiveD.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton_detail
            // 
            this.radioButton_detail.AutoSize = true;
            this.radioButton_detail.Location = new System.Drawing.Point(585, 36);
            this.radioButton_detail.Name = "radioButton_detail";
            this.radioButton_detail.Size = new System.Drawing.Size(47, 16);
            this.radioButton_detail.TabIndex = 6;
            this.radioButton_detail.TabStop = true;
            this.radioButton_detail.Text = "明细";
            this.radioButton_detail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "主力流入状况";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前主力流入";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "5日主力流入";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "30日主力流入";
            // 
            // progressBar_now
            // 
            this.progressBar_now.Location = new System.Drawing.Point(28, 28);
            this.progressBar_now.Name = "progressBar_now";
            this.progressBar_now.Size = new System.Drawing.Size(18, 87);
            this.progressBar_now.TabIndex = 5;
            this.progressBar_now.Click += new System.EventHandler(this.progressBar_now_Click);
            // 
            // progressBar_5day
            // 
            this.progressBar_5day.Location = new System.Drawing.Point(117, 29);
            this.progressBar_5day.Name = "progressBar_5day";
            this.progressBar_5day.Size = new System.Drawing.Size(18, 87);
            this.progressBar_5day.TabIndex = 6;
            this.progressBar_5day.Click += new System.EventHandler(this.progressBar_5day_Click);
            // 
            // progressBar_month
            // 
            this.progressBar_month.Location = new System.Drawing.Point(208, 29);
            this.progressBar_month.Name = "progressBar_month";
            this.progressBar_month.Size = new System.Drawing.Size(18, 87);
            this.progressBar_month.TabIndex = 7;
            this.progressBar_month.Click += new System.EventHandler(this.progressBar_month_Click);
            // 
            // Stock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 438);
            this.Controls.Add(this.radioButton_detail);
            this.Controls.Add(this.radioButton_fiveD);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel_mainBuyers);
            this.Controls.Add(this.panel_KLine);
            this.Controls.Add(this.groupBox_baseInfo);
            this.Controls.Add(this.groupBox_userSelect);
            this.Name = "Stock_Form";
            this.Text = "股票实时数据系统";
            this.Load += new System.EventHandler(this.Stock_Form_Load);
            this.groupBox_userSelect.ResumeLayout(false);
            this.panel_KLine.ResumeLayout(false);
            this.panel_KLine.PerformLayout();
            this.panel_mainBuyers.ResumeLayout(false);
            this.panel_mainBuyers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_userSelect;
        private System.Windows.Forms.GroupBox groupBox_baseInfo;
        private System.Windows.Forms.Panel panel_KLine;
        private System.Windows.Forms.RadioButton radioButton_month;
        private System.Windows.Forms.RadioButton radioButton_week;
        private System.Windows.Forms.RadioButton radioButton_day;
        private System.Windows.Forms.ListBox listBox_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_mainBuyers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton_fiveD;
        private System.Windows.Forms.RadioButton radioButton_detail;
        private System.Windows.Forms.ComboBox comboBox_stock;
        private System.Windows.Forms.ProgressBar progressBar_month;
        private System.Windows.Forms.ProgressBar progressBar_5day;
        private System.Windows.Forms.ProgressBar progressBar_now;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

