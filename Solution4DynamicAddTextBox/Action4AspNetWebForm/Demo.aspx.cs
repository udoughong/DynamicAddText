using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Action4AspNetWebForm
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Ctl_count"] != null)
            {
                TextBox txb = new TextBox();
                txb.ID = "txt_1";
                Panel1.Controls.Add(txb);
                ViewState["Ctl_count"] = 1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox txb = new TextBox();
            txb.ID = "txt_1";
            Panel1.Controls.Add(txb);
            ViewState["Ctl_count"] = 1;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)Panel1.FindControl("txt_1");
            Label1.Text = txb.Text;
        }
    }
}