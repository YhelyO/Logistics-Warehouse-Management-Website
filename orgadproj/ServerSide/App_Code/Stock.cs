using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Stock
/// </summary>
public class Stock
{
    public Stock()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string pcode;

    public string Pcode
    {
        get { return pcode; }
        set { pcode = value; }
    }

    private string pname;

    public string Pname
    {
        get { return pname; }
        set { pname = value; }
    }

    private string pdescribe;

    public string Pdescribe
    {
        get { return pdescribe; }
        set { pdescribe = value; }
    }

    private string pquantity;

    public string Pquantity
    {
        get { return pquantity; }
        set { pquantity = value; }
    }

    private string pkind;

    public string Pkind
    {
        get { return pkind; }
        set { pkind = value; }
    }
    private string ppic;

    public  string Ppic
    {
        get { return ppic; }
        set { ppic = value; }
    }

}