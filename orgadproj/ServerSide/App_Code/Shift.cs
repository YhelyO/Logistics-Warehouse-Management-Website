using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Shift
/// </summary>
public class Shift
{
    public Shift()
    {
        //
        // TODO: Add constructor logic here
        //


    }
    private string shiftcode;

    public string ShiftCode
    {
        get { return shiftcode; }
        set { shiftcode = value; }
    }

    private string shiftkind;

    public string ShiftKind
    {
        get { return shiftkind; }
        set { shiftkind = value; }

    }
    private string shiftadmin;

    public string ShiftAdmin
    {
        get { return shiftadmin; }
        set { shiftadmin = value; }
    }
    private string shiftdate;

    public string ShiftDate
    {
        get { return shiftdate; }
        set { shiftdate = value; }
    }

}