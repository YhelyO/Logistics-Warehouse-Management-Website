using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Orders
/// </summary>
public class Order
{
    public Order()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string ordercode;

    public string OrderCode
    {
        get { return ordercode; }
        set { ordercode = value; }
    }

    private string orderdate;

    public string OrderDate
    {
        get { return orderdate; }
        set { orderdate = value; }
    }
    private string orderhour;

    public string OrderHour
    {
        get { return orderhour; }
        set { orderhour = value; }
    }

    private string orusername;

    public string Orusername
    {
        get { return orusername; }
        set { orusername = value; }
    }

}