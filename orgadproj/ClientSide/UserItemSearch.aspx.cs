using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class UserItemSearch : System.Web.UI.Page
{
    localhost.Order o = new localhost.Order();
    localhost.OrderDetails od = new localhost.OrderDetails();
    localhost.Service s = new localhost.Service();
    private DataTable dtuser;
    private static DataTable checkdt;

    private static DataTable dtorder = new DataTable();

    private static int choice = -1;

  //  private static double total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
    
        if(Page.IsPostBack == false)
        {
            dtorder.Clear(); //clear shopping cart
      //      total = 0;

            if (dtorder.Columns.Count == 0)
            {

                DataColumn dc1 = new DataColumn();

                dc1.ColumnName = "Order Code";

                dtorder.Columns.Add(dc1);

                DataColumn dc2 = new DataColumn();

                dc2.ColumnName = "Product Code";

                dtorder.Columns.Add(dc2);

                DataColumn dc3 = new DataColumn();

                dc3.ColumnName = "Quantity";

                dtorder.Columns.Add(dc3);

            }

            dtuser = (DataTable)Session["Client"];
            orderedbyuser.Text = dtuser.Rows[0][0].ToString();


            Random rnd = new Random();
            string odcode = rnd.Next(1, 1000000000).ToString();
            ordercode.Text = odcode;

            string date1 = DateTime.Now.Date.ToString();
            string[] temp = date1.Split();
            date.Text = temp[0];

            string time1 = DateTime.Now.TimeOfDay.ToString();
            string[] temp2 = time1.Split(':');
            orderhour.Text = temp2[0] + ":" + temp2[1];

            DataList1.DataSource = s.ItemSearch(null);
            DataList1.DataBind();
        }
    }

    protected void srchbtn_Click(object sender, EventArgs e)
    {
        if (srchpname.Text != "")
        {
            DataList1.DataSource = s.ItemSearch(srchpname.Text);
            DataList1.DataBind();
        }
        else
        {
            DataList1.DataSource = s.ItemSearch(null);
            DataList1.DataBind();
        }
    }

    protected void btnselect_Command(object sender, CommandEventArgs e)
    {
        int index = DataList1.SelectedIndex;
        DataList1.EditItemIndex = index;
        DataList1.DataSource = s.ItemSearch(null);
        DataList1.DataBind();
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = DataList1.SelectedIndex;
        DataList1.EditItemIndex = index;
        DataList1.DataSource = s.ItemSearch(null);
        DataList1.DataBind();
    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        string code = ordercode.Text;

        string prcode = ((Label)DataList1.Items[e.Item.ItemIndex].FindControl("pcode")).Text;

        int qua = int.Parse(((DropDownList)DataList1.Items[e.Item.ItemIndex].FindControl("dprqua")).Text);

   //     double intprice = double.Parse(price);
        bool found = false;

        int mone = 0;

        if (dtorder.Rows.Count > 0)
        {
            while ((mone < dtorder.Rows.Count) && (found == false))
            {
                string numb = dtorder.Rows[mone][1].ToString();

                if (code == numb)
                {

                    found = true;

                    int quaqua = int.Parse(dtorder.Rows[mone][2].ToString());

                    quaqua += qua;

                    dtorder.Rows[mone][1] = quaqua;
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

            Dr[1] = prcode;

            Dr[2] = qua;

            dtorder.Rows.Add(Dr);

        }
        //total += (qua * intprice);

        //LblSum.Text = total.ToString();

        grdorder.DataSource = dtorder;

        grdorder.DataBind();

        //DataList1.EditItemIndex = -1;

        //localhost.Service s = new localhost.Service();

        //DataTable dt = s.GetAllProductsByType(choice);

        //DataList1.DataSource = dt;

        //DataList1.DataBind();
    }

    protected void grdorder_SelectedIndexChanged(object sender, EventArgs e)
    {
        //delete from cart

        //double b = double.Parse(dtorder.Rows[grdorder.SelectedIndex][2].ToString()); //amount
        //int a = int.Parse(dtorder.Rows[grdorder.SelectedIndex][1].ToString()); //qua
        //double k = a * b;

        //total -= k;

        //total = Math.Round(total, 2);

        //if (k < 0)
        //    k = 0;

        //LblSum.Text = total.ToString();

        int code = grdorder.SelectedIndex;

        dtorder.Rows.RemoveAt(code);

        grdorder.DataSource = dtorder;
        grdorder.DataBind();
    }

    protected void ordrbtn_Click(object sender, EventArgs e)
    {
        //    int i = 0;
        //    bool found = false;

        //    while (i < grdorder.Rows.Count && found == false) // check quantity and update
        //    {
        //        string itemcode = grdorder.Rows[i].Cells[1].Text;
        //        string qua = grdorder.Rows[i].Cells[3].Text;
        //        checkdt = s.ItemSearchByCode(itemcode); //item search by code
        //        if (int.Parse(qua) > int.Parse(checkdt.Rows[0][2].ToString()))
        //        {
        //            found = true;
        //        }
        //        else
        //        {
        //            int remaining = int.Parse(checkdt.Rows[0][2].ToString()) - int.Parse(qua);
        //            s.UpdateQuantity(itemcode, remaining.ToString());
        //        }
        //        i++;
        //    }
        //    if (found == true)
        //    {
        //        //error message
        //        HtmlMeta meta = new HtmlMeta();
        //        meta.HttpEquiv = "Refresh";
        //        meta.Content = "1;url=UserItemSearch.aspx";
        //        this.Page.Controls.Add(meta);
        //        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " You Ordered Too Many Items" + "');", true);
        //    }
        //    else
        //    {
        //        o.OrderCode = ordercode.Text;
        //        o.OrderDate = date.Text;
        //        o.OrderHour = orderhour.Text;
        //        o.Orusername = orderedbyuser.Text;
        //        s.AddOrder(o);
        //        od.Orcode = ordercode.Text;
        //        for (int j = 0; j < grdorder.Rows.Count; j++)
        //        {
        //            string name = grdorder.Rows[j].Cells[1].Text;
        //            string qua = grdorder.Rows[j].Cells[3].Text;
        //            checkdt = s.ItemSearch(name);
        //            od.Prcode = checkdt.Rows[0][1].ToString();
        //            od.Prquantity = qua;
        //            s.AddOrderDetails(od);
        //        }
        //        HtmlMeta meta = new HtmlMeta();
        //        meta.HttpEquiv = "Refresh";
        //        meta.Content = "1;url=UserHome.aspx";
        //    this.Page.Controls.Add(meta);
        //    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Ordered succesfully, You will now be redirected in a few seconds" + "');", true);
        //}

    }

    protected void btn_Click(object sender, EventArgs e)
    {

    }

    protected void orderbtn_Click(object sender, EventArgs e)
    {
        int i = 0;
        bool found = false;

        while (i < grdorder.Rows.Count && found == false) // check quantity and update
        {
            string itemcode = grdorder.Rows[i].Cells[2].Text;
            string qua = grdorder.Rows[i].Cells[3].Text;
            checkdt = s.ItemSearchByCodeReal(itemcode); //item search by code
            if (int.Parse(qua) > int.Parse(checkdt.Rows[0][3].ToString()))
           {
              found = true;
           }
            else
            {
            int remaining = int.Parse(checkdt.Rows[0][3].ToString()) - int.Parse(qua);
               s.UpdateQuantity(checkdt.Rows[0][1].ToString(), remaining.ToString());
           }
            i++;
        } 
        if (found == true)
        {
            //error message
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=UserItemSearch.aspx";
            this.Page.Controls.Add(meta);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " You Ordered Too Many Items" + "');", true);
        } 
        else
       {
            o.OrderCode = ordercode.Text;
            o.OrderDate = date.Text;
            o.OrderHour = orderhour.Text;
            o.Orusername = orderedbyuser.Text;
            s.AddOrder(o);
            od.Orcode = ordercode.Text;
            for (int j = 0; j < grdorder.Rows.Count; j++)
            {
                od.Orcode= ordercode.Text;
                od.Prcode = dtorder.Rows[j][1].ToString();
                od.Prquantity = dtorder.Rows[j][2].ToString();
                s.AddOrderDetails(od);
            }
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "1;url=UserHome.aspx";
            this.Page.Controls.Add(meta);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Ordered succesfully, You will now be redirected in a few seconds" + "');", true);
       }
    }

}