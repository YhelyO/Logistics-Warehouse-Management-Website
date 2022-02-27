using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewShiftByUser : System.Web.UI.Page
    
{
    localhost.Shift sh = new localhost.Shift();
    localhost.ShiftDetails shd = new localhost.ShiftDetails();
    localhost.Service s = new localhost.Service();
    private static DataTable dtuser;
    private static DataTable st = new DataTable();
    private static DataTable std = new DataTable();
    private static DataTable temptable;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtuser = (DataTable)Session["Client"];
        string name = dtuser.Rows[0][0].ToString();
        if (Page.IsPostBack == false)
        {
            st = s.ShiftAdminSearch(name);
            std = s.ShiftDetailsMemberSearch(name);
            
            for (int i=0; i<std.Rows.Count; i++)
            {
                string code = std.Rows[i][0].ToString();
                DataTable dt = s.ShiftSearch(code);
                st.Merge(dt);
            }
            
            GridView1.DataSource = st;
            GridView1.DataBind();
        }


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        string shiftcode = row.Cells[1].Text;
        temptable = s.GetMembersDetails(shiftcode);
        DataList2.DataSource = temptable;
        DataList2.DataBind();

    }

    protected void srch_Click(object sender, EventArgs e)
    {
        if (srchdate.Text != "")
        {
            GridView1.DataSource = s.ShiftSearchByDate(srchdate.Text);
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = s.ShiftSearchByDate(null);
            GridView1.DataBind();
        }
    }
}