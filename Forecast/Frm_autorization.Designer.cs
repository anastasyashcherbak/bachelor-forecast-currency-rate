namespace Forecast_Shcherbak
{
    partial class Frm_autorization
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_autorization));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtBx_login = new System.Windows.Forms.TextBox();
            this.txtBx_password = new System.Windows.Forms.TextBox();
            this.bttn_autorization = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bttn_regastration = new System.Windows.Forms.Button();
            this.bttn_confirm_registration = new System.Windows.Forms.Button();
            this.pnl_registration = new System.Windows.Forms.Panel();
            this.txtBx_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.tlTp_login = new System.Windows.Forms.ToolTip(this.components);
            this.tlTp_password = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            resources.ApplyResources(this.lbl_login, "lbl_login");
            this.lbl_login.Name = "lbl_login";
            // 
            // lbl_password
            // 
            resources.ApplyResources(this.lbl_password, "lbl_password");
            this.lbl_password.Name = "lbl_password";
            // 
            // txtBx_login
            // 
            this.txtBx_login.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.txtBx_login, "txtBx_login");
            this.txtBx_login.Name = "txtBx_login";
            this.txtBx_login.TextChanged += new System.EventHandler(this.txtBx_login_TextChanged);
            this.txtBx_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_login_KeyDown);
            this.txtBx_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_login_KeyPress);
            // 
            // txtBx_password
            // 
            resources.ApplyResources(this.txtBx_password, "txtBx_password");
            this.txtBx_password.Name = "txtBx_password";
            this.txtBx_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBx_password_KeyDown);
            this.txtBx_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_password_KeyPress);
            // 
            // bttn_autorization
            // 
            resources.ApplyResources(this.bttn_autorization, "bttn_autorization");
            this.bttn_autorization.Name = "bttn_autorization";
            this.bttn_autorization.UseVisualStyleBackColor = true;
            this.bttn_autorization.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // bttn_regastration
            // 
            resources.ApplyResources(this.bttn_regastration, "bttn_regastration");
            this.bttn_regastration.Name = "bttn_regastration";
            this.bttn_regastration.UseVisualStyleBackColor = true;
            this.bttn_regastration.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttn_confirm_registration
            // 
            resources.ApplyResources(this.bttn_confirm_registration, "bttn_confirm_registration");
            this.bttn_confirm_registration.Name = "bttn_confirm_registration";
            this.bttn_confirm_registration.UseVisualStyleBackColor = true;
            this.bttn_confirm_registration.Click += new System.EventHandler(this.bttn_confirm_registration_Click);
            // 
            // pnl_registration
            // 
            this.pnl_registration.Controls.Add(this.txtBx_confirm_password);
            this.pnl_registration.Controls.Add(this.lbl_email);
            this.pnl_registration.Controls.Add(this.bttn_confirm_registration);
            this.pnl_registration.Controls.Add(this.txtbx_email);
            this.pnl_registration.Controls.Add(this.lbl_confirm_password);
            resources.ApplyResources(this.pnl_registration, "pnl_registration");
            this.pnl_registration.Name = "pnl_registration";
            // 
            // txtBx_confirm_password
            // 
            resources.ApplyResources(this.txtBx_confirm_password, "txtBx_confirm_password");
            this.txtBx_confirm_password.Name = "txtBx_confirm_password";
            // 
            // lbl_email
            // 
            resources.ApplyResources(this.lbl_email, "lbl_email");
            this.lbl_email.Name = "lbl_email";
            // 
            // txtbx_email
            // 
            resources.ApplyResources(this.txtbx_email, "txtbx_email");
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_email_KeyDown);
            this.txtbx_email.Validating += new System.ComponentModel.CancelEventHandler(this.txtbx_email_Validating);
            // 
            // lbl_confirm_password
            // 
            resources.ApplyResources(this.lbl_confirm_password, "lbl_confirm_password");
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            // 
            // Frm_autorization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.pnl_registration);
            this.Controls.Add(this.bttn_regastration);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bttn_autorization);
            this.Controls.Add(this.txtBx_password);
            this.Controls.Add(this.txtBx_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_autorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_autorization_FormClosed);
            this.Load += new System.EventHandler(this.Frm_autorization_Load);
            this.pnl_registration.ResumeLayout(false);
            this.pnl_registration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        public System.Windows.Forms.TextBox txtBx_login;
        public System.Windows.Forms.TextBox txtBx_password;
        private System.Windows.Forms.Button bttn_autorization;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bttn_regastration;
        private System.Windows.Forms.Button bttn_confirm_registration;
        private System.Windows.Forms.Panel pnl_registration;
        private System.Windows.Forms.ToolTip tlTp_login;
        private System.Windows.Forms.ToolTip tlTp_password;
        private System.Windows.Forms.TextBox txtBx_confirm_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.Label lbl_confirm_password;
    }
}

