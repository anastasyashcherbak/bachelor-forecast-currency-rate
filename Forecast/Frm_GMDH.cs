using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast_Shcherbak
{
    public partial class Frm_GMDH : Form
    {
        public Frm_GMDH()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"C:\Users\nastya\Documents\Database\diplom_currency_rate\Diplom_Shcherbak\image\GDP.png");
        }

        private void Frm_GMDH_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\externaldebt.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\interestrate.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\inflationrate.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\GDP.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\government.png");
            pictureBox6.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\war.png");
            pictureBox7.Image = Image.FromFile(@"C:\Users\nastya\Documents\Visual Studio 2013\Projects\Forecast_Shcherbak\minds.png");

        }

        private void Frm_GMDH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detail_forecast f45 = new Detail_forecast();
            //this.Close();
            f45.Show();
           // Hide();
        }
    }
}
