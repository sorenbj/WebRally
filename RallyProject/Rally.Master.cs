using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RallyProject
{
    public partial class Rally : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Normally : get header/footer text and logo reference from database
            LabelHeader.Text = "Rallycars";
            ImageLogo.ImageUrl = "~/Pictures/Morgan.jpg";
            ImageLogo.Width = 50;
        }
    }
}