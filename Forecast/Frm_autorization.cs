using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Odbc;
using System.Transactions;

namespace Forecast_Shcherbak
{
    public partial class Frm_autorization : Form
    {
        OdbcConnection con = new OdbcConnection("Driver = {Microsoft ODBC for Oracle}; Dsn=mydb; uid=Anastasiia_Shcherbak; pwd=nastya");
        OdbcDataAdapter oda;
        //OdbcCommandBuilder cmdb;
        DataTable user_table;
        OdbcCommand comand;
        OdbcTransaction mytransaction;
        public static string AutorizateUser;
        public Frm_autorization()
        {
            InitializeComponent();
            this.Width = 296;
            this.Height = 225;
            tlTp_login.SetToolTip(txtBx_login, "Enter login no more than 16 symbols");
            tlTp_password.SetToolTip(txtBx_password, "Enter password no more than 18 symbols");
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if ((txtBx_login.Text == "") || (txtBx_password.Text == ""))
            {
                MessageBox.Show("Fill all fields");
            }
            else    if ((txtBx_login.Text == "admin") || (txtBx_password.Text == "admin"))
                {
                    Frm_Admin fr1 = new Frm_Admin();
                    fr1.Show();
                    Hide();
                }
                else if (UserLoginAutorization())
                {
                    Frm_forecast fr2 = new Frm_forecast();

                    fr2.Show();
                    txtBx_login.Clear();
                    txtBx_password.Clear();//Show();  
                    //Hide();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            txtbx_email.Clear();
            txtBx_confirm_password.Clear();

            if (this.bttn_autorization.Visible)
            {

                this.pnl_registration.Visible = true;
                this.Width = 296;
                this.Height = 281;
               
                    //MessageBox.Show("Registration in finish", "MessageInfo");
            }
            else
            {
                //code to registration
                this.pnl_registration.Visible = false;
                this.Width = 296;
                this.Height = 225;
                this.bttn_autorization.Visible = true;
            }

        }

        private void txtBx_login_TextChanged(object sender, EventArgs e)
        {
          
            if ((txtBx_login.Text == "^") || (txtBx_login.Text == ";") || (txtBx_login.Text == ":"))
            {
                MessageBox.Show("Incorrect data! Do not input any ^, :,; symbols");
            }
        }

        private void bttn_confirm_registration_Click(object sender, EventArgs e)
        {
            if ( (txtbx_email.Text == "") || (txtBx_password.Text != txtBx_confirm_password.Text))
            {
                MessageBox.Show("Fill please all fields or Password and confirm password are different!");

            }           
            else
            {
                int numRowsInsert = 0;
                comand = new OdbcCommand("{call INSERTUSER1(?,?,?)}", con);
                comand.CommandType = CommandType.StoredProcedure;
                OdbcParameter username = comand.Parameters.Add("username", OdbcType.VarChar, 20);
                username.Direction = ParameterDirection.Input;
                OdbcParameter userlogin = comand.Parameters.Add("userlogin", OdbcType.VarChar, 20);
                userlogin.Direction = ParameterDirection.Input;
                OdbcParameter useremail = comand.Parameters.Add("useremail", OdbcType.VarChar, 20);
                useremail.Direction = ParameterDirection.Input;

                username.Value = txtBx_login.Text;
                userlogin.Value = txtBx_password.Text;
                useremail.Value = txtbx_email.Text;

                // make connection and execute procedure
                try
                {
                    con.Open();
                    mytransaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                    comand.Transaction = mytransaction;
                    numRowsInsert = comand.ExecuteNonQuery();
                    mytransaction.Commit();
                }
                catch (Exception ex)
                {
                    mytransaction.Rollback();
                    MessageBox.Show(ex.Message);//"Login already exists");
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show("Registration is successful");
                this.pnl_registration.Visible = false;
                this.bttn_autorization.Visible = true;
                this.bttn_regastration.Visible = true;
                this.Width = 296;
                this.Height = 225;
            }
        }


        private void Frm_autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_main fr = new Frm_main();
            fr.Show();
            //Close();
        }


        private void txtBx_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                this.ActiveControl = txtBx_password;         
        }

        private void txtbx_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                this.ActiveControl = txtBx_confirm_password;
        }

        
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "e-mail address must be valid e-mail address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void txtbx_email_Validating(object sender, CancelEventArgs e)
        {

           
            string errorMsg;
            if (!ValidEmailAddress(txtbx_email.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.             
                txtbx_email.Select(0, txtbx_email.Text.Length);
                MessageBox.Show("e-mail address must be valid e-mail address format.\n" +
               "For example 'someone@example.com' ");
                // Set the ErrorProvider error with the text to display. 
                //this.errorProvider1.SetError(txtbx_email, errorMsg);
            }
        }

        private bool UserLoginAutorization()
    {
        user_table = new DataTable();
        try
        {
             con.Open();
            oda = new OdbcDataAdapter("Select login,password from \"USER_ROLE\"" +
                                                                "where login = " + convertTOColumn(txtBx_login.Text) +
                                                                 "and password = " + convertTOColumn(txtBx_password.Text), con);
               oda.Fill(user_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            //return statement
        if (user_table.Rows.Count != 0)
        {
            AutorizateUser = user_table.Rows[0].ItemArray[0].ToString();
            return true;
        }
        else
        {
            MessageBox.Show("Incorrect user login or password! Enter correct information or register","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
                  
    }

        private void txtBx_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.button1_Click(sender, e);
            else
            { 
                if (e.KeyCode==Keys.Down)
                    this.ActiveControl = txtbx_email;
            }
        }

        private void txtBx_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_password_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
           
        }
        private String convertTOColumn(String str)
        {
            return "'" + str + "'";
        }

        private void Frm_autorization_Load(object sender, EventArgs e)
        {

        }
    }
}