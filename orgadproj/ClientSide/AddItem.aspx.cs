using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class AddItem : System.Web.UI.Page
{

    localhost.Stock u = new localhost.Stock();
    localhost.Service s = new localhost.Service();
    protected void Page_Load(object sender, EventArgs e)
    {

        int finalnum = 0;
        bool flag = true;
        if (Page.IsPostBack == false)
        {
            while (flag == true)
            {
                Random rnd = new Random();
                int numid = rnd.Next(100, 1000000);
                if (s.IsExists(numid.ToString(), "[Stock]", "pcode"))
                {
                    finalnum = numid;
                    flag = false;
                }
            }
            pcode.Text = finalnum.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        u.Pcode = pcode.Text;
        u.Pname = pname.Text;
        u.Pdescribe = pdescribe.Text;
        u.Pquantity = pquantity.Text;
        u.Pkind = DropDownList1.Text;
        u.Ppic = "g.jpg";
        if (pic.HasFile)
        {
            pic.SaveAs(Server.MapPath("mypics/") + pic.FileName);
            u.Ppic = pic.FileName;
        }
        s.AddItem(u);
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "1;url=AdminPage.aspx";
        this.Page.Controls.Add(meta);
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Added Item succesfully, You will now be redirected in a few seconds" + "');", true);
        //Response.Redirect("AdminPage.aspx");
    }
}