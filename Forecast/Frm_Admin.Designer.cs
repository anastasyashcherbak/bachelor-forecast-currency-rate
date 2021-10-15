namespace Forecast_Shcherbak
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forecastTlStrpMntm = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTheForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtGrdVw_admin = new System.Windows.Forms.DataGridView();
            this.CURRENCY_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUR_CURRENCY_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GC_CREATE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENCY_ON_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_FACTOR_IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURRENCYPAIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Forecast_Shcherbak.DataSet1();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlStrpBttn_add = new System.Windows.Forms.ToolStripButton();
            this.tlStrpBttn2_del = new System.Windows.Forms.ToolStripButton();
            this.tlStrpBttn_update = new System.Windows.Forms.ToolStripButton();
            this.cURRENCY_PAIRTableAdapter = new Forecast_Shcherbak.DataSet1TableAdapters.CURRENCY_PAIRTableAdapter();
            this.dATABASEOFOBSTACLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATABASE_OF_OBSTACLESTableAdapter = new Forecast_Shcherbak.DataSet1TableAdapters.DATABASE_OF_OBSTACLESTableAdapter();
            this.fORECASTOFQUOTATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORECAST_OF_QUOTATIONSTableAdapter = new Forecast_Shcherbak.DataSet1TableAdapters.FORECAST_OF_QUOTATIONSTableAdapter();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.txtBx_price = new System.Windows.Forms.TextBox();
            this.txtBx_factor = new System.Windows.Forms.TextBox();
            this.cmbBx_cur1 = new System.Windows.Forms.ComboBox();
            this.cmbBx_cur2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_add_admin = new System.Windows.Forms.Panel();
            this.txtBx_del_price = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bttn_del = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_del = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYPAIRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEOFOBSTACLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORECASTOFQUOTATIONSBindingSource)).BeginInit();
            this.pnl_add_admin.SuspendLayout();
            this.pnl_del.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.forecastTlStrpMntm,
            this.clientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.loadDataToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadDataToolStripMenuItem.Text = "Load data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // forecastTlStrpMntm
            // 
            this.forecastTlStrpMntm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeTheForecastToolStripMenuItem});
            this.forecastTlStrpMntm.Name = "forecastTlStrpMntm";
            this.forecastTlStrpMntm.Size = new System.Drawing.Size(63, 20);
            this.forecastTlStrpMntm.Text = "Forecast";
            // 
            // makeTheForecastToolStripMenuItem
            // 
            this.makeTheForecastToolStripMenuItem.Name = "makeTheForecastToolStripMenuItem";
            this.makeTheForecastToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.makeTheForecastToolStripMenuItem.Text = "Make the forecast ";
            this.makeTheForecastToolStripMenuItem.Click += new System.EventHandler(this.makeforecastmenu);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // FindClientToolStripMenuItem
            // 
            this.FindClientToolStripMenuItem.Name = "FindClientToolStripMenuItem";
            this.FindClientToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.FindClientToolStripMenuItem.Text = "Find information about client";
            this.FindClientToolStripMenuItem.Click += new System.EventHandler(this.FindClientToolStripMenuItem_Click);
            // 
            // dtGrdVw_admin
            // 
            this.dtGrdVw_admin.AllowUserToAddRows = false;
            this.dtGrdVw_admin.AllowUserToDeleteRows = false;
            this.dtGrdVw_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CURRENCY_TYPE,
            this.CUR_CURRENCY_TYPE,
            this.GC_CREATE_DATE,
            this.CURRENCY_ON_DATE,
            this.GV_FACTOR_IO});
            this.dtGrdVw_admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtGrdVw_admin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtGrdVw_admin.Location = new System.Drawing.Point(12, 51);
            this.dtGrdVw_admin.Name = "dtGrdVw_admin";
            this.dtGrdVw_admin.Size = new System.Drawing.Size(573, 292);
            this.dtGrdVw_admin.TabIndex = 3;
            this.dtGrdVw_admin.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtGrdVw_admin_CellFormatting);
            this.dtGrdVw_admin.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtGrdVw_admin_CellValidating);
            // 
            // CURRENCY_TYPE
            // 
            this.CURRENCY_TYPE.DataPropertyName = "CURRENCY_TYPE";
            this.CURRENCY_TYPE.HeaderText = "National currency";
            this.CURRENCY_TYPE.Name = "CURRENCY_TYPE";
            this.CURRENCY_TYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CUR_CURRENCY_TYPE
            // 
            this.CUR_CURRENCY_TYPE.DataPropertyName = "CUR_CURRENCY_TYPE";
            this.CUR_CURRENCY_TYPE.HeaderText = "Exchange currency";
            this.CUR_CURRENCY_TYPE.Name = "CUR_CURRENCY_TYPE";
            this.CUR_CURRENCY_TYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GC_CREATE_DATE
            // 
            this.GC_CREATE_DATE.DataPropertyName = "GC_CREATE_DATE";
            this.GC_CREATE_DATE.HeaderText = "date for exchange  ";
            this.GC_CREATE_DATE.Name = "GC_CREATE_DATE";
            // 
            // CURRENCY_ON_DATE
            // 
            this.CURRENCY_ON_DATE.DataPropertyName = "CURRENCY_ON_DATE";
            this.CURRENCY_ON_DATE.HeaderText = "price of currency";
            this.CURRENCY_ON_DATE.Name = "CURRENCY_ON_DATE";
            // 
            // GV_FACTOR_IO
            // 
            this.GV_FACTOR_IO.DataPropertyName = "GV_FACTOR_IO";
            this.GV_FACTOR_IO.HeaderText = "Influenced factor";
            this.GV_FACTOR_IO.Name = "GV_FACTOR_IO";
            this.GV_FACTOR_IO.Width = 120;
            // 
            // cURRENCYPAIRBindingSource
            // 
            this.cURRENCYPAIRBindingSource.DataMember = "CURRENCY_PAIR";
            this.cURRENCYPAIRBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpBttn_add,
            this.tlStrpBttn2_del,
            this.tlStrpBttn_update});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlStrpBttn_add
            // 
            this.tlStrpBttn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpBttn_add.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpBttn_add.Image")));
            this.tlStrpBttn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpBttn_add.Name = "tlStrpBttn_add";
            this.tlStrpBttn_add.Size = new System.Drawing.Size(23, 22);
            this.tlStrpBttn_add.Text = "Add row in table";
            this.tlStrpBttn_add.Click += new System.EventHandler(this.tlStrpBttn_add_Click);
            // 
            // tlStrpBttn2_del
            // 
            this.tlStrpBttn2_del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpBttn2_del.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpBttn2_del.Image")));
            this.tlStrpBttn2_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpBttn2_del.Name = "tlStrpBttn2_del";
            this.tlStrpBttn2_del.Size = new System.Drawing.Size(23, 22);
            this.tlStrpBttn2_del.Text = "Delete row from table";
            this.tlStrpBttn2_del.Click += new System.EventHandler(this.tlStrpBttn2_del_Click);
            // 
            // tlStrpBttn_update
            // 
            this.tlStrpBttn_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpBttn_update.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpBttn_update.Image")));
            this.tlStrpBttn_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpBttn_update.Name = "tlStrpBttn_update";
            this.tlStrpBttn_update.Size = new System.Drawing.Size(23, 22);
            this.tlStrpBttn_update.Text = "Update data";
            this.tlStrpBttn_update.Visible = false;
            this.tlStrpBttn_update.Click += new System.EventHandler(this.tlStrpBttn_update_Click);
            // 
            // cURRENCY_PAIRTableAdapter
            // 
            this.cURRENCY_PAIRTableAdapter.ClearBeforeFill = true;
            // 
            // dATABASEOFOBSTACLESBindingSource
            // 
            this.dATABASEOFOBSTACLESBindingSource.DataMember = "DATABASE_OF_OBSTACLES";
            this.dATABASEOFOBSTACLESBindingSource.DataSource = this.dataSet1;
            // 
            // dATABASE_OF_OBSTACLESTableAdapter
            // 
            this.dATABASE_OF_OBSTACLESTableAdapter.ClearBeforeFill = true;
            // 
            // fORECASTOFQUOTATIONSBindingSource
            // 
            this.fORECASTOFQUOTATIONSBindingSource.DataMember = "FORECAST_OF_QUOTATIONS";
            this.fORECASTOFQUOTATIONSBindingSource.DataSource = this.dataSet1;
            // 
            // fORECAST_OF_QUOTATIONSTableAdapter
            // 
            this.fORECAST_OF_QUOTATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(77, 233);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(110, 32);
            this.bttn_Add.TabIndex = 5;
            this.bttn_Add.Text = "Add new forecast";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // txtBx_price
            // 
            this.txtBx_price.Location = new System.Drawing.Point(126, 145);
            this.txtBx_price.Name = "txtBx_price";
            this.txtBx_price.Size = new System.Drawing.Size(121, 20);
            this.txtBx_price.TabIndex = 9;
            this.txtBx_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_price_KeyPress);
            // 
            // txtBx_factor
            // 
            this.txtBx_factor.Location = new System.Drawing.Point(126, 190);
            this.txtBx_factor.Name = "txtBx_factor";
            this.txtBx_factor.Size = new System.Drawing.Size(121, 20);
            this.txtBx_factor.TabIndex = 10;
            this.txtBx_factor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_factor_KeyPress);
            // 
            // cmbBx_cur1
            // 
            this.cmbBx_cur1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_cur1.FormattingEnabled = true;
            this.cmbBx_cur1.Items.AddRange(new object[] {
            "UAN"});
            this.cmbBx_cur1.Location = new System.Drawing.Point(126, 20);
            this.cmbBx_cur1.Name = "cmbBx_cur1";
            this.cmbBx_cur1.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_cur1.TabIndex = 11;
            // 
            // cmbBx_cur2
            // 
            this.cmbBx_cur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_cur2.FormattingEnabled = true;
            this.cmbBx_cur2.Items.AddRange(new object[] {
            "UAN",
            "EURO",
            "$"});
            this.cmbBx_cur2.Location = new System.Drawing.Point(126, 61);
            this.cmbBx_cur2.Name = "cmbBx_cur2";
            this.cmbBx_cur2.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_cur2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 104);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2015, 3, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nat. currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Exchange currrency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Currency price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Factor";
            // 
            // pnl_add_admin
            // 
            this.pnl_add_admin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_add_admin.Controls.Add(this.label4);
            this.pnl_add_admin.Controls.Add(this.label3);
            this.pnl_add_admin.Controls.Add(this.label2);
            this.pnl_add_admin.Controls.Add(this.label5);
            this.pnl_add_admin.Controls.Add(this.label1);
            this.pnl_add_admin.Controls.Add(this.dateTimePicker1);
            this.pnl_add_admin.Controls.Add(this.cmbBx_cur2);
            this.pnl_add_admin.Controls.Add(this.cmbBx_cur1);
            this.pnl_add_admin.Controls.Add(this.txtBx_factor);
            this.pnl_add_admin.Controls.Add(this.txtBx_price);
            this.pnl_add_admin.Controls.Add(this.bttn_Add);
            this.pnl_add_admin.Location = new System.Drawing.Point(601, 56);
            this.pnl_add_admin.Name = "pnl_add_admin";
            this.pnl_add_admin.Size = new System.Drawing.Size(268, 287);
            this.pnl_add_admin.TabIndex = 19;
            // 
            // txtBx_del_price
            // 
            this.txtBx_del_price.Location = new System.Drawing.Point(109, 118);
            this.txtBx_del_price.Name = "txtBx_del_price";
            this.txtBx_del_price.Size = new System.Drawing.Size(136, 20);
            this.txtBx_del_price.TabIndex = 20;
            this.txtBx_del_price.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_del_price_Validating);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // bttn_del
            // 
            this.bttn_del.Location = new System.Drawing.Point(92, 198);
            this.bttn_del.Name = "bttn_del";
            this.bttn_del.Size = new System.Drawing.Size(110, 34);
            this.bttn_del.TabIndex = 22;
            this.bttn_del.Text = "Delete forecast";
            this.bttn_del.UseVisualStyleBackColor = true;
            this.bttn_del.Click += new System.EventHandler(this.bttn_del_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date";
            // 
            // pnl_del
            // 
            this.pnl_del.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_del.Controls.Add(this.label7);
            this.pnl_del.Controls.Add(this.label6);
            this.pnl_del.Controls.Add(this.bttn_del);
            this.pnl_del.Controls.Add(this.dateTimePicker2);
            this.pnl_del.Controls.Add(this.txtBx_del_price);
            this.pnl_del.Location = new System.Drawing.Point(601, 56);
            this.pnl_del.Name = "pnl_del";
            this.pnl_del.Size = new System.Drawing.Size(259, 287);
            this.pnl_del.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Price";
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 356);
            this.Controls.Add(this.pnl_add_admin);
            this.Controls.Add(this.pnl_del);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtGrdVw_admin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forecasting the exchange rate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Admin_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURRENCYPAIRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEOFOBSTACLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORECASTOFQUOTATIONSBindingSource)).EndInit();
            this.pnl_add_admin.ResumeLayout(false);
            this.pnl_add_admin.PerformLayout();
            this.pnl_del.ResumeLayout(false);
            this.pnl_del.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forecastTlStrpMntm;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTheForecastToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtGrdVw_admin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlStrpBttn_add;
        private System.Windows.Forms.ToolStripButton tlStrpBttn2_del;
        private System.Windows.Forms.ToolStripButton tlStrpBttn_update;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cURRENCYPAIRBindingSource;
        private DataSet1TableAdapters.CURRENCY_PAIRTableAdapter cURRENCY_PAIRTableAdapter;
        private System.Windows.Forms.BindingSource dATABASEOFOBSTACLESBindingSource;
        private DataSet1TableAdapters.DATABASE_OF_OBSTACLESTableAdapter dATABASE_OF_OBSTACLESTableAdapter;
        private System.Windows.Forms.BindingSource fORECASTOFQUOTATIONSBindingSource;
        private DataSet1TableAdapters.FORECAST_OF_QUOTATIONSTableAdapter fORECAST_OF_QUOTATIONSTableAdapter;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.TextBox txtBx_price;
        private System.Windows.Forms.TextBox txtBx_factor;
        private System.Windows.Forms.ComboBox cmbBx_cur1;
        private System.Windows.Forms.ComboBox cmbBx_cur2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_add_admin;
        private System.Windows.Forms.TextBox txtBx_del_price;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button bttn_del;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENCY_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUR_CURRENCY_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GC_CREATE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENCY_ON_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_FACTOR_IO;
        private System.Windows.Forms.Label label7;
    }
}