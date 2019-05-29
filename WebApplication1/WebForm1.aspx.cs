using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btn.Style.Add("visibility", "hidden");
                
            }

            if (IsPostBack && FileUpload1.PostedFile != null)
            {

                if (FileUpload1.PostedFile.FileName.Length > 0)
                {
                    btn.Style["visibility"] = "visible";
                }
                else
                {
                    btn.Style["visibility"] = "hidden";
                }

                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}