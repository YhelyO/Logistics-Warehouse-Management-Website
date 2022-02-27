using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class UpdateUser : System.Web.UI.Page
{
    localhost.Users u = new localhost.Users();
    localhost.Service s = new localhost.Service();
    private static DataTable dtuser;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            dtuser = (DataTable)Session["Client"];
            username.Text = dtuser.Rows[0][0].ToString();
            password.Text = dtuser.Rows[0][1].ToString();
            firstname.Text = dtuser.Rows[0][2].ToString();
            lastname.Text = dtuser.Rows[0][3].ToString();
            adress.Text = dtuser.Rows[0][4].ToString();
            city.Text = dtuser.Rows[0][5].ToString();

            email.Text = dtuser.Rows[0][7].ToString();
            img.ImageUrl= "`/mypics/" + dtuser.Rows[0][8].ToString();
            string[] arr = dtuser.Rows[0][6].ToString().Split('-');
            DropDownList1.Text = arr[0];
            phonenumber.Text = arr[1];         
            gender.Text = dtuser.Rows[0][10].ToString();
            birthday.SelectedDate=System.Convert.ToDateTime(dtuser.Rows[0][11].ToString());
            status.Text = dtuser.Rows[0][12].ToString();
          
        }
    }

    protected void username_TextChanged(object sender, EventArgs e)
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
        u.Phonenumber = DropDownList1.Text + '-' + phonenumber.Text;
        u.Email = email.Text;
        u.Pic = "g.jpg";
        if (pic.HasFile)
        {
            pic.SaveAs(Server.MapPath("mypics/") + pic.FileName);
            u.Pic = pic.FileName;
        }
        u.Job = "Madrich";
        u.Gender = gender.Text;
        u.Status = status.Text;
        u.Datebirth = birthday.SelectedDate.ToShortDateString();
        
        s.UpdateUser(u);
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "1;url=Home.aspx";
        this.Page.Controls.Add(meta);
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " User Updated succesfully, You will now be redirected in a few seconds" + "');", true);

    }
}