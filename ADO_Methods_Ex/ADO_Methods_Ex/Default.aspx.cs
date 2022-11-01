using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_Methods_Ex
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDevice_Click(object sender, EventArgs e)
        {
            string db = ConfigurationManager.ConnectionStrings["dbSample"].ConnectionString;
            using (SqlConnection con = new SqlConnection(db))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "INSERT INTO tblDevice VALUES('OnePlus', 'OP 9R', 59000)";
                int rowsInserted = cmd.ExecuteNonQuery();
                Label1.Text = "Rows Inserted : " + rowsInserted.ToString();

                cmd.CommandText = "UPDATE tblDevice SET DevicePrice = 78999 WHERE DeviceID = 5";
                int rowsUpdated = cmd.ExecuteNonQuery();
                Label2.Text = "Rows Updated : " + rowsUpdated.ToString();

                cmd.CommandText = "DELETE FROM tblDevice WHERE DeviceID = 9";
                int rowsDeleted = cmd.ExecuteNonQuery();
                Label3.Text = "Rows Deleted : " + rowsDeleted.ToString();

            }
        }
    }
}