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
    public partial class Frm_client : Form
    {
        //OdbcDataAdapter oda;
        OdbcCommandBuilder cmdb;
        OdbcTransaction mytransaction;
        //DataTable user_table;
        //BindingSource bd;// OdbcDataAdapter oda;
        OdbcCommand comand;
        public Frm_client()
        {
            InitializeComponent();
            this.Width = 540;
            this.Height = 308;
            this.pnl_Add.Visible = false;
            this.pnl_del.Visible = false;
        }

       OdbcConnection con = new OdbcConnection("Driver = {Microsoft ODBC for Oracle}; Dsn=mydb; uid=Anastasiia_Shcherbak; pwd=nastya");
       //OdbcConnection con = new OdbcConnection("Driver = {Microsoft ODBC for Oracle}; Dsn=mydb; uid=Group_finance; pwd=Group_finance");
        private void Frm_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Admin fr2 = new Frm_Admin();
            fr2.Show();
            Hide();
        }

       

        private void tlStrpBttn_del_Click(object sender, EventArgs e)
        {
            /*if (this.dtGrdVw_client.SelectedRows.Count > 0)
            {
                dtGrdVw_client.Rows.RemoveAt(this.dtGrdVw_client.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Cannot delete the last row!");
            } */
            this.pnl_Add.Visible = false;
            this.pnl_del.Visible = true;
            this.Width = 761;
            this.Height = 308;
        }

        private void tlStrpBttn_load_Click(object sender, EventArgs e)
        {
            this.con.Open();
            OdbcDataAdapter oda = new OdbcDataAdapter("Select user_cust.gv_username, user_cust.number_of_card, gv_profit_o, gv_count_basic_currency from USER_CUST, Order_user where user_cust.number_of_card=Order_user.number_of_card", con);
            DataSet dt = new DataSet();
            oda.Fill(dt);

            BindingSource bd = new BindingSource();
            DataTable user_table = new DataTable();

            oda.Fill(user_table);
            bd.DataSource = user_table;

            dtGrdVw_client.DataSource = bd;
            
            
            con.Close();

         
        }

        private void tlStrpBttn_add_Click(object sender, EventArgs e)
        {
            this.pnl_del.Visible = false;
            this.pnl_Add.Visible = true;
            this.Width = 761;
            this.Height = 308;
        }
        private void Frm_client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ORDER_USER' table. You can move, or remove it, as needed.
            //this.oRDER_USERTableAdapter.Fill(this.dataSet1.ORDER_USER);
            // TODO: This line of code loads data into the 'dataSet1.USER_CUST' table. You can move, or remove it, as needed.
            //this.uSER_CUSTTableAdapter.Fill(this.dataSet1.USER_CUST);

        }

        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uSER_CUSTTableAdapter.FillBy(this.dataSet1.USER_CUST);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tlStrpBttn_save_Click(object sender, EventArgs e)
        {
            int numRowsInsert = 0;
            comand = new OdbcCommand("{call UPDATE_USER_CUST(?,?,?)}", con);
            comand.CommandType = CommandType.StoredProcedure;
            OdbcParameter names = comand.Parameters.Add("names", OdbcType.VarChar, 20);
            names.Direction = ParameterDirection.Input;
            OdbcParameter cardnumber = comand.Parameters.Add("cardnumber", OdbcType.Decimal);
            cardnumber.Direction = ParameterDirection.Input;
            OdbcParameter profit = comand.Parameters.Add("profit", OdbcType.Double);
            profit.Direction = ParameterDirection.Input;
            //OdbcParameter amount = comand.Parameters.Add("amount", OdbcType.Double);
            //amount.Direction = ParameterDirection.Input;

            //this.dtGrdVw_client.Columns[1].ValueType = typeof(Decimal);
            //names.Value = dtGrdVw_client.Columns[0].ToString();
            //cardnumber.Value = decimal.Parse(dtGrdVw_client.Columns[1].ToString());

            names.Value = dtGrdVw_client.CurrentRow.Cells[0].Value;
            cardnumber.Value = dtGrdVw_client.CurrentRow.Cells[1].Value;
            //amount.Value = dtGrdVw_client.CurrentRow.Cells[2].Value;
            profit.Value = dtGrdVw_client.CurrentRow.Cells[3].Value;
            // make connection and execute procedure
            try
            {
                con.Open();
                mytransaction = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                comand.Transaction = mytransaction;
                numRowsInsert = comand.ExecuteNonQuery();
                mytransaction.Commit();
            }
            catch (Exception ex)
            {
                mytransaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            tlStrpBttn_load_Click(sender, e);
           /* try
            {
                // oda.Update((DataTable)bd.DataSource);
                //cmdb = new OdbcCommandBuilder(oda);
                //this.uSER_CUSTTableAdapter.Update(this.dataSet1.USER_CUST);
                MessageBox.Show("Information updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void bttn1_Add_Click(object sender, EventArgs e)
        {
            int numRowsInsert = 0;
            comand = new OdbcCommand("{call INSERT_USER_CUST(?,?,?,?)}", con);
            comand.CommandType = CommandType.StoredProcedure;
            OdbcParameter names = comand.Parameters.Add("names", OdbcType.VarChar, 20);
            names.Direction = ParameterDirection.Input;
            OdbcParameter cardnumber = comand.Parameters.Add("cardnumber", OdbcType.Decimal);
            cardnumber.Direction = ParameterDirection.Input;
            OdbcParameter profit = comand.Parameters.Add("profit", OdbcType.Double);
            profit.Direction = ParameterDirection.Input;
            OdbcParameter count_currency = comand.Parameters.Add("count_currency", OdbcType.Double);
            count_currency.Direction = ParameterDirection.Input;

            //this.dtGrdVw_client.Columns[1].ValueType = typeof(Decimal);
            //names.Value = dtGrdVw_client.Columns[0].ToString();
            //cardnumber.Value = decimal.Parse(dtGrdVw_client.Columns[1].ToString());
            
            names.Value = txtBx_names.Text;
            cardnumber.Value = txtBx_card.Text;
            count_currency.Value = txtBx_amount.Text;
            profit.Value = txtBx_profit.Text;
            // make connection and execute procedure
            try
            {
                con.Open();
                mytransaction = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                comand.Transaction = mytransaction;
                numRowsInsert = comand.ExecuteNonQuery();
                mytransaction.Commit();
            }
            catch (Exception ex)
            {
                mytransaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            tlStrpBttn_load_Click(sender, e);
            //this.dtGrdVw_client.Rows.Add();
        }

        private void txtBx_names_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_profit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_amount_Validating(object sender, CancelEventArgs e)
        {
            if (txtBx_amount.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(txtBx_amount.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Enter correct value! Money can be only numbers and more or equal 0");
                    txtBx_amount.Clear();

                }
            }
        }

        private void txtBx_profit_Validating(object sender, CancelEventArgs e)
        {
            if (txtBx_profit.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(txtBx_profit.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Enter correct value! Money can be only numbers and more or equal 0");
                    txtBx_profit.Clear();

                }
            }
        }

        private void txtBx_card_Validating(object sender, CancelEventArgs e)
        {
            if (txtBx_card.Text != "")
            {
                decimal num2;
                bool isNum1 = decimal.TryParse(txtBx_card.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Enter correct value! Card number can be only numbers");
                    txtBx_card.Clear();

                }
            }
        }

        private void txtBx_del_client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_del_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_del_card_Validating(object sender, CancelEventArgs e)
        {
            if (txtBx_del_card.Text != "")
            {
                decimal num2;
                bool isNum1 = decimal.TryParse(txtBx_del_card.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Enter correct value! Card number can be only numbers");
                    txtBx_del_card.Clear();

                }
            }
        }

        private void bttn_del_Click(object sender, EventArgs e)
        {
            int numRowsInsert = 0;
            comand = new OdbcCommand("{call DELETE_USER_CUST(?,?)}", con);
            comand.CommandType = CommandType.StoredProcedure;
            OdbcParameter names = comand.Parameters.Add("names", OdbcType.VarChar, 20);
            names.Direction = ParameterDirection.Input;
            OdbcParameter cardnumber = comand.Parameters.Add("cardnumber", OdbcType.Decimal);
            cardnumber.Direction = ParameterDirection.Input;
            
            names.Value = txtBx_del_client.Text;
            cardnumber.Value = txtBx_del_card.Text;
            
            // make connection and execute procedure
            try
            {
                con.Open();
                mytransaction = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                comand.Transaction = mytransaction;
                numRowsInsert = comand.ExecuteNonQuery();
                mytransaction.Commit();
            }
            catch (Exception ex)
            {
                mytransaction.Rollback();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            tlStrpBttn_load_Click(sender, e);
        }

       
    }
}
