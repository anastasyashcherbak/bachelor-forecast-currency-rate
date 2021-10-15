namespace Forecast_Shcherbak
{
    partial class Frm_forecast
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_forecast));
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_currency = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlStrpMntm_main = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentForecastTlStrMntm = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTlStrpMntm = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBx_national_currency = new System.Windows.Forms.ComboBox();
            this.grpBx_currency = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_money = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBx_exchange_currency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chrt_forecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_profit = new System.Windows.Forms.TextBox();
            this.txtBx_rate = new System.Windows.Forms.TextBox();
            this.lbl_profit = new System.Windows.Forms.Label();
            this.lbl_currency_rate = new System.Windows.Forms.Label();
            this.grpBx_forecast = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttn_forecast = new System.Windows.Forms.Button();
            this.cmbBx_month = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBx_currency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_forecast)).BeginInit();
            this.grpBx_forecast.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "National currency";
            // 
            // bttn_currency
            // 
            this.bttn_currency.Location = new System.Drawing.Point(4, 345);
            this.bttn_currency.Name = "bttn_currency";
            this.bttn_currency.Size = new System.Drawing.Size(164, 56);
            this.bttn_currency.TabIndex = 1;
            this.bttn_currency.Text = "Currency rate";
            this.bttn_currency.UseVisualStyleBackColor = true;
            this.bttn_currency.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpMntm_main,
            this.helpTlStrpMntm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlStrpMntm_main
            // 
            this.tlStrpMntm_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentForecastTlStrMntm});
            this.tlStrpMntm_main.Name = "tlStrpMntm_main";
            this.tlStrpMntm_main.Size = new System.Drawing.Size(46, 20);
            this.tlStrpMntm_main.Text = "Main";
            // 
            // saveCurrentForecastTlStrMntm
            // 
            this.saveCurrentForecastTlStrMntm.Name = "saveCurrentForecastTlStrMntm";
            this.saveCurrentForecastTlStrMntm.Size = new System.Drawing.Size(67, 22);
            this.saveCurrentForecastTlStrMntm.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpTlStrpMntm
            // 
            this.helpTlStrpMntm.Name = "helpTlStrpMntm";
            this.helpTlStrpMntm.Size = new System.Drawing.Size(44, 20);
            this.helpTlStrpMntm.Text = "Help";
            this.helpTlStrpMntm.Click += new System.EventHandler(this.menuhelp);
            // 
            // cmbBx_national_currency
            // 
            this.cmbBx_national_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_national_currency.FormattingEnabled = true;
            this.cmbBx_national_currency.Items.AddRange(new object[] {
            "UAN"});
            this.cmbBx_national_currency.Location = new System.Drawing.Point(21, 32);
            this.cmbBx_national_currency.Name = "cmbBx_national_currency";
            this.cmbBx_national_currency.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_national_currency.TabIndex = 3;
            this.cmbBx_national_currency.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpBx_currency
            // 
            this.grpBx_currency.Controls.Add(this.label4);
            this.grpBx_currency.Controls.Add(this.txtBx_money);
            this.grpBx_currency.Controls.Add(this.groupBox1);
            this.grpBx_currency.Controls.Add(this.cmbBx_exchange_currency);
            this.grpBx_currency.Controls.Add(this.label2);
            this.grpBx_currency.Controls.Add(this.cmbBx_national_currency);
            this.grpBx_currency.Controls.Add(this.label1);
            this.grpBx_currency.Location = new System.Drawing.Point(4, 39);
            this.grpBx_currency.Name = "grpBx_currency";
            this.grpBx_currency.Size = new System.Drawing.Size(168, 165);
            this.grpBx_currency.TabIndex = 4;
            this.grpBx_currency.TabStop = false;
            this.grpBx_currency.Text = "Choose the currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount of money";
            // 
            // txtBx_money
            // 
            this.txtBx_money.Location = new System.Drawing.Point(21, 89);
            this.txtBx_money.MaxLength = 30;
            this.txtBx_money.Name = "txtBx_money";
            this.txtBx_money.Size = new System.Drawing.Size(121, 20);
            this.txtBx_money.TabIndex = 16;
            this.txtBx_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_money_KeyPress);
            this.txtBx_money.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_money_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbBx_exchange_currency
            // 
            this.cmbBx_exchange_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_exchange_currency.FormattingEnabled = true;
            this.cmbBx_exchange_currency.Items.AddRange(new object[] {
            "EURO",
            "$"});
            this.cmbBx_exchange_currency.Location = new System.Drawing.Point(21, 138);
            this.cmbBx_exchange_currency.Name = "cmbBx_exchange_currency";
            this.cmbBx_exchange_currency.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_exchange_currency.TabIndex = 8;
            this.cmbBx_exchange_currency.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exchange currency";
            // 
            // chrt_forecast
            // 
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Years;
            chartArea1.AxisX.Title = "Years from 1996-2015(current)";
            chartArea1.AxisY.Title = "UAN";
            chartArea1.Name = "ChartArea1";
            this.chrt_forecast.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_forecast.Legends.Add(legend1);
            this.chrt_forecast.Location = new System.Drawing.Point(185, 39);
            this.chrt_forecast.Name = "chrt_forecast";
            this.chrt_forecast.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Currency rate";
            this.chrt_forecast.Series.Add(series1);
            this.chrt_forecast.Size = new System.Drawing.Size(458, 301);
            this.chrt_forecast.TabIndex = 5;
            this.chrt_forecast.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose date of forecast";
            // 
            // txtBx_profit
            // 
            this.txtBx_profit.Location = new System.Drawing.Point(190, 30);
            this.txtBx_profit.Name = "txtBx_profit";
            this.txtBx_profit.ReadOnly = true;
            this.txtBx_profit.Size = new System.Drawing.Size(189, 20);
            this.txtBx_profit.TabIndex = 10;
            // 
            // txtBx_rate
            // 
            this.txtBx_rate.Location = new System.Drawing.Point(190, 69);
            this.txtBx_rate.Name = "txtBx_rate";
            this.txtBx_rate.ReadOnly = true;
            this.txtBx_rate.Size = new System.Drawing.Size(189, 20);
            this.txtBx_rate.TabIndex = 11;
            // 
            // lbl_profit
            // 
            this.lbl_profit.AutoSize = true;
            this.lbl_profit.Location = new System.Drawing.Point(21, 37);
            this.lbl_profit.Name = "lbl_profit";
            this.lbl_profit.Size = new System.Drawing.Size(148, 13);
            this.lbl_profit.TabIndex = 12;
            this.lbl_profit.Text = "Profit from exchange currency";
            // 
            // lbl_currency_rate
            // 
            this.lbl_currency_rate.AutoSize = true;
            this.lbl_currency_rate.Location = new System.Drawing.Point(52, 76);
            this.lbl_currency_rate.Name = "lbl_currency_rate";
            this.lbl_currency_rate.Size = new System.Drawing.Size(70, 13);
            this.lbl_currency_rate.TabIndex = 13;
            this.lbl_currency_rate.Text = "Currency rate";
            // 
            // grpBx_forecast
            // 
            this.grpBx_forecast.Controls.Add(this.lbl_currency_rate);
            this.grpBx_forecast.Controls.Add(this.lbl_profit);
            this.grpBx_forecast.Controls.Add(this.txtBx_rate);
            this.grpBx_forecast.Controls.Add(this.txtBx_profit);
            this.grpBx_forecast.Location = new System.Drawing.Point(185, 358);
            this.grpBx_forecast.Name = "grpBx_forecast";
            this.grpBx_forecast.Size = new System.Drawing.Size(458, 108);
            this.grpBx_forecast.TabIndex = 14;
            this.grpBx_forecast.TabStop = false;
            this.grpBx_forecast.Text = "Forecast of exchange rate";
            // 
            // bttn_forecast
            // 
            this.bttn_forecast.Location = new System.Drawing.Point(4, 407);
            this.bttn_forecast.Name = "bttn_forecast";
            this.bttn_forecast.Size = new System.Drawing.Size(164, 52);
            this.bttn_forecast.TabIndex = 15;
            this.bttn_forecast.Text = "Details of forecast";
            this.bttn_forecast.UseVisualStyleBackColor = true;
            this.bttn_forecast.Click += new System.EventHandler(this.bttn_forecast_Click);
            // 
            // cmbBx_month
            // 
            this.cmbBx_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_month.FormattingEnabled = true;
            this.cmbBx_month.Items.AddRange(new object[] {
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbBx_month.Location = new System.Drawing.Point(26, 250);
            this.cmbBx_month.Name = "cmbBx_month";
            this.cmbBx_month.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_month.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "2015";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Year";
            // 
            // Frm_forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbBx_month);
            this.Controls.Add(this.bttn_forecast);
            this.Controls.Add(this.grpBx_forecast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chrt_forecast);
            this.Controls.Add(this.grpBx_currency);
            this.Controls.Add(this.bttn_currency);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_forecast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forecasting the exchange rate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_forecast_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBx_currency.ResumeLayout(false);
            this.grpBx_currency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_forecast)).EndInit();
            this.grpBx_forecast.ResumeLayout(false);
            this.grpBx_forecast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_currency;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlStrpMntm_main;
        private System.Windows.Forms.ComboBox cmbBx_national_currency;
        private System.Windows.Forms.GroupBox grpBx_currency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_forecast;
        private System.Windows.Forms.ComboBox cmbBx_exchange_currency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentForecastTlStrMntm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_profit;
        private System.Windows.Forms.TextBox txtBx_rate;
        private System.Windows.Forms.Label lbl_profit;
        private System.Windows.Forms.Label lbl_currency_rate;
        private System.Windows.Forms.GroupBox grpBx_forecast;
        private System.Windows.Forms.ToolStripMenuItem helpTlStrpMntm;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_money;
        private System.Windows.Forms.Button bttn_forecast;
        private System.Windows.Forms.ComboBox cmbBx_month;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}