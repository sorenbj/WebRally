using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace RallyProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = RallyDB");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                // Normally the id of the chosen item should come from the database
                cmd = new SqlCommand("SELECT * FROM RallyTeam WHERE IdTeam = 3", conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();

                MainImage.ImageUrl = "~/Pictures/" + rdr["Car"].ToString();
                MainText.Text = rdr["Name"].ToString();

                // Reader must be closed if more SQL statements will be executed
                rdr.Close();
            }
            catch (Exception ex)
            {
                MainText.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}