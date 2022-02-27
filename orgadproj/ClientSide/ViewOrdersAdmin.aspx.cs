using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewOrders : System.Web.UI.Page
{
    localhost.Service s = new localhost.Service();
    localhost.Order o = new localhost.Order();
    localhost.OrderDetails od = new localhost.OrderDetails();
    private static DataTable temptable;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            GridView1.DataSource = s.OrderSearch(null, 6);
            GridView1.DataBind();
        }
    }

    protected void search_Click(object sender, EventArgs e)
    {
        //code 1
        //user 2
        // date 3
        if (srchkey != null && srchkey.Text != "")
        {
            string choice = srchby.SelectedValue;
            GridView1.DataSource = s.OrderSearch(srchkey.Text, int.Parse(choice));
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = s.OrderSearch(null, 6);
            GridView1.DataBind();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        string ordercode = row.Cells[1].Text;
        temptable = s.GetProdDetails(ordercode);
        DataList1.DataSource = temptable;
        DataList1.DataBind();
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}