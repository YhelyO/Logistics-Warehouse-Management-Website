using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;


public partial class Register1 : System.Web.UI.Page
{
    localhost.Users u = new localhost.Users();
    localhost.Service s = new localhost.Service();

    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        u.Username = username.Text;
        u.Password = password.Text;
        u.Firstname = firstname.Text;
        u.Lastname = lastname.Text;
        u.Adress = adress.Text;
        u.City = city.Text;
        u.Phonenumber = kd.Text + '-' + phonenumber.Text;
        u.Email = email.Text;
        u.Pic = "g.jpg";
        if(pic.HasFile)
        {
            pic.SaveAs(Server.MapPath("mypics/") + pic.FileName);
            u.Pic = pic.FileName;
        }
        u.Job = "Madrich";
        u.Gender = gender.Text;
        u.Status = status.Text;
        u.Datebirth = birthday.SelectedDate.ToShortDateString();
        s.RegisterUser(u);
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "1;url=Login.aspx";
        this.Page.Controls.Add(meta);
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Registered succesfully, You will now be redirected in a few seconds" + "');", true);
    }
}