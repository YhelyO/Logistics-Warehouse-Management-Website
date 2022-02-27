using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDetail
/// </summary>
public class OrderDetails
{
    public OrderDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string orcode;

    public string Orcode
    {
        get { return orcode; }
        set { orcode = value; }
    }
    private string prcode;

    public string Prcode
    {
        get { return prcode; }
        set { prcode = value; }
    }

    private string prquantity;

    public string Prquantity
    {
        get { return prquantity; }
        set { prquantity = value; }
    }

}