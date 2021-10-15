using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Forecast_Shcherbak
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void bttn_enter_Click(object sender, EventArgs e)
        {
            Frm_autorization fr4 = new Frm_autorization();
            fr4.Show();
            Hide();
            
        }

        private void Frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_main fr = new Frm_main();
            fr.Close();
        }

        private void txtBx_EURO_TextChanged(object sender, EventArgs e)
        {
            txtBx_EURO.Text = string.Format("42");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://minfin.com.ua/currency/banks/usd/");
        }
    }
}
