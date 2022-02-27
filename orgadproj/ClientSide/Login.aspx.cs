using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
public partial class Login : System.Web.UI.Page
{
    localhost.Users u = new localhost.Users();
    localhost.Service s = new localhost.Service();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        u.Username = username.Text;
        u.Password = password.Text;
        DataTable dt = null;
        if (DropDownList1.SelectedValue == "2")
        {
            dt = s.UserLogin(u, 2);
        }
        else
        {
   
            dt = s.UserLogin(u, 1);

        }
        if (dt.Rows.Count != 0)
        {
            Session["client"] = dt;
            if (DropDownList1.SelectedValue == "2")
            {

                Session["status"] = "admin";
                Response.Redirect("AdminPage.aspx");
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "1;url=Home.aspx";
                this.Page.Controls.Add(meta);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Logged in succesfully, You will now be redirected in a few seconds" + "');", true);
            }
            else
            {
                Session["status"] = "user";
                Response.Redirect("UserHome.aspx");
                HtmlMeta meta = new HtmlMeta();
                meta.HttpEquiv = "Refresh";
                meta.Content = "1;url=Home.aspx";
                this.Page.Controls.Add(meta);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Logged in succesfully, You will now be redirected in a few seconds" + "');", true);
            }
        }
    }
}