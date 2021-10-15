using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Odbc;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Transactions;

namespace Forecast_Shcherbak
{
    public partial class Frm_forecast : Form
    {
        public string startupPath = System.IO.Directory.GetCurrentDirectory();
        public string filename;
        string DateForecast;
        OdbcTransaction mytransaction;
        OdbcDataAdapter oda;
        //double[] currency_rate_Dollar = {24.4799,24.3961,24.31194,24.2271,24.1419,24.0561,23.9699,23.8831,23.7959,23.7082,23.62,23.5314,23.4427,23.3536,23.2640,23.1738,23.0829, 22.9911,22.8984,22.8045,22.7095,22.6066,22.4926,22.3717,22.2483,22.1268,22.0115,21.9068,21.8170,21.7466,21.7,21.6673,21.6364,21.6077,21.5815,21.5582,21.5383,21.5221,21.5101,21.5025,21.5,21.514,21.552,21.608,21.676,	21.75,21.824,21.892,21.948,21.986,22,21.9867,21.9496,21.8929,21.8208,21.7375,21.6472,21.5541,21.4624,21.3763,21.30,	21.2295,21.1582,21.0866,21.0148,20.9432,20.8722,20.802,	20.733,	20.6656,20.6,20.5358,20.4724,20.4100,20.3485,20.2879,20.2283,20.169,20.112,	20.055,	20};
        //double[] currency_rate_EURO = {24,24.3,25, 23.4, 25.2, 23.3, 24.1, 24.2, 23.6, 23.5};
        public Frm_forecast()
        {
            InitializeComponent();
            startupPath = startupPath + "\\readme.txt";
        }
        OdbcConnection con = new OdbcConnection("Driver = {Microsoft ODBC for Oracle}; Dsn=mydb; uid=Anastasiia_Shcherbak; pwd=nastya");
        private void button1_Click(object sender, EventArgs e)
        {

            if ((cmbBx_national_currency.Text == "") || (cmbBx_exchange_currency.Text == "") || (txtBx_money.Text == "")||(cmbBx_month.Text==""))
            {
                MessageBox.Show("Input all required data for forecast");
            }
            else
            {
                if (cmbBx_exchange_currency.Text == "$")
                {
                    oda = new OdbcDataAdapter("Select gc_create_date, currency_on_date from forecast_of_quotations where type_currency='$'", con);
                    //oda.SelectCommand = new OdbcCommand("Select gc_create_date, currency_on_date from forecast_of_quotations where type_currency=?", con);
                    //cmd.Parameters.Add("@type_currency", OdbcType.VarChar).Value = cmbBx_exchange_currency.SelectedItem.ToString();
                    try
                    {
                        this.con.Open();
                        BindingSource bd = new BindingSource();
                        DataTable currency_table = new DataTable();
                        oda.Fill(currency_table);

                        double[] a = (from row in currency_table.AsEnumerable()
                                      select Convert.ToDouble(row["currency_on_date"])).ToArray();
                        string[] b = (from row in currency_table.AsEnumerable()
                                      select Convert.ToString(row["gc_create_date"])).ToArray();
                        chrt_forecast.Series["Currency rate"].Points.DataBindXY(b, a);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else if (cmbBx_exchange_currency.Text == "EURO")
                {
                    oda = new OdbcDataAdapter("Select gc_create_date, currency_on_date from forecast_of_quotations where type_currency='EURO'", con);
                    //oda.SelectCommand = new OdbcCommand("Select gc_create_date, currency_on_date from forecast_of_quotations where type_currency=?", con);
                    //cmd.Parameters.Add("@type_currency", OdbcType.VarChar).Value = cmbBx_exchange_currency.SelectedItem.ToString();
                    try
                    {
                        this.con.Open();
                        BindingSource bd = new BindingSource();
                        DataTable currency_table = new DataTable();
                        oda.Fill(currency_table);

                        double[] a = (from row in currency_table.AsEnumerable()
                                      select Convert.ToDouble(row["currency_on_date"])).ToArray();
                        string[] b = (from row in currency_table.AsEnumerable()
                                      select Convert.ToString(row["gc_create_date"])).ToArray();
                        chrt_forecast.Series["Currency rate"].Points.DataBindXY(b, a);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                //DateTime date = DateTime.ParseExact(DateForecast, "dd.MM.yyyy", null);
               // DateTime date1 = Convert.ToDateTime(DateForecast);
                //OdbcCommand cmd = new OdbcCommand("Select forecast_of_quotations.currency_on_date from forecast_of_quotations join forecast_has_currency_pair on forecast_of_quotations.gc_create_date= forecast_has_currency_pair.gc_create_date join currency_pair on forecast_has_currency_pair.gv_rate_currency=currency_pair.gv_rate_currency where forecast_of_quotations.gc_create_date =? and currency_type =? and cur_currency_type = ?", con);

               // OdbcCommand cmd = new OdbcCommand("Select currency_on_date from admin_nastya where gc_create_date=?", con);
                //cmd.Parameters.Add("@gc_create_date", OdbcType.Date).Value = date;
               // cmd.Parameters.Add("@currency_type", OdbcType.VarChar).Value = cmbBx_national_currency.SelectedItem.ToString();
               // cmd.Parameters.Add("@cur_currency_type", OdbcType.VarChar).Value = cmbBx_exchange_currency.SelectedItem.ToString();
                //k = cmd.ExecuteNonQuery();
                //txtBx_rate.Text=cmd.ExecuteScalar().ToString();
                /*try
                {
                    con.Open();
                    mytransaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                    cmd.Transaction = mytransaction;
                    //txtBx_rate.Text = cmd.ExecuteScalar().ToString();
                    string result = Convert.ToString(cmd.ExecuteScalar());
                    txtBx_rate.Text = result;
                    mytransaction.Commit();
                    if (result == "")
                    {
                        //MessageBox.Show("The date was not found in database ");
                    }
                    //int result = cmd.ExecuteNonQuery();
                    // txtBx_rate.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    mytransaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }*/
                //analize the profit from exchange currency
                if (Convert.ToDouble(txtBx_money.Text) < 100)
                { txtBx_profit.Text = "low"; }
                else if ((Convert.ToDouble(txtBx_money.Text) < 1000) && ((Convert.ToDouble(txtBx_money.Text) > 100)))
                { txtBx_profit.Text = "average"; }
                else
                { txtBx_profit.Text = "high"; }
                double eps = 0.5;
                double[] factor = {129, 1.5, 121, 128, 0.2, 0.2, 0.5, 0.7 };
                double currency = 0;
                //double[] currency = { 22,23,21.5,22,21.3,20.6,20};
                double currency1 = 0;
              
                if (cmbBx_exchange_currency.Text == "$")
                {
                    ///////////////////////////////////////////
                    if (cmbBx_month.Text == "June")
                    {
                        currency = 20.9;
                    }
                    else if (cmbBx_month.Text == "July")
                    {
                        currency = 20.9 + eps;
                    }
                    else if
                        (cmbBx_month.Text == "August")
                    {
                        currency = 20.9 + 2 * eps;
                    }
                    else if (cmbBx_month.Text == "September")
                    {
                        currency = 20.9 - eps;
                    }
                    else if (cmbBx_month.Text == "October")
                    {
                        currency = 20.9 + eps * 0.5;
                    }
                    else if (cmbBx_month.Text == "November")
                    {
                        currency = 20.9 - eps * 0.5;
                    }
                    else if (cmbBx_month.Text == "December")
                    {
                        currency = 20.9 - eps * 3;
                    }
                    ///////////////////////
                    MLApp.MLApp matlab1 = new MLApp.MLApp();
                    matlab1.Execute(@"cd C:\Users\nastya\Documents\MATLAB");
                    object result1 = null;

                    // Call the MATLAB function
                    matlab1.Feval("forecast", 1, out result1, factor, currency);

                    // Display result 
                    object[] res1 = result1 as object[];
                    double nastya = Convert.ToDouble(res1[0]);
                    txtBx_rate.Text = nastya.ToString();
                    //string result1 = Convert.ToString(currency_rate_Dollar[new Random().Next(0, currency_rate_Dollar.Length)]);
                   // txtBx_rate.Text = result1;
                }
                else if (cmbBx_exchange_currency.Text == "EURO")
                {

                  //////////////////////////////////////////
                    if (cmbBx_month.Text == "June")
                    {
                        currency1 = 22.5;
                    }
                    else if (cmbBx_month.Text == "July")
                    {
                        currency1 = 22.5 + eps;
                    }
                    else if
                        (cmbBx_month.Text == "August")
                    {
                        currency1 = 22.5 + 2 * eps;
                    }
                    else if (cmbBx_month.Text == "September")
                    {
                        currency1 = 22.5 - eps;
                    }
                    else if (cmbBx_month.Text == "October")
                    {
                        currency1 = 22.5 + eps * 0.5;
                    }
                    else if (cmbBx_month.Text == "November")
                    {
                        currency1 = 22.5 - eps * 0.5;
                    }
                    else if (cmbBx_month.Text == "December")
                    {
                        currency1 = 22.5 - eps * 0.4;
                    }
                 //////////////////////////////////////////////
                    MLApp.MLApp matlab1 = new MLApp.MLApp();
                    matlab1.Execute(@"cd C:\Users\nastya\Documents\MATLAB");
                    object result1 = null;

                    // Call the MATLAB function
                    matlab1.Feval("forecast", 1, out result1, factor, currency1);

                    // Display result 
                    object[] res1 = result1 as object[];
                    double nastya = Convert.ToDouble(res1[0]);
                    txtBx_rate.Text = nastya.ToString();
                    //string result2 = Convert.ToString(currency_rate_EURO[new Random().Next(0, currency_rate_EURO.Length)]);
                    //txtBx_rate.Text = result2;
                }
                
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Save(); 
        }
        private void Save()
        {
            saveFileDialog1.ShowDialog();
            
        }
        private void exitmenuitem_click(object sender, EventArgs e)
        {
            Frm_autorization fr4 = new Frm_autorization();
            this.Close();
            fr4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBx_national_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //forgive to enter other values
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBx_exchange_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void menuhelp(object sender, EventArgs e)
        {
            Process.Start(startupPath);
        }

        private void Frm_forecast_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void txtBx_money_Validating(object sender, CancelEventArgs e)
        {
            if (txtBx_money.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(txtBx_money.Text, out num2);
                if ((isNum1==false)||(num2<0))
                {
                    MessageBox.Show("Enter correct value! Money can be only numbers and more or equal 0");
                    txtBx_money.Clear();
                   
                }
            }
        }
 
        private void txtBx_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void mnthClndr_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateForecast = e.End.ToShortDateString();
        }

        private String convertTOColumn(String str)
        {
            return "'" + str + "'";
        }

        private void bttn_forecast_Click(object sender, EventArgs e)
        {
            Detail_forecast f = new Detail_forecast();
            this.Close();
            f.Show();
            //Hide();
        }
    }
}
