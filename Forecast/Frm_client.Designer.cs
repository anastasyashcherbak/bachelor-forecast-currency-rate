namespace Forecast_Shcherbak
{
    partial class Frm_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_client));
            this.dtGrdVw_client = new System.Windows.Forms.DataGridView();
            this.GV_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBEROFCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_COUNT_BASIC_CURRENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_PROFIT_O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Forecast_Shcherbak.DataSet1();
            this.uSERCUSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlStrpBttn_load = new System.Windows.Forms.ToolStripButton();
            this.tlStrpBttn_add = new System.Windows.Forms.ToolStripButton();
            this.tlStrpBttn_del = new System.Windows.Forms.ToolStripButton();
            this.tlStrpBttn_save = new System.Windows.Forms.ToolStripButton();
            this.uSER_CUSTTableAdapter = new Forecast_Shcherbak.DataSet1TableAdapters.USER_CUSTTableAdapter();
            this.oRDER_USERTableAdapter = new Forecast_Shcherbak.DataSet1TableAdapters.ORDER_USERTableAdapter();
            this.txtBx_names = new System.Windows.Forms.TextBox();
            this.txtBx_card = new System.Windows.Forms.TextBox();
            this.txtBx_amount = new System.Windows.Forms.TextBox();
            this.txtBx_profit = new System.Windows.Forms.TextBox();
            this.bttn1_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Add = new System.Windows.Forms.Panel();
            this.txtBx_del_client = new System.Windows.Forms.TextBox();
            this.txtBx_del_card = new System.Windows.Forms.TextBox();
            this.bttn_del = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_del = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERCUSTBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.pnl_Add.SuspendLayout();
            this.pnl_del.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdVw_client
            // 
            this.dtGrdVw_client.AllowUserToAddRows = false;
            this.dtGrdVw_client.AllowUserToDeleteRows = false;
            this.dtGrdVw_client.AutoGenerateColumns = false;
            this.dtGrdVw_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_USERNAME,
            this.nUMBEROFCARDDataGridViewTextBoxColumn,
            this.GV_COUNT_BASIC_CURRENCY,
            this.GV_PROFIT_O});
            this.dtGrdVw_client.DataSource = this.oRDERUSERBindingSource;
            this.dtGrdVw_client.Location = new System.Drawing.Point(12, 28);
            this.dtGrdVw_client.Name = "dtGrdVw_client";
            this.dtGrdVw_client.Size = new System.Drawing.Size(504, 229);
            this.dtGrdVw_client.TabIndex = 0;
            // 
            // GV_USERNAME
            // 
            this.GV_USERNAME.DataPropertyName = "GV_USERNAME";
            this.GV_USERNAME.HeaderText = "Client name";
            this.GV_USERNAME.Name = "GV_USERNAME";
            // 
            // nUMBEROFCARDDataGridViewTextBoxColumn
            // 
            this.nUMBEROFCARDDataGridViewTextBoxColumn.DataPropertyName = "NUMBER_OF_CARD";
            this.nUMBEROFCARDDataGridViewTextBoxColumn.HeaderText = "Card number";
            this.nUMBEROFCARDDataGridViewTextBoxColumn.Name = "nUMBEROFCARDDataGridViewTextBoxColumn";
            this.nUMBEROFCARDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMBEROFCARDDataGridViewTextBoxColumn.Width = 120;
            // 
            // GV_COUNT_BASIC_CURRENCY
            // 
            this.GV_COUNT_BASIC_CURRENCY.DataPropertyName = "GV_COUNT_BASIC_CURRENCY";
            this.GV_COUNT_BASIC_CURRENCY.HeaderText = "Amount of exchange money ";
            this.GV_COUNT_BASIC_CURRENCY.Name = "GV_COUNT_BASIC_CURRENCY";
            this.GV_COUNT_BASIC_CURRENCY.ReadOnly = true;
            this.GV_COUNT_BASIC_CURRENCY.Width = 120;
            // 
            // GV_PROFIT_O
            // 
            this.GV_PROFIT_O.DataPropertyName = "GV_PROFIT_O";
            this.GV_PROFIT_O.HeaderText = "Profit from forecast";
            this.GV_PROFIT_O.Name = "GV_PROFIT_O";
            this.GV_PROFIT_O.Width = 120;
            // 
            // oRDERUSERBindingSource
            // 
            this.oRDERUSERBindingSource.DataMember = "ORDER_USER";
            this.oRDERUSERBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERCUSTBindingSource
            // 
            this.uSERCUSTBindingSource.DataMember = "USER_CUST";
            this.uSERCUSTBindingSource.DataSource = this.dataSet1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpBttn_load,
            this.tlStrpBttn_add,
            this.tlStrpBttn_del,
            this.tlStrpBttn_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlStrpBttn_load
            // 
            this.tlStrpBttn_load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpBttn_load.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpBttn_load.Image")));
            this.tlStrpBttn_load.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.tlStrpBttn_load.Name = "tlStrpBttn_load";
            this.tlStrpBttn_load.Size = new System.Drawing.Size(23, 22);
            this.tlStrpBttn_load.Text = "Load data";
            this.tlStrpBttn_load.Click += new System.EventHandler(this.tlStrpBttn_load_Click);
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
            // tlStrpBttn_del
            // 
            this.tlStrpBttn_del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpBttn_del.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpBttn_del.Image")));
            this.tlStrpBttn_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpBttn_del.Name = "tlStrpBttn_del";
            this.tlStrpBttn_del.Size = new System.Drawing.Size(23, 22);
            this.tlStrpBttn_del.Text = "Delete row from table";
            this.tlStrpBttn_del.Click += new System.EventHandler(this.tlStrpBttn_del_Click);
            // 
            // tlStrpBttn_save
            // 
            this.tlStrpBttn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpBttn_save.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpBttn_save.Image")));
            this.tlStrpBttn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpBttn_save.Name = "tlStrpBttn_save";
            this.tlStrpBttn_save.Size = new System.Drawing.Size(23, 22);
            this.tlStrpBttn_save.Text = "Update data";
            this.tlStrpBttn_save.Click += new System.EventHandler(this.tlStrpBttn_save_Click);
            // 
            // uSER_CUSTTableAdapter
            // 
            this.uSER_CUSTTableAdapter.ClearBeforeFill = true;
            // 
            // oRDER_USERTableAdapter
            // 
            this.oRDER_USERTableAdapter.ClearBeforeFill = true;
            // 
            // txtBx_names
            // 
            this.txtBx_names.Location = new System.Drawing.Point(102, 13);
            this.txtBx_names.MaxLength = 50;
            this.txtBx_names.Name = "txtBx_names";
            this.txtBx_names.Size = new System.Drawing.Size(100, 20);
            this.txtBx_names.TabIndex = 2;
            this.txtBx_names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_names_KeyPress);
            // 
            // txtBx_card
            // 
            this.txtBx_card.Location = new System.Drawing.Point(102, 60);
            this.txtBx_card.MaxLength = 10;
            this.txtBx_card.Name = "txtBx_card";
            this.txtBx_card.Size = new System.Drawing.Size(100, 20);
            this.txtBx_card.TabIndex = 3;
            this.txtBx_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_card_KeyPress);
            this.txtBx_card.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_card_Validating);
            // 
            // txtBx_amount
            // 
            this.txtBx_amount.Location = new System.Drawing.Point(102, 104);
            this.txtBx_amount.MaxLength = 7;
            this.txtBx_amount.Name = "txtBx_amount";
            this.txtBx_amount.Size = new System.Drawing.Size(100, 20);
            this.txtBx_amount.TabIndex = 4;
            this.txtBx_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_amount_KeyPress);
            this.txtBx_amount.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_amount_Validating);
            // 
            // txtBx_profit
            // 
            this.txtBx_profit.Location = new System.Drawing.Point(102, 154);
            this.txtBx_profit.MaxLength = 10;
            this.txtBx_profit.Name = "txtBx_profit";
            this.txtBx_profit.Size = new System.Drawing.Size(100, 20);
            this.txtBx_profit.TabIndex = 5;
            this.txtBx_profit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_profit_KeyPress);
            this.txtBx_profit.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_profit_Validating);
            // 
            // bttn1_Add
            // 
            this.bttn1_Add.Location = new System.Drawing.Point(54, 193);
            this.bttn1_Add.Name = "bttn1_Add";
            this.bttn1_Add.Size = new System.Drawing.Size(111, 23);
            this.bttn1_Add.TabIndex = 6;
            this.bttn1_Add.Text = "Add client";
            this.bttn1_Add.UseVisualStyleBackColor = true;
            this.bttn1_Add.Click += new System.EventHandler(this.bttn1_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Card number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount of money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Profit";
            // 
            // pnl_Add
            // 
            this.pnl_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Add.Controls.Add(this.label4);
            this.pnl_Add.Controls.Add(this.label3);
            this.pnl_Add.Controls.Add(this.label2);
            this.pnl_Add.Controls.Add(this.label1);
            this.pnl_Add.Controls.Add(this.bttn1_Add);
            this.pnl_Add.Controls.Add(this.txtBx_profit);
            this.pnl_Add.Controls.Add(this.txtBx_amount);
            this.pnl_Add.Controls.Add(this.txtBx_card);
            this.pnl_Add.Controls.Add(this.txtBx_names);
            this.pnl_Add.Location = new System.Drawing.Point(529, 31);
            this.pnl_Add.Name = "pnl_Add";
            this.pnl_Add.Size = new System.Drawing.Size(213, 229);
            this.pnl_Add.TabIndex = 11;
            // 
            // txtBx_del_client
            // 
            this.txtBx_del_client.Location = new System.Drawing.Point(98, 49);
            this.txtBx_del_client.MaxLength = 50;
            this.txtBx_del_client.Name = "txtBx_del_client";
            this.txtBx_del_client.Size = new System.Drawing.Size(100, 20);
            this.txtBx_del_client.TabIndex = 11;
            this.txtBx_del_client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_del_client_KeyPress);
            // 
            // txtBx_del_card
            // 
            this.txtBx_del_card.Location = new System.Drawing.Point(98, 103);
            this.txtBx_del_card.MaxLength = 15;
            this.txtBx_del_card.Name = "txtBx_del_card";
            this.txtBx_del_card.Size = new System.Drawing.Size(100, 20);
            this.txtBx_del_card.TabIndex = 12;
            this.txtBx_del_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_del_card_KeyPress);
            this.txtBx_del_card.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_del_card_Validating);
            // 
            // bttn_del
            // 
            this.bttn_del.Location = new System.Drawing.Point(62, 165);
            this.bttn_del.Name = "bttn_del";
            this.bttn_del.Size = new System.Drawing.Size(105, 27);
            this.bttn_del.TabIndex = 13;
            this.bttn_del.Text = "Delete client";
            this.bttn_del.UseVisualStyleBackColor = true;
            this.bttn_del.Click += new System.EventHandler(this.bttn_del_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Client name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Card number";
            // 
            // pnl_del
            // 
            this.pnl_del.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_del.Controls.Add(this.label6);
            this.pnl_del.Controls.Add(this.label5);
            this.pnl_del.Controls.Add(this.bttn_del);
            this.pnl_del.Controls.Add(this.txtBx_del_card);
            this.pnl_del.Controls.Add(this.txtBx_del_client);
            this.pnl_del.Location = new System.Drawing.Point(533, 31);
            this.pnl_del.Name = "pnl_del";
            this.pnl_del.Size = new System.Drawing.Size(209, 225);
            this.pnl_del.TabIndex = 16;
            // 
            // Frm_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 269);
            this.Controls.Add(this.pnl_del);
            this.Controls.Add(this.pnl_Add);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtGrdVw_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_client_FormClosed);
            this.Load += new System.EventHandler(this.Frm_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERCUSTBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_Add.ResumeLayout(false);
            this.pnl_Add.PerformLayout();
            this.pnl_del.ResumeLayout(false);
            this.pnl_del.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVw_client;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlStrpBttn_add;
        private System.Windows.Forms.ToolStripButton tlStrpBttn_del;
        private System.Windows.Forms.ToolStripButton tlStrpBttn_save;
        private System.Windows.Forms.ToolStripButton tlStrpBttn_load;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource uSERCUSTBindingSource;
        private DataSet1TableAdapters.USER_CUSTTableAdapter uSER_CUSTTableAdapter;
        private System.Windows.Forms.BindingSource oRDERUSERBindingSource;
        private DataSet1TableAdapters.ORDER_USERTableAdapter oRDER_USERTableAdapter;
        private System.Windows.Forms.TextBox txtBx_names;
        private System.Windows.Forms.TextBox txtBx_card;
        private System.Windows.Forms.TextBox txtBx_amount;
        private System.Windows.Forms.TextBox txtBx_profit;
        private System.Windows.Forms.Button bttn1_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_Add;
        private System.Windows.Forms.TextBox txtBx_del_client;
        private System.Windows.Forms.TextBox txtBx_del_card;
        private System.Windows.Forms.Button bttn_del;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBEROFCARDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_COUNT_BASIC_CURRENCY;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_PROFIT_O;
    }
}