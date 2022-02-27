using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
public partial class UpdateItem : System.Web.UI.Page
{
    localhost.Stock u = new localhost.Stock();
    localhost.Service s = new localhost.Service();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack == false)
        {
            GridView1.DataSource = s.ItemSearch(null);
            GridView1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        u.Pcode= pcode.Text;
        u.Pname = pname.Text;
        u.Pdescribe = pdescribe.Text;
        u.Pquantity = pquantity.Text;
        u.Pkind = DropDownList1.Text;
        if (pic.HasFile)
        {
            pic.SaveAs(Server.MapPath("mypics/") + pic.FileName);
            u.Ppic = pic.FileName;
        }
        else
        {
            string usern = pcode.Text;
            string picn = s.GetPicName(usern);
            u.Ppic = picn;
        }
        s.UpdateItem(u);
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "1;url=UpdateItem.aspx";
        this.Page.Controls.Add(meta);
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Item Updated succesfully, You will now be redirected in a few seconds" + "');", true);
        // Response.Redirect("UpdateItem.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        pcode.Text = row.Cells[1].Text;
        pname.Text = row.Cells[2].Text;
        pdescribe.Text = row.Cells[3].Text;
        pquantity.Text = row.Cells[4].Text;
        DropDownList1.Text = row.Cells[5].Text;
        string usern = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
        string picn = s.GetPicName(usern);
        img.ImageUrl = "~/mypics/" + picn;
    }

    protected void srch_Click(object sender, EventArgs e)
    {
        if(itemname.Text != "")
        {
            GridView1.DataSource = s.ItemSearch(itemname.Text);
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = s.ItemSearch(null);
            GridView1.DataBind();
        }
    }
}