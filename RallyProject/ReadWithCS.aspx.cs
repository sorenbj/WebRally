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
    public partial class ReadWithCS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = RallyDB");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlread = "select * from driver where IdDriver = @IdDriver";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlread, conn);
                cmd.Parameters.Add("@IdDriver", SqlDbType.Int);
                cmd.Parameters["@IdDriver"].Value = Convert.ToInt32(TextBox1.Text);

                rdr = cmd.ExecuteReader();

                DetailsView1.DataSource = rdr;
                DetailsView1.DataBind();

                // SqlDataReader can only be used once
                // Close the reader and fill it again
                rdr.Close();
                rdr = cmd.ExecuteReader();
                rdr.Read();

                TextBox2.Text = rdr["Nationality"].ToString();

            }

            catch (Exception ex)
            {
                TextBox2.Text = ex.Message;
            }

            finally
            {
                conn.Close();
            }
        }
    }
}