using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class CreateCompany : Form
    {
        string constr;

        #region Constructor
        public CreateCompany()
        {
            constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;

            InitializeComponent();
            CenterToScreen();

            //cmbCountry.SelectedIndex = -1;
            //cmbState.SelectedIndex = -1;
            //cmbCity.SelectedIndex = -1;

            //cmbState.Enabled = false;
            //cmbCity.Enabled = false;

            LoadCountriesSql();

            //if (cmbCountry.SelectedIndex == 0)
            //{
            //    LoadStatesForCountrySql(cmbCountry.SelectedIndex);
            //}
            //LoadStatesForCountrySql();
            //LoadCitiesFromStateSql();
            LoadDealerTypesSql();

            
            dtpFinancialYear.Value = Convert.ToDateTime("4/1/"+ DateTime.Now.Year.ToString());
            dtpBooksBegining.Value = Convert.ToDateTime("4/1/" + DateTime.Now.Year.ToString());
        }
        #endregion

        #region LoadCountriesSql
        public void LoadCountriesSql()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.ConnectionString = constr;
                con.Open();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CountryID");
                dataTable.Columns.Add("CountryName");
                
                string sqlCountries = "SELECT * FROM tblCountry";
                using (SqlCommand cmd = new SqlCommand(sqlCountries, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    DataRow row = dataTable.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dataTable.Rows.InsertAt(row, 0);
                }

                cmbCountry.DataSource = dataTable;
                cmbCountry.DisplayMember = "CountryName";
                cmbCountry.ValueMember = "CountryID";
            }

        }
        #endregion

        #region LoadStatesForCountrySql
        public void LoadStatesForCountrySql(int cId)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.ConnectionString = constr;
                con.Open();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("StateID");
                dataTable.Columns.Add("StateName");

                string cmdstr = "select * from tblState where CountryID = @countryID";
                using (SqlCommand cmd = new SqlCommand(cmdstr, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@countryID", cId));
             
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    DataRow row = dataTable.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dataTable.Rows.InsertAt(row, 0);
                }

                cmbState.DataSource = dataTable;
                cmbState.DisplayMember = "StateName";
                cmbState.ValueMember = "StateID";
            }
        }
        #endregion
        
        #region LoadCitiesFromStateSql
        public void LoadCitiesFromStateSql(int cId, int sId)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.ConnectionString = constr;
                con.Open();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CityID");
                dataTable.Columns.Add("CityName");

                string cmdstr = "select * from tblCity where CountryID = @countryID and StateID = @stateID";
                using (SqlCommand cmd = new SqlCommand(cmdstr, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@countryID", cId));
                    cmd.Parameters.Add(new SqlParameter("@stateID", sId));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dataTable);
                    //DataRow row = dataTable.NewRow();
                    //row[0] = 0;
                    //row[1] = "Please select";
                    //dataTable.Rows.InsertAt(row, 0);
                }

                cmbCity.DataSource = dataTable;
                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityID";
            }
        }
        #endregion

        #region LoadDealerTypesSql
        public void LoadDealerTypesSql()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.ConnectionString = constr;
                con.Open();

                DataTable dataTable = new DataTable();

                string cmdstr = "select * from tblDealerType";
                using (SqlCommand cmd = new SqlCommand(cmdstr, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }

                cmbDealerType.DataSource = dataTable;
                cmbDealerType.DisplayMember = "DealerTypeName";
                cmbDealerType.ValueMember = "DealerTypeID";
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //int compid = 3;
                //string con = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;
                //Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(con);
                //DbCommand dbCommand = db.GetStoredProcCommand("spAddCompany");
                //dbCommand.CommandType = CommandType.StoredProcedure;

                //db.AddInParameter(dbCommand, "@companyID", DbType.Int32, compid + 5);
                //db.AddInParameter(dbCommand, "@compnayName", DbType.String, txtCompanyName.Text);
                //db.AddInParameter(dbCommand, "@address", DbType.String, txtAddress1.Text + " " +txtAddress2.Text +" "+ txtAddress3.Text);
                //db.AddInParameter(dbCommand, "@pin", DbType.String, txtPIN.Text);
                //db.AddInParameter(dbCommand, "@city", DbType.String, cmbCity.SelectedValue);
                //db.AddInParameter(dbCommand, "@state", DbType.String, cmbState.SelectedValue);
                //db.AddInParameter(dbCommand, "@country", DbType.String, cmbCountry.SelectedValue);
                //db.AddInParameter(dbCommand, "@phone", DbType.String, txtPhone.Text);
                //db.AddInParameter(dbCommand, "@mobile", DbType.String, txtMobile.Text);
                //db.AddInParameter(dbCommand, "@email", DbType.String, txtEmail.Text);
                //db.AddInParameter(dbCommand, "@website", DbType.String, txtWebsite.Text);
                //db.AddInParameter(dbCommand, "@pan", DbType.String, txtPAN.Text);
                //db.AddInParameter(dbCommand, "@dealerType", DbType.String, cmbDealerType.SelectedValue);
                //db.AddInParameter(dbCommand, "@gstin", DbType.String, txtGSTIN.Text);
                //db.AddInParameter(dbCommand, "@effectiveDate", DbType.DateTime, dtEffectiveDate.Value);
                //db.AddInParameter(dbCommand, "@financialYearFromDate", DbType.DateTime, dtEffectiveDate.Value);
                //db.AddInParameter(dbCommand, "@booksBeginingFromDate", DbType.DateTime, dtEffectiveDate.Value);

                //int result = db.ExecuteNonQuery(dbCommand);
                int result = 0;
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
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbState.Enabled = false;
            //cmbCity.Enabled = false;

            if (cmbCountry.SelectedIndex != -1)
            {
                int countryIndex = Convert.ToInt32(cmbCountry.SelectedValue);

                LoadStatesForCountrySql(countryIndex);
            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbCountry.DataSource = null;
            //cmbState.DataSource = null;

            //if (cmbState.SelectedValue.ToString() != null)
            //{
            //    int countryIndex = Convert.ToInt32(cmbCountry.SelectedValue);
            //    int stateIndex = Convert.ToInt32(cmbState.SelectedValue);

            //    LoadCitiesFromStateSql(countryIndex, stateIndex);
            //    //cmbState.Enabled = true;
            //}
        }
    }
}
