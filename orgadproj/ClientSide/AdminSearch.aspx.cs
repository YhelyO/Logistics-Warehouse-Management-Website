using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class AdminSearch : System.Web.UI.Page
{
    localhost.Users u = new localhost.Users();
    localhost.Service s = new localhost.Service();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            GridView1.DataSource = s.AdminSearch("", 3);
            GridView1.DataBind();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        username.Text = row.Cells[1].Text;
        password.Text = row.Cells[2].Text;
        firstname.Text = row.Cells[3].Text;
        lastname.Text = row.Cells[4].Text;
        adress.Text = row.Cells[5].Text;
        city.Text = row.Cells[6].Text;
        phonenumber.Text = row.Cells[7].Text;
        email.Text = row.Cells[8].Text;
        
        job.Text = row.Cells[10].Text;
        gender.Text = row.Cells[11].Text;
        birthday.Text = row.Cells[12].Text;
        status.Text = row.Cells[13].Text;
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        if (use.Text != "")
        {
            if (drpby.SelectedIndex == 1)
            {

                GridView1.DataSource = s.AdminSearch(use.Text, 1);
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = s.AdminSearch(use.Text, 2);
                GridView1.DataBind();
            }

        }
        else
        {
            GridView1.DataSource = s.AdminSearch("", 3);

            GridView1.DataBind();
        }

    }
}