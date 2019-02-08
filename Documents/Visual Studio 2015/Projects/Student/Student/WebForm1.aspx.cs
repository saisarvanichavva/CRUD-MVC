using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Student
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        String StrSQL = "", StrConnection = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            StrSQL = "SELECT * FROM Student";
            StrConnection = " Data Source=PC025QWRF1D;Initial Catalog =Student ";
        }

        protected void Connected_Click(object sender, EventArgs e)
        {
            using (SqlConnection objConn = new SqlConnection(StrConnection))
            {
                SqlCommand objCmd = new SqlCommand(StrSQL, objConn);
                objCmd.CommandType = CommandType.Text;
                objConn.Open();
                SqlDataReader objDr = objCmd.ExecuteReader();
                GridView1.DataSource = objDr;
                GridView1.DataBind();
                objConn.Close();
            }
        }

        protected void Disconnected_Click(object sender, EventArgs e)
        {
            SqlDataAdapter objDa = new SqlDataAdapter();
            DataSet objDs = new DataSet();
            using (SqlConnection objConn = new SqlConnection(StrConnection))
            {
                SqlCommand objCmd = new SqlCommand(StrSQL, objConn);
                objCmd.CommandType = CommandType.Text;
                objDa.SelectCommand = objCmd;
                objDa.Fill(objDs, "Student");
                GridView1.DataSource = objDs.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}