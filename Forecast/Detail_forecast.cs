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
    public partial class Detail_forecast : Form
    {
        
        public Detail_forecast()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute(@"cd C:\Users\nastya\Documents\MATLAB");
            object result = null;

            // Call the MATLAB function 
            matlab.Feval("Fuzzy_Logic_Exchange_Rate_Evaluation", 1, out result);

            // Display result 
            object[] res = result as object[]; 
        }

        private void bttn_GMDH_Click(object sender, EventArgs e)
        {
            Frm_GMDH fy = new Frm_GMDH();
            fy.ShowDialog();
            Hide();
        }

        private void bttn_grafic_Click(object sender, EventArgs e)
        {
            MLApp.MLApp matlab1 = new MLApp.MLApp();
            matlab1.Execute(@"cd C:\Users\nastya\Documents\MATLAB");
            object k = null;

            // Call the MATLAB function
            matlab1.Feval("Interpolation_forecast", 1, out k);

            // Display result 
            object[] res1 = k as object[]; 
        }

        private void Detail_forecast_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_forecast f = new Frm_forecast();
            //this.Close();
            f.Show();
            //Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double currency=0;
            double[] factor= new double[8];
            if ((comboBox1.Text == "") || (textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
            {
                MessageBox.Show("Enter all values for factors");
            }
           /* if ()
            {
            }*/
            factor[0]=Convert.ToDouble(textBox1.Text);
             factor[1]=Convert.ToDouble(textBox2.Text);
             factor[2]=Convert.ToDouble(textBox3.Text);
             factor[3]=Convert.ToDouble(textBox4.Text); 
            factor[4]=Convert.ToDouble(textBox5.Text);
             factor[5]=Convert.ToDouble(textBox6.Text);
             factor[6]=Convert.ToDouble(textBox7.Text);
             factor[7]=0.7;
            if (comboBox1.Text=="$")
                {
                  currency=20.9;
                }
            else if (comboBox1.Text=="EURO")
                {
                  currency=22.5;
                }
            MLApp.MLApp matlab1 = new MLApp.MLApp();
            matlab1.Execute(@"cd C:\Users\nastya\Documents\MATLAB");
            object result1 = null;

            // Call the MATLAB function
            matlab1.Feval("forecast", 1, out result1,factor,currency);

            // Display result 
            object[] res1 = result1 as object[];
            double nastya = Convert.ToDouble(res1[0]);
            textBox8.Text = nastya.ToString();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox1.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox1.Clear();

                }
                if ((Convert.ToDouble(textBox1.Text) < 90) && (Convert.ToDouble(textBox1.Text) > 500))
                {
                    MessageBox.Show("Enter values from 90 to 500 percent");
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox2.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox2.Clear();

                }
                if ((Convert.ToDouble(textBox2.Text) < 0) && (Convert.ToDouble(textBox2.Text) > 3))
                {
                    MessageBox.Show("Enter values from 0 to 3");
                }
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox3.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox3.Clear();

                }
                if ((Convert.ToDouble(textBox3.Text) < 65) && (Convert.ToDouble(textBox3.Text) > 140))
                {
                    MessageBox.Show("Enter values from 65 to 140");
                }
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox4.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox4.Clear();

                }
                if ((Convert.ToDouble(textBox4.Text) < 0) && (Convert.ToDouble(textBox4.Text) > 150))
                {
                    MessageBox.Show("Enter values from 0 to 150");
                }
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox5.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox5.Clear();

                }
                if ((Convert.ToDouble(textBox5.Text) < 0) && (Convert.ToDouble(textBox5.Text) > 1))
                {
                    MessageBox.Show("Enter values from 0 to 1");
                }
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox6.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox6.Clear();

                }
            }
            if ((Convert.ToDouble(textBox6.Text) < 0) && (Convert.ToDouble(textBox6.Text) > 1))
            {
                MessageBox.Show("Enter values from 0 to 1");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (textBox7.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(textBox7.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Cannot enter symbols or text. Only numbers");
                    textBox7.Clear();
                }
                if ((Convert.ToDouble(textBox7.Text) < 0) && (Convert.ToDouble(textBox7.Text) > 1))
                {
                    MessageBox.Show("Enter values from 0(good minds) to 1(very bad minds)");
                }
            }
        }
    }
}
