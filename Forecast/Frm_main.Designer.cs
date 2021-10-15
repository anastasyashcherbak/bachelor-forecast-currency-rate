namespace Forecast_Shcherbak
{
    partial class Frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.bttn_enter = new System.Windows.Forms.Button();
            this.lbl_trade = new System.Windows.Forms.Label();
            this.txtBx_EURO = new System.Windows.Forms.TextBox();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.txtBx_dolar = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_enter
            // 
            this.bttn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttn_enter.Location = new System.Drawing.Point(48, 145);
            this.bttn_enter.Name = "bttn_enter";
            this.bttn_enter.Size = new System.Drawing.Size(203, 46);
            this.bttn_enter.TabIndex = 0;
            this.bttn_enter.Text = "Enter the system of forecasting currency rate";
            this.bttn_enter.UseVisualStyleBackColor = true;
            this.bttn_enter.Click += new System.EventHandler(this.bttn_enter_Click);
            // 
            // lbl_trade
            // 
            this.lbl_trade.AutoSize = true;
            this.lbl_trade.Location = new System.Drawing.Point(12, 23);
            this.lbl_trade.Name = "lbl_trade";
            this.lbl_trade.Size = new System.Drawing.Size(183, 13);
            this.lbl_trade.TabIndex = 1;
            this.lbl_trade.Text = "Current exchange rate (EURO/UAH):";
            // 
            // txtBx_EURO
            // 
            this.txtBx_EURO.Location = new System.Drawing.Point(206, 20);
            this.txtBx_EURO.Name = "txtBx_EURO";
            this.txtBx_EURO.ReadOnly = true;
            this.txtBx_EURO.Size = new System.Drawing.Size(100, 20);
            this.txtBx_EURO.TabIndex = 2;
            this.txtBx_EURO.Text = "25,5 UAN";
            this.txtBx_EURO.TextChanged += new System.EventHandler(this.txtBx_EURO_TextChanged);
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(12, 54);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(158, 13);
            this.lbl_dolar.TabIndex = 3;
            this.lbl_dolar.Text = "Current exchange rate ($/UAN):";
            // 
            // txtBx_dolar
            // 
            this.txtBx_dolar.Location = new System.Drawing.Point(206, 51);
            this.txtBx_dolar.Name = "txtBx_dolar";
            this.txtBx_dolar.ReadOnly = true;
            this.txtBx_dolar.Size = new System.Drawing.Size(100, 20);
            this.txtBx_dolar.TabIndex = 4;
            this.txtBx_dolar.Text = "22,5 UAN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(71, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Rates for all exchange currency";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detailed information about current rate you can find on:";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(315, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtBx_dolar);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.txtBx_EURO);
            this.Controls.Add(this.lbl_trade);
            this.Controls.Add(this.bttn_enter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forecasting the exchange rate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_enter;
        private System.Windows.Forms.Label lbl_trade;
        private System.Windows.Forms.TextBox txtBx_EURO;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.TextBox txtBx_dolar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}