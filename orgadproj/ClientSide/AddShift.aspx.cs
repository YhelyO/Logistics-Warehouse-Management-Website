using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class AddShift : System.Web.UI.Page
{
    private static DataTable checkdt = null;
    localhost.Service s = new localhost.Service();
    localhost.Shift sh = new localhost.Shift();
    localhost.ShiftDetails shd = new localhost.ShiftDetails();
    private static DataTable dtorder = new DataTable();
    private static String uname;
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
                if (s.IsExists(numid.ToString(), "[Shift]", "shiftcode"))
                {
                    finalnum = numid;
                    flag = false;
                }
            }
            shiftcode.Text = finalnum.ToString();
            DataList2.DataSource = s.GetAllUsers();
            DataList2.DataBind();
            DataList1.DataSource = s.GetAllUsers();
            DataList1.DataBind();
            dtorder.Clear();
            if (dtorder.Columns.Count == 0)
            {

                DataColumn dc1 = new DataColumn();

                dc1.ColumnName = "User Name";

                dtorder.Columns.Add(dc1);

                DataColumn dc2 = new DataColumn();

                dc2.ColumnName = "First Name";

                dtorder.Columns.Add(dc2);

                DataColumn dc3 = new DataColumn();

                dc3.ColumnName = "Last Name";

                dtorder.Columns.Add(dc3);

            }


        }
    }



    protected void DataList2_SelectedIndexChanged1(object sender, EventArgs e)
    {
        int index = DataList2.SelectedIndex;

        DataList2.EditItemIndex = index;

        DataList2.DataSource = s.GetAllUsers();
        DataList2.DataBind();

    }
    protected void DataList2_EditCommand(object source, DataListCommandEventArgs e)
    {
        string code = ((Label)DataList2.Items[e.Item.ItemIndex].FindControl("username")).Text;
        uname = code;
       
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = DataList1.SelectedIndex;
        string code = ((Label)DataList1.Items[index].FindControl("username")).Text;
        string fname= ((Label)DataList1.Items[index].FindControl("firstname")).Text;
        string lname = ((Label)DataList1.Items[index].FindControl("lastname")).Text;
        bool found = false;

        int mone = 0;
        if(dtorder.Rows.Count == 3)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Maximum of 3 members per shift" + "');", true);
            return;
    }
        if (dtorder.Rows.Count > 0)
        {
            while ((mone < dtorder.Rows.Count) && (found == false))
            {
                string numb = dtorder.Rows[mone][0].ToString();

                if (code == numb)
                {
                    found = true;
                }
                else
                    mone++;
            }

        }

        if (found == false)
        {
            DataRow Dr;

            Dr = dtorder.NewRow();

            Dr[0] = code;

            Dr[1] = fname;

            Dr[2] = lname;

            dtorder.Rows.Add(Dr);

        }

        grdorder.DataSource = dtorder;

        grdorder.DataBind();
    }
    protected void grdorder_SelectedIndexChanged(object sender, EventArgs e)
    {
        //delete from cart

        int code = grdorder.SelectedIndex;

        dtorder.Rows.RemoveAt(code);

        grdorder.DataSource = dtorder;
        grdorder.DataBind();
    }

    protected void shiftbtn_Click(object sender, EventArgs e)
    {
        bool found = false;
        sh.ShiftAdmin = uname;
        sh.ShiftCode = shiftcode.Text;
        sh.ShiftDate = shiftdate.SelectedDate.ToShortDateString(); ;
        sh.ShiftKind = DropDownList2.Text;
        // uname exists in grdorder as Http error reload page
        for (int j = 0; j < grdorder.Rows.Count; j++)
        {
            string name = grdorder.Rows[j].Cells[1].Text;
            if (uname == name)
            {
                found = true;
            }
        }
        if (!found)
        {
            s.AddShift(sh);
            shd.ShiftCode = sh.ShiftCode;
            shd.ShiftStatus = DropDownList1.Text;
            for (int j = 0; j < grdorder.Rows.Count; j++)
            {
                string name = grdorder.Rows[j].Cells[1].Text;
                shd.ShiftMembers = name;
                s.AddShiftDetails(shd);
            }
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=AdminPage.aspx";
            this.Page.Controls.Add(meta);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Added shift succesfully, You will now be redirected in a few seconds" + "');", true);
        }
        if (found)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=AddShift.aspx";
            this.Page.Controls.Add(meta);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Admin cant be also a mamber, You will now be redirected in a few seconds" + "');", true);
        }
    }
}

