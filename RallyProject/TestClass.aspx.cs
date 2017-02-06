using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RallyProject
{
    public partial class TestClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Driver d1, d2;
            d1 = new Driver(1, "Superman", "USA");
            d2 = new Driver(2, "Also Superman", "Germany");
            ListBox1.Items.Add(d1.ToString());
            ListBox1.Items.Add(d2.ToString());
            ListBox1.Items.Add("");

            d1.Name = "Donald Duck";
            ListBox1.Items.Add("New name for driver " + d1.IdDriver + " is " + d1.Name);
        }
    }
}