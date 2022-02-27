using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Client"] = null;
        Session["status"] = "disconnected";
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "1;url=Home.aspx";
        this.Page.Controls.Add(meta);
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Logout succesfully, You will now be redirected in a few seconds" + "');", true);
        //Response.Redirect("Home.aspx");
    }
}