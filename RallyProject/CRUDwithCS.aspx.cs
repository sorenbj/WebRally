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
    public partial class CRUDwithCS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ButtonUpdate.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;

            }

            UpdateGridView();
        }

        private void UpdateGridView()
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = RallyDB");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlread = "select * from driver";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlread, conn);

                rdr = cmd.ExecuteReader();

                GridView1.DataSource = rdr;
                GridView1.DataBind();

                // SqlDataReader can only be used on

            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

            finally
            {
                conn.Close();
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = RallyDB");
            SqlCommand cmd = null;
            string sqlupd = "update Driver set name = @name, nationality = @nationality where IdDriver = @iddriver";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlupd, conn);

                cmd.Parameters.Add("@name", SqlDbType.Text);
                cmd.Parameters.Add("@nationality", SqlDbType.Text);
                cmd.Parameters.Add("@iddriver", SqlDbType.Int);

                cmd.Parameters["@name"].Value = TextBox1.Text;
                cmd.Parameters["@nationality"].Value = TextBox2.Text;
                cmd.Parameters["@iddriver"].Value = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

                cmd.ExecuteNonQuery();

                Label1.Text = "Driver has been updated";

                UpdateGridView();

                ButtonUpdate.Enabled = false;
                Button2.Enabled = true;
                Button3.Enabled = false;

            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

            finally
            {
                conn.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[3].Text;

            Label1.Text = "You selected driver " + GridView1.SelectedRow.Cells[1].Text;

            ButtonUpdate.Enabled = true;
            Button2.Enabled = false;
            Button3.Enabled = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ButtonUpdate.Enabled = false;
            Button2.Enabled = true;
            Button3.Enabled = false;

            Label1.Text = "No driver selected";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = RallyDB");
            SqlCommand cmd = null;
            string sqlins = "insert into Driver values (@name, @nationality)";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlins, conn);

                cmd.Parameters.Add("@name", SqlDbType.Text);
                cmd.Parameters.Add("@nationality", SqlDbType.Text);

                cmd.Parameters["@name"].Value = TextBox1.Text;
                cmd.Parameters["@nationality"].Value = TextBox2.Text;

                cmd.ExecuteNonQuery();

                Label1.Text = "Driver has been created";

                UpdateGridView();

            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

            finally
            {
                conn.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = RallyDB");
            SqlCommand cmd = null;
            string sqldel = "delete from Driver where IdDriver = @iddriver";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqldel, conn);

                cmd.Parameters.Add("@iddriver", SqlDbType.Int);

                cmd.Parameters["@iddriver"].Value = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

                cmd.ExecuteNonQuery();

                Label1.Text = "Driver has been deleted";

                UpdateGridView();

                ButtonUpdate.Enabled = false;
                Button2.Enabled = true;
                Button3.Enabled = false;

            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

            finally
            {
                conn.Close();
            }
        }
    }
}