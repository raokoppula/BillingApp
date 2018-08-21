using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BillingApp
{
    public partial class AlterCompany : Form
    {
        string constr;

        #region Constructor
        public AlterCompany()
        {
            constr = ConfigurationManager.ConnectionStrings["conBillingApp"].ConnectionString;

            InitializeComponent();
            CenterToScreen();
            
            cmbState.Enabled = false;
            cmbCity.Enabled = false;

            LoadCountriesSql();
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
                    DataRow row = dataTable.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dataTable.Rows.InsertAt(row, 0);
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
                dataTable.Columns.Add("DealerTypeID");
                dataTable.Columns.Add("DealerTypeName");

                string cmdstr = "select * from tblDealerType";
                using (SqlCommand cmd = new SqlCommand(cmdstr, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    DataRow row = dataTable.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dataTable.Rows.InsertAt(row, 0);
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
                //int compid = 10;
                int result = 0;

                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.ConnectionString = constr;
                    con.Open();
                    
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spAddCompany";
                        cmd.Connection = con;

                        ///cmd.Parameters.Add("@companyID", SqlDbType.Int).Value = compid + 5;
                        cmd.Parameters.Add("@compnayName", SqlDbType.Text).Value = txtCompanyName.Text;
                        cmd.Parameters.Add("@address", SqlDbType.Text).Value = txtAddress1.Text + " " + txtAddress2.Text + " " + txtAddress3.Text;
                        cmd.Parameters.Add("@pin", SqlDbType.Text).Value = txtPIN.Text;
                        cmd.Parameters.Add("@city", SqlDbType.Int).Value = Convert.ToUInt32(cmbCity.SelectedValue);
                        cmd.Parameters.Add("@state", SqlDbType.Int).Value = Convert.ToUInt32(cmbState.SelectedValue);
                        cmd.Parameters.Add("@country", SqlDbType.Int).Value = Convert.ToUInt32(cmbCountry.SelectedValue);
                        cmd.Parameters.Add("@phone", SqlDbType.Text).Value = txtPhone.Text;
                        cmd.Parameters.Add("@mobile", SqlDbType.Text).Value = txtMobile.Text;
                        cmd.Parameters.Add("@email", SqlDbType.Text).Value = txtEmail.Text;
                        cmd.Parameters.Add("@website", SqlDbType.Text).Value = txtWebsite.Text;
                        cmd.Parameters.Add("@pan", SqlDbType.Text).Value = txtPAN.Text;
                        cmd.Parameters.Add("@dealerType", SqlDbType.Int).Value = Convert.ToUInt32(cmbDealerType.SelectedValue);
                        cmd.Parameters.Add("@gstin", SqlDbType.Text).Value = txtGSTIN.Text;
                        cmd.Parameters.Add("@effectiveDate", SqlDbType.DateTime).Value = dtEffectiveDate.Value;
                        cmd.Parameters.Add("@financialYearFromDate", SqlDbType.DateTime).Value = dtpFinancialYear.Value;
                        cmd.Parameters.Add("@booksBeginingFromDate", SqlDbType.DateTime).Value = dtpBooksBegining.Value;

                         result = cmd.ExecuteNonQuery();
                    }
                }
                 
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
            cmbState.Enabled = false;
            cmbCity.Enabled = false;

            if (cmbCountry.SelectedIndex != -1)
            {
                int countryIndex = cmbCountry.SelectedIndex;

                LoadStatesForCountrySql(countryIndex);
                cmbState.Enabled = true;
            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.SelectedValue.ToString() != null)
            {
                int countryIndex = cmbCountry.SelectedIndex;
                int stateIndex = cmbState.SelectedIndex;

                LoadCitiesFromStateSql(countryIndex, stateIndex);
                cmbCity.Enabled = true;
            }
        }

        private void txtGSTIN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rPan = new Regex(@"\d{2}[A-Z]{5}\d{4}[A-Z]{1}\d[Z]{1}[A-Z\d]{1}");

            if (txtGSTIN.Text.Length > 0)
            {
                if (!rPan.IsMatch(txtGSTIN.Text))
                {
                    errorProGST.SetError(txtGSTIN, "Invalid GSTIN Number");
                    txtGSTIN.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    errorProGST.Clear();
                }
            }
            else
            {
                errorProGST.Clear();
            }
        }

        private void txtPAN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rPan = new Regex(@"^([a-zA-Z]){5}([0-9]){4}([a-zA-Z]){1}?$");

            if (txtPAN.Text.Length > 0)
            {
                if (!rPan.IsMatch(txtPAN.Text))
                {
                    errorProPAN.SetError(txtPAN, "Invalid PAN Card Number");
                    txtPAN.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    errorProPAN.Clear();
                }
            }
            else
            {
                errorProPAN.Clear();
            }
        }
    }
}

