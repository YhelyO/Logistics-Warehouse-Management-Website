using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
public partial class UpdateShift : System.Web.UI.Page
{
    private static string codeshift = null;
    localhost.Shift sh = new localhost.Shift();
    localhost.ShiftDetails shd = new localhost.ShiftDetails();
    localhost.Service s = new localhost.Service();
    private static DataTable status = null;
    private static DataTable dtorder = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
           
            GridView1.DataSource = s.ShiftSearch(null);
             
            GridView1.DataBind();
            dtorder.Clear();
            if (dtorder.Columns.Count == 0)
            {

                DataColumn dc1 = new DataColumn();

                dc1.ColumnName = "shiftmembers";

                dtorder.Columns.Add(dc1);

            }

            DataList2.DataSource = s.GetAllUsers();
            DataList2.DataBind();
        }
        
      
        //DataList1.DataSource = s.GetAllUsers();
        //DataList1.DataBind();

    }


    string admin_name;
    int index;
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        shiftcode.Text = row.Cells[1].Text;
        codeshift = shiftcode.Text;
        DropDownList2.Text = row.Cells[2].Text;
        admin_name = row.Cells[3].Text;
        //  UpdateDataList2(admin_name);
        slctd_admin.Text = admin_name;
        shiftdate.SelectedDate = Convert.ToDateTime(row.Cells[4].Text);
        DataList1.DataSource = s.GetAllUsers();
        DataList1.DataBind();
        DataTable tblsrch = s.ShiftDetailsSearch(codeshift);
        grdorder.DataSource = tblsrch;
        grdorder.DataBind();
        for (int i = 0; i < tblsrch.Rows.Count; i++ )
        {
            DataRow Dr;
            Dr = dtorder.NewRow();

            Dr[0] = tblsrch.Rows[i][1].ToString();

            dtorder.Rows.Add(Dr);
        }
        status = s.ShiftDetailsSearch(codeshift);
        dprstatus.Text = status.Rows[0][2].ToString();
        //shiftdate.DisplayDate = Convert.ToDateTime(row.Cells[4].Text);

    }

    protected void UpdateDataList2(string admin_name)
    {
        //finding the index of the admin place in datalist2
        for (int i = 0; i < DataList2.Items.Count; i++)
        {
            string name = ((Label)DataList2.Items[i].FindControl("username")).Text;
            if (name == admin_name)
            {
                index = i;
            }

        }
        DataList2.EditItemIndex = index;

        //giving info
        DataList2.DataSource = s.GetAllUsers();
        DataList2.DataBind();

    }

    protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = DataList2.SelectedIndex;
        slctd_admin.Text = ((Label)DataList2.Items[i].FindControl("username")).Text;
    }


    protected void select_Click(object sender, EventArgs e)
    {
     //of datalist2 , doing problems
    }

    protected void grdorder_SelectedIndexChanged(object sender, EventArgs e)
    {
        int code = grdorder.SelectedIndex;

        dtorder.Rows.RemoveAt(code);

        grdorder.DataSource = dtorder;
        grdorder.DataBind();
    }


    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        int rownum = e.Item.ItemIndex;

        string usern = ((Label)DataList1.Items[rownum].FindControl("username")).Text;

        bool found = false;

        int mone = 0;
        if (dtorder.Rows.Count == 3)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Maximum of 3 members per shift" + "');", true);
            return;
        }
        if (dtorder.Rows.Count > 0)
        {
            while ((mone < dtorder.Rows.Count) && (found == false))
            {
                string numb = dtorder.Rows[mone][0].ToString();

                if (usern == numb)
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

        Dr[0] = usern;

        dtorder.Rows.Add(Dr);
        grdorder.DataSource = dtorder;

        grdorder.DataBind();
        }
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void updatebtn_Click(object sender, EventArgs e)
    {
        sh.ShiftAdmin = slctd_admin.Text;
        sh.ShiftCode = shiftcode.Text;
        sh.ShiftKind = DropDownList2.Text;
        sh.ShiftDate = shiftdate.SelectedDate.ToShortDateString();
        bool found1 = false;
        for (int j = 0; j < grdorder.Rows.Count; j++)
        {
            string name = grdorder.Rows[j].Cells[1].Text;
            if (slctd_admin.Text == name)
            {
                found1 = true;
            }
        }
        if (!found1)
        {
            s.UpdateShift(sh);
            shd.ShiftCode = sh.ShiftCode;
            shd.ShiftStatus = dprstatus.Text;
            for (int i = 0; i < grdorder.Rows.Count; i++)
            {
                string name = grdorder.Rows[i].Cells[1].Text;
                shd.ShiftMembers = name;
                s.AddShiftDetails(shd);
            }
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=AdminPage.aspx";
            this.Page.Controls.Add(meta);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Updated shift succesfully, You will now be redirected in a few seconds" + "');", true);
        }

        if (found1)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=UpdateShift.aspx";
            this.Page.Controls.Add(meta);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Admin cant be also a mamber, You will now be redirected in a few seconds" + "');", true);
        }
}

    protected void srch_Click(object sender, EventArgs e)
    {
        if (srchcode.Text != "")
        {
            GridView1.DataSource = s.ShiftSearch(srchcode.Text);
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = s.ShiftSearch(null);
            GridView1.DataBind();
        }
    }
}