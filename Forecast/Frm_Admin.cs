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
using System.Transactions;

namespace Forecast_Shcherbak
{
    public partial class Frm_Admin : Form
    {
        //OdbcConnection con = new OdbcConnection("Driver = {Microsoft ODBC for Oracle}; Dsn=mydb; uid=Group_finance; pwd=Group_finance");
        OdbcConnection con = new OdbcConnection("Driver = {Microsoft ODBC for Oracle}; Dsn=mydb; uid=Anastasiia_Shcherbak; pwd=nastya");
        OdbcDataAdapter oda;
        OdbcCommandBuilder cmdb;
        DataTable user_table;
        OdbcCommand comand;
        OdbcTransaction mytransaction;
        //BindingSource bd;
        public Frm_Admin()
        {
            
            InitializeComponent();
            
            this.Width = 614;
            this.Height= 395;
            this.pnl_add_admin.Visible = false;
            this.pnl_del.Visible = false;
        }

        private void makeforecastmenu(object sender, EventArgs e)
        {
            Frm_forecast fr3 = new Frm_forecast();
            fr3.ShowDialog();
            //Hide();
            
        }

      
        private void Frm_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_autorization fr = new Frm_autorization();
            fr.Show();
            Hide();
        }

        private void dtGrdVw_admin_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
           /* if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
               dtGrdVw_admin.Rows[e.RowIndex].ErrorText =
                    "Input data";
                e.Cancel = true;
            }*/
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_autorization fr4 = new Frm_autorization();
            this.Close();
            fr4.Show();
        }

        private void dtGrdVw_admin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           // if (this.dtGrdVw_admin.Columns[e.ColumnIndex].Name == "Current rate")
           // {
                //if (e.FormattedValue.Double() == Double)
                //{
                    //string stringValue = (string)e.Value;
                    //double num2=(double)e.Value;
                //bool isNum1 = double.TryParse(num2, out num2);
                //if (isNum1==false)
                //{
                 //   MessageBox.Show("Enter correct value!");
                   
               // }
                //}
            //}
           // else if (this.dtGrdVw_admin.Columns[e.ColumnIndex].Name == "Date of forecast")
           // {
                //DateTimePickerFormat(e);
           // }

        }

        private void FindClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_client fr1= new Frm_client();
            fr1.Show();
            Hide();
        }

        private void tlStrpBttn_add_Click(object sender, EventArgs e)
        {
            this.pnl_del.Visible = false;
            this.pnl_add_admin.Visible = true;
            this.Width = 888;
            this.Height = 395;
            //this.dtGrdVw_admin.Rows.Add();
        }

        private void tlStrpBttn2_del_Click(object sender, EventArgs e)
        {
            this.pnl_add_admin.Visible = false;
            this.pnl_del.Visible = true;
            this.Width = 888;
            this.Height = 395; 
            /*if (this.dtGrdVw_admin.SelectedRows.Count > 0)
            {
                dtGrdVw_admin.Rows.RemoveAt(this.dtGrdVw_admin.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Cannot delete the last row!");
            }  */
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.con.Open();
           // mytransaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
           // OdbcCommand cmd = new OdbcCommand("SELECT  database_of_obstacles.gv_factor_io,forecast_of_quotations.gc_create_date, forecast_of_quotations.currency_on_date,currency_type,cur_currency_type from forecast_of_quotations join obstacle_involves_forecast on forecast_of_quotations.gc_create_date= obstacle_involves_forecast.gc_create_date join database_of_obstacles on database_of_obstacles.gv_factor_io= obstacle_involves_forecast.gv_factor_io join forecast_has_currency_pair on forecast_of_quotations.gc_create_date= forecast_has_currency_pair.gc_create_date join currency_pair on forecast_has_currency_pair.gv_rate_currency=currency_pair.gv_rate_currency;", con);
            //oda = new OdbcDataAdapter("SELECT  Group_finance.database_of_obstacles.gv_factor_io,Group_finance.forecast_of_quotations.gc_create_date, Group_finance.forecast_of_quotations.currency_on_date,currency_type,cur_currency_type from Group_finance.forecast_of_quotations join Group_finance.obstacle_involves_forecast on Group_finance.forecast_of_quotations.gc_create_date= Group_finance.obstacle_involves_forecast.gc_create_date join Group_finance.database_of_obstacles on Group_finance.database_of_obstacles.gv_factor_io= Group_finance.obstacle_involves_forecast.gv_factor_io join Group_finance.forecast_has_currency_pair on Group_finance.forecast_of_quotations.gc_create_date= Group_finance.forecast_has_currency_pair.gc_create_date join Group_finance.currency_pair on Group_finance.forecast_has_currency_pair.gv_rate_currency=Group_finance.currency_pair.gv_rate_currency;", con);
           oda = new OdbcDataAdapter("SELECT  database_of_obstacles.gv_factor_io,forecast_of_quotations.gc_create_date, forecast_of_quotations.currency_on_date,currency_type,cur_currency_type from forecast_of_quotations join obstacle_involves_forecast on forecast_of_quotations.gc_create_date= obstacle_involves_forecast.gc_create_date join database_of_obstacles on database_of_obstacles.gv_factor_io= obstacle_involves_forecast.gv_factor_io join forecast_has_currency_pair on forecast_of_quotations.gc_create_date= forecast_has_currency_pair.gc_create_date join currency_pair on forecast_has_currency_pair.gv_rate_currency=currency_pair.gv_rate_currency;", con);
            //mySelectCommand.Transaction = mytransaction;
            //oda.SelectCommand = mySelectCommand;
            //DataSet dt = new DataSet();
            //oda.Fill(dt);
            //oda = new OdbcDataAdapter(cmd);
           // oda.UpdateCommand.Transaction = mytransaction;
           // oda.DeleteCommand.Transaction = mytransaction;
           // oda.InsertCommand.Transaction = mytransaction;
            BindingSource bd = new BindingSource();
             user_table = new DataTable();
            
                 oda.Fill(user_table);
                 
                 bd.DataSource = user_table;
                 dtGrdVw_admin.DataSource = bd;
             
            con.Close();
        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.FORECAST_OF_QUOTATIONS' table. You can move, or remove it, as needed.
            //this.fORECAST_OF_QUOTATIONSTableAdapter.Fill(this.dataSet1.FORECAST_OF_QUOTATIONS);
            // TODO: This line of code loads data into the 'dataSet1.DATABASE_OF_OBSTACLES' table. You can move, or remove it, as needed.
            //this.dATABASE_OF_OBSTACLESTableAdapter.Fill(this.dataSet1.DATABASE_OF_OBSTACLES);
            // TODO: This line of code loads data into the 'dataSet1.CURRENCY_PAIR' table. You can move, or remove it, as needed.
            //this.cURRENCY_PAIRTableAdapter.Fill(this.dataSet1.CURRENCY_PAIR);
           
        }

        private void tlStrpBttn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int numRowsInsert = 0;
                comand = new OdbcCommand("{call UPDATE_ADMIN_PAGE(?,?,?)}", con);
                comand.CommandType = CommandType.StoredProcedure;
                OdbcParameter factor = comand.Parameters.Add("factor", OdbcType.VarChar, 20);
                factor.Direction = ParameterDirection.Input;
                OdbcParameter price = comand.Parameters.Add("price", OdbcType.Double);
                price.Direction = ParameterDirection.Input;
                OdbcParameter dates = comand.Parameters.Add("dates", OdbcType.Date);
                dates.Direction = ParameterDirection.Input;

                //this.dtGrdVw_client.Columns[1].ValueType = typeof(Decimal);
                //names.Value = dtGrdVw_client.Columns[0].ToString();
                //cardnumber.Value = decimal.Parse(dtGrdVw_client.Columns[1].ToString());

                factor.Value = dtGrdVw_admin.CurrentRow.Cells[4].Value;
                price.Value = dtGrdVw_admin.CurrentRow.Cells[3].Value;
                //amount.Value = dtGrdVw_client.CurrentRow.Cells[2].Value;
                //DateTime date = DateTime.ParseExact(, "dd.MM.yyyy", null);

                //dates = DateTime.Parse(dtGrdVw_admin.CurrentRow.Cells[2].FormattedValue.ToString());
                dates.Value = DateTime.Parse(dtGrdVw_admin.CurrentRow.Cells[2].FormattedValue.ToString());
                //    dtGrdVw_admin.CurrentRow.Cells[2].Value;
                // make connection and execute procedure
                try
                {
                    con.Open();                   
                    numRowsInsert = comand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                loadDataToolStripMenuItem_Click(sender, e);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            int numRowsInsert = 0;
            comand = new OdbcCommand("{call INSERT_ADMIN_PAGE(?,?,?,?,?)}", con);
            comand.CommandType = CommandType.StoredProcedure;
            OdbcParameter  cur1= comand.Parameters.Add("cur1", OdbcType.VarChar, 20);
            cur1.Direction = ParameterDirection.Input;
            OdbcParameter cur2 = comand.Parameters.Add("cur2", OdbcType.VarChar, 20);
            cur2.Direction = ParameterDirection.Input;
            OdbcParameter dates = comand.Parameters.Add("dates", OdbcType.Date);
            dates.Direction = ParameterDirection.Input;
            OdbcParameter price = comand.Parameters.Add("price", OdbcType.Double);
            price.Direction = ParameterDirection.Input;
            OdbcParameter factor = comand.Parameters.Add("factor", OdbcType.VarChar, 20);
            factor.Direction = ParameterDirection.Input;

            cur1.Value = cmbBx_cur1.SelectedItem.ToString();
            cur2.Value = cmbBx_cur2.SelectedItem.ToString();
            DateTime datetime = dateTimePicker1.Value;
            dates.Value = datetime;
            price.Value = txtBx_price.Text;
            factor.Value = txtBx_factor.Text;
            
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
                MessageBox.Show("The date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            loadDataToolStripMenuItem_Click(sender, e);
        }

        private void txtBx_del_price_Validating(object sender, CancelEventArgs e)
        {
            if (txtBx_del_price.Text != "")
            {
                double num2;
                bool isNum1 = double.TryParse(txtBx_del_price.Text, out num2);
                if ((isNum1 == false) || (num2 < 0))
                {
                    MessageBox.Show("Enter correct value! Money can be only numbers and more or equal 0");
                    txtBx_del_price.Clear();

                }
            }
        }

        private void bttn_del_Click(object sender, EventArgs e)
        {
            int numRowsInsert = 0;
            comand = new OdbcCommand("{call DELETE_ADMIN_PAGE(?,?)}", con);
            comand.CommandType = CommandType.StoredProcedure;
            OdbcParameter dates = comand.Parameters.Add("dates", OdbcType.Date);
            dates.Direction = ParameterDirection.Input;
            OdbcParameter price = comand.Parameters.Add("price", OdbcType.Double);
            price.Direction = ParameterDirection.Input;
            DateTime datetime1 = dateTimePicker2.Value;
            dates.Value = datetime1;
            price.Value = txtBx_del_price.Text;
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
                MessageBox.Show("Enter correct date or price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            loadDataToolStripMenuItem_Click(sender, e);
        }

        private void txtBx_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

        private void txtBx_factor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == ':')
                e.Handled = true;
        }

      
      
    }
}
