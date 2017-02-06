using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace RallyProject
{
    public partial class UploadToFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshDropDown();
        }

        private void RefreshDropDown()
        {
            // remember selected item during postback
            string oldselection = DropDownListFiles.SelectedValue;

            DropDownListFiles.Items.Clear();
            string filename;
            string[] allmyfiles = Directory.GetFiles(Server.MapPath("~/Myfiles/"));

            for (int i = 0; i < allmyfiles.Length; i++)
            {
                filename = new FileInfo(allmyfiles[i]).Name;
                DropDownListFiles.Items.Add(filename);
                if (filename == oldselection) DropDownListFiles.SelectedIndex = i;
            }
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                if(TextBoxFileName.Text != "")
                {
                    if(TextBoxFileName.Text.Substring(0, 1) != " ")
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Myfiles/") + TextBoxFileName.Text);
                        TextBoxMessage.Text = FileUpload1.FileName + "; " + FileUpload1.PostedFile.ContentLength.ToString() + "; " + FileUpload1.PostedFile.ContentType;
                        RefreshDropDown();
                    }
                    else
                    {
                        TextBoxMessage.Text = "Initial space is not allowed";
                    }
                }
                else
                {
                    TextBoxMessage.Text = "New file name is missing";
                }
            }
            else
            {
                TextBoxMessage.Text = "Wrong filename";
            }
        }
    }
}