using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string query = "select CountryId, CountryName from Countries";
                BindDropDownList(ddlCountries, query, "CountryName", "CountryId", "Select Country");
                ddlStates.Enabled = false;
                ddlCities.Enabled = false;
                ddlStates.Items.Insert(0, new ListItem("Select State", "0"));
                ddlCities.Items.Insert(0, new ListItem("Select City", "0"));
            }

        }
        private void BindDropDownList(DropDownList ddl, string query, string text, string value, string defaultText)
        {
            string conString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    con.Open();
                    ddl.DataSource = cmd.ExecuteReader();
                    ddl.DataTextField = text;
                    ddl.DataValueField = value;
                    ddl.DataBind();
                    con.Close();
                }
            }
            ddl.Items.Insert(0, new ListItem(defaultText, "0"));
        }
        protected void Country_Changed(object sender, EventArgs e)
        {
            ddlStates.Enabled = false;
            ddlCities.Enabled = false;
            ddlStates.Items.Clear();
            ddlCities.Items.Clear();
            ddlStates.Items.Insert(0, new ListItem("Select State", "0"));
            ddlCities.Items.Insert(0, new ListItem("Select City", "0"));
            int countryId = int.Parse(ddlCountries.SelectedItem.Value);
            if (countryId > 0)
            {
                string query = string.Format("select StateId, StateName from States where CountryId = {0}", countryId);
                BindDropDownList(ddlStates, query, "StateName", "StateId", "Select State");
                ddlStates.Enabled = true;
            }
        }
        protected void State_Changed(object sender, EventArgs e)
        {
            ddlCities.Enabled = false;
            ddlCities.Items.Clear();
            ddlCities.Items.Insert(0, new ListItem("Select City", "0"));
            int stateId = int.Parse(ddlStates.SelectedItem.Value);
            if (stateId > 0)
            {
                string query = string.Format("select CityId, CityName from Cities where StateId = {0}", stateId);
                BindDropDownList(ddlCities, query, "CityName", "CityId", "Select City");
                ddlCities.Enabled = true;
            }
        }
    }
}