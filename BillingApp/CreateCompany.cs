using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BillingApp
{
    public partial class CreateCompany : Form
    {
        public CreateCompany()
        {
            InitializeComponent();
            //Clipboard.Clear();
            CenterToScreen();
            //Load dropdowns for Country, State, City and DealerType
            LoadCountries();
            LoadStatesForCountry();
            LoadCitiesFromState();
            LoadDealerTypes();

            //default values for Financial starts from and Books begining from
            dtpFinancialYear.Value = Convert.ToDateTime("4/1/"+DateTime.Now.Year.ToString());
            dtpBooksBegining.Value = Convert.ToDateTime("4/1/" + DateTime.Now.Year.ToString());
            //MessageBox.Show(dtpFinancialYear.Value.ToString());
        }

        #region LoadCountries
        public void LoadCountries()
        {
            //string con = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
            //Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(con);
            //DbCommand dbCommand = db.GetStoredProcCommand("spGetCountries");
            //dbCommand.CommandType = CommandType.StoredProcedure;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand);
            //DataAdapter da  = db.ExecuteReader(dbCommand);
            //cmbCountry.DataSource = dr;


            //while (dr.Read())
            //{
            //    cmbCountry.Items.Add(dr["CountryName"]);
            //    cmbCountry.DataSource = dr;
            //}

            string constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblCountry", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Insert the Default Item to DataTable.
                    //DataRow row = dt.NewRow();
                    //row[0] = 0;
                    //row[1] = "Please select";
                    //dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource.
                    cmbCountry.DataSource = dt;
                    cmbCountry.DisplayMember = "CountryName";
                    cmbCountry.ValueMember = "CountryID";
                }
            }

        }
        #endregion

        #region LoadStatesForCountry
        public void LoadStatesForCountry()
        {
            int countryID =1;
            //string con = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
            //Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(con);
            //DbCommand dbCommand = db.GetStoredProcCommand("spGetStatesForCountry");
            //dbCommand.CommandType = CommandType.StoredProcedure;

            //db.AddInParameter(dbCommand, "@countryid", DbType.Int32, countryID);

            //IDataReader dr = db.ExecuteReader(dbCommand);
            //while (dr.Read())
            //{
            //    cmbCountry.Items.Add(dr["StateName"]);
            //}

            string constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string cmdstr = "select * from tblState where CountryID = 1";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.Add(new SqlParameter("@countryID", countryID));
                

               SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Assign DataTable as DataSource.
                cmbState.DataSource = dt;
                cmbState.DisplayMember = "StateName";
                cmbState.ValueMember = "StateID";
                
            }
        }
        #endregion

        #region LoadCities
        public void LoadCitiesFromState()
        {
            int stateID = 1;

            string constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string cmdstr = "select * from tblCity where StateID = 1";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.Add(new SqlParameter("@stateID", stateID));


                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Assign DataTable as DataSource.
                cmbCity.DataSource = dt;
                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityID";

            }
        }
        #endregion

        #region LoadDealerTypes
        public void LoadDealerTypes()
        {
            //int stateID = 1;

            string constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string cmdstr = "select * from tblDealerType";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                //cmd.Parameters.Add(new SqlParameter("@stateID", stateID));


                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Assign DataTable as DataSource.
                cmbDealerType.DataSource = dt;
                cmbDealerType.DisplayMember = "DealerTypeName";
                cmbDealerType.ValueMember = "DealerTypeID";
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int compid = 3;
                string con = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
                Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(con);
                DbCommand dbCommand = db.GetStoredProcCommand("spAddCompany");
                dbCommand.CommandType = CommandType.StoredProcedure;

                db.AddInParameter(dbCommand, "@companyID", DbType.Int32, compid+1);
                db.AddInParameter(dbCommand, "@compnayName", DbType.String, txtCompanyName.Text);
                db.AddInParameter(dbCommand, "@address", DbType.String, txtAddress1.Text + " " +txtAddress2.Text +" "+ txtAddress3.Text);
                db.AddInParameter(dbCommand, "@pin", DbType.String, txtPIN.Text);
                db.AddInParameter(dbCommand, "@city", DbType.String, cmbCity.SelectedValue);
                db.AddInParameter(dbCommand, "@state", DbType.String, cmbState.SelectedValue);
                db.AddInParameter(dbCommand, "@country", DbType.String, cmbCountry.SelectedValue);
                db.AddInParameter(dbCommand, "@phone", DbType.String, txtPhone.Text);
                db.AddInParameter(dbCommand, "@mobile", DbType.String, txtMobile.Text);
                db.AddInParameter(dbCommand, "@email", DbType.String, txtEmail.Text);
                db.AddInParameter(dbCommand, "@website", DbType.String, txtWebsite.Text);
                db.AddInParameter(dbCommand, "@pan", DbType.String, txtPAN.Text);
                db.AddInParameter(dbCommand, "@dealerType", DbType.String, cmbDealerType.SelectedValue);
                db.AddInParameter(dbCommand, "@gstin", DbType.String, txtGSTIN.Text);
                db.AddInParameter(dbCommand, "@effectiveDate", DbType.DateTime, dtEffectiveDate.Value);
                db.AddInParameter(dbCommand, "@financialYearFromDate", DbType.DateTime, dtEffectiveDate.Value);
                db.AddInParameter(dbCommand, "@booksBeginingFromDate", DbType.DateTime, dtEffectiveDate.Value);

                int result = db.ExecuteNonQuery(dbCommand);
               if(result == 1)
                    MessageBox.Show("Company record inserted");

                this.Close();
               //TODO: Clear form after adding record
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //txtAddress1.Text = "";
            //txtAddress2.Text = "";
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadStatesForCountry(Convert.ToInt32(cmbCountry.SelectedValue));
        }

        private void cmbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbCountry.SelectedValue.ToString());
            //LoadStatesForCountry();
        }

        private void label15_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
