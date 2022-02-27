using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShiftDetails
/// </summary>
public class ShiftDetails
{
    public ShiftDetails()
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

    private string shiftmembers;

    public string ShiftMembers
    {
        get { return shiftmembers; }
        set { shiftmembers = value; }
    }

    private string shiftstatus;

    public string ShiftStatus
    {
        get { return shiftstatus; }
        set { shiftstatus = value; }
    }

}