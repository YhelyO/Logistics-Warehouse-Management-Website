using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {


        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    private string GetDbPath()
    {
        return Server.MapPath("App_Data/Db.mdb");
    }

    [WebMethod]
    public void RegisterUser(Users u)
    {
        //רושמת משתמש חדש לאתר

        string sql = "INSERT INTO [Users] VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)";
        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = u.Username;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = u.Password;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = u.Firstname;
        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = u.Lastname;
        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.VarChar));
        cmd.Parameters["@p5"].Value = u.Adress;
        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.VarChar));
        cmd.Parameters["@p6"].Value = u.City;
        cmd.Parameters.Add(new OleDbParameter("@p7", OleDbType.VarChar));
        cmd.Parameters["@p7"].Value = u.Phonenumber;
        cmd.Parameters.Add(new OleDbParameter("@p8", OleDbType.VarChar));
        cmd.Parameters["@p8"].Value = u.Email;
        cmd.Parameters.Add(new OleDbParameter("@p9", OleDbType.VarChar));
        cmd.Parameters["@p9"].Value = u.Pic;
        cmd.Parameters.Add(new OleDbParameter("@p10", OleDbType.VarChar));
        cmd.Parameters["@p10"].Value = u.Job;
        cmd.Parameters.Add(new OleDbParameter("@p11", OleDbType.VarChar));
        cmd.Parameters["@p11"].Value = u.Gender;
        cmd.Parameters.Add(new OleDbParameter("@p12", OleDbType.VarChar));
        cmd.Parameters["@p12"].Value = u.Datebirth;
        cmd.Parameters.Add(new OleDbParameter("@p13", OleDbType.VarChar));
        cmd.Parameters["@p13"].Value = u.Status;
        Connect.TakeAction(cmd, GetDbPath());
    }


    [WebMethod]
    public DataTable UserLogin(Users u, int choice)
    {
        //מחברת משתמש רשום לאתר
        if (choice == 2)
        {
            string username = u.Username;
            string password = u.Password;
            string sql = "Select * from [Admin] where [username] = '" + username + "' and [password] = '" + password + "'";
            return Connect.DowonloadData(sql, "Admin", GetDbPath());
        }
        else
        {
            string username = u.Username;
            string password = u.Password;
            string sql = "Select * from [Users] where [username] = '" + username + "' and [password] = '" + password + "'";
            return Connect.DowonloadData(sql, "Users", GetDbPath());

        }


    }
    [WebMethod]

    public void UpdateUser(Users u)
    {
        //מעדכנת פרטי משתמש רשום
        string sql = "UPDATE [Users] SET [password]= @p1, [firstname] = @p2, [lastname]=@p3, [adress] = @p4, [city] = @p5, [phonenumber] = @p6, [email] = @p7, [pic] = @p8, [job] = @p9, [gender] = @p10, [datebirth] = @p11, [status] = @p12 WHERE [username] ='" + u.Username + "'";

        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = u.Password;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = u.Firstname;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = u.Lastname;
        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = u.Adress;
        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.VarChar));
        cmd.Parameters["@p5"].Value = u.City;
        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.VarChar));
        cmd.Parameters["@p6"].Value = u.Phonenumber;
        cmd.Parameters.Add(new OleDbParameter("@p7", OleDbType.VarChar));
        cmd.Parameters["@p7"].Value = u.Email;
        cmd.Parameters.Add(new OleDbParameter("@p8", OleDbType.VarChar));
        cmd.Parameters["@p8"].Value = u.Pic;
        cmd.Parameters.Add(new OleDbParameter("@p9", OleDbType.VarChar));
        cmd.Parameters["@p9"].Value = u.Job;
        cmd.Parameters.Add(new OleDbParameter("@p10", OleDbType.VarChar));
        cmd.Parameters["@p10"].Value = u.Gender;
        cmd.Parameters.Add(new OleDbParameter("@p11", OleDbType.VarChar));
        cmd.Parameters["@p11"].Value = u.Datebirth;
        cmd.Parameters.Add(new OleDbParameter("@p12", OleDbType.VarChar));
        cmd.Parameters["@p12"].Value = u.Status;
        Connect.TakeAction(cmd, GetDbPath());

    }

    [WebMethod]
    public DataTable AdminSearch(string user, int choice)
    {
        //מחפשת משתמשים באתר לפי שם משתמש ושם פרטי
        if (choice == 1)
        {
            string sql = "Select * from [Users] where [username]='" + user + "'";
            return Connect.DowonloadData(sql, "Users", GetDbPath());
        }

        else if (choice == 2)
        {
            string sql = "Select * from [Users] where [firstname]='" + user + "'";
            return Connect.DowonloadData(sql, "Users", GetDbPath());
        }
        else
        {
            string sql = "Select * from [Users]";
            return Connect.DowonloadData(sql, "Users", GetDbPath());
        }
    }

    [WebMethod]
    public bool IsExists(string num, string table, string toCheck) 
    {
        //בודקת אם ערך מסויים נמצא בטבלה מסויימת מחזירה ערך חיובי אם לא קיים ערך כזה
        string sql = "Select * from " + table + " where " + toCheck + " = '" + num + "'";
        DataTable dtuser = Connect.DowonloadData(sql, table, GetDbPath());
        if (dtuser.Rows.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    [WebMethod]
    public void AddItem(Stock u)
    { 
        //מוסיפה מוצר 
        string sql = "INSERT INTO [Stock] VALUES (@p1,@p2,@p3,@p4,@p5,@p6)";
        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = u.Pcode;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = u.Pname;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = u.Pdescribe;
        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = u.Pquantity;
        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.VarChar));
        cmd.Parameters["@p5"].Value = u.Pkind;
        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.VarChar));
        cmd.Parameters["@p6"].Value = u.Ppic;
        Connect.TakeAction(cmd, GetDbPath());
    }

    [WebMethod]
    public string GetPicName(string username)
    {
        //מוצאת תמונה של מוצר לפי הקוד שלו
        string sql = "Select * from [Stock] where [pcode] = '" + username + "'";
        DataTable dtuser = Connect.DowonloadData(sql, "Stock", GetDbPath());
        return dtuser.Rows[0][5].ToString();

    }
    [WebMethod]
    public void UpdateItem(Stock u)
    {
        //מעדכנת פרטי מוצר קיים 
        string sql = "UPDATE [Stock]  SET [pname]= @p1, [pdescribe] = @p2, [pquantity]=@p3, [pkind] = @p4, [ppic] = @p5 WHERE [pcode] ='" + u.Pcode + "'";
        OleDbCommand cmd = new OleDbCommand(sql);

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = u.Pname;

        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = u.Pdescribe;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = u.Pquantity;

        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = u.Pkind;

        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.VarChar));
        cmd.Parameters["@p5"].Value = u.Ppic;

        Connect.TakeAction(cmd, GetDbPath());
    }

    [WebMethod]
    public DataTable ItemSearch(string user)
    {
        //מחפשת מוצר לפי השם שלו
        if (user != null)
        {
            string sql = "Select * from [Stock] where [pname] = '" + user + "'";
            return Connect.DowonloadData(sql, "Stock", GetDbPath());
        }
        else
        {

            string sql = "Select * from [Stock]";
            return Connect.DowonloadData(sql, "Stock", GetDbPath());
        }

    }


    [WebMethod]
    public DataTable ItemSearchByCode(string user)
    {
      
        if (user != null)
        {
            string sql = "Select * from [Stock] where [pname] = '" + user + "'";
            return Connect.DowonloadData(sql, "Stock", GetDbPath());
        }
        else
        {

            string sql = "Select * from [Stock]";
            return Connect.DowonloadData(sql, "Stock", GetDbPath());
        }

    }

    [WebMethod]
    public DataTable ItemSearchByCodeReal(string user)
    {
        //מחפשת מוצר לפי הקוד שלו

        if (user != null)
        {
            string sql = "Select * from [Stock] where [pcode] = '" + user + "'";
            return Connect.DowonloadData(sql, "Stock", GetDbPath());
        }
        else
        {

            string sql = "Select * from [Stock]";
            return Connect.DowonloadData(sql, "Stock", GetDbPath());
        }

    }



    [WebMethod]
    public void AddOrder(Order o)
    {
        //מוסיפה הזמנת מוצרים
        string sql = "INSERT INTO [Order] VALUES (@p1,@p2,@p3,@p4)";
        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = o.OrderCode;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = o.OrderDate;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = o.OrderHour;
        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = o.Orusername;
        Connect.TakeAction(cmd, GetDbPath());
    }

    [WebMethod]
    public void AddOrderDetails(OrderDetails od)
    {
        //מוסיפה פרטי הזמנה של מוצרים
        string sql = "INSERT INTO [OrderDetails] VALUES (@p1,@p2,@p3)";
        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = od.Orcode;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = od.Prcode;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = od.Prquantity;
        Connect.TakeAction(cmd, GetDbPath());
    }
    [WebMethod]
    public void UpdateQuantity(string name, string qua)
    {
        //מעדכנת כמות מוצר לאחר שהוזמן
        string sql = "UPDATE [Stock] SET [pquantity] = @p1 WHERE [pname] = '" + name + "'";
        OleDbCommand cmd = new OleDbCommand(sql);

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = qua;
        Connect.TakeAction(cmd, GetDbPath());
    }
    [WebMethod]
    public DataTable OrderSearch(string srchkey, int choice)
    {
        //מחפשת הזמנה לפי קוד ,שם משתמש של המזמין, ותאריך 
        if (srchkey != null)
        {
            if (choice == 1)
            {
                string sql = "Select * from [Order] where [orcode] = '" + srchkey + "'";
                return Connect.DowonloadData(sql, "Order", GetDbPath());
            }
            else if (choice == 2)
            {
                string sql = "Select * from [Order] where [orusername] = '" + srchkey + "'";
                return Connect.DowonloadData(sql, "Order", GetDbPath());
            }
            else if (choice == 3)
            {
                string sql = "Select * from [Order] where [ordate] = '" + srchkey + "'";
                return Connect.DowonloadData(sql, "Order", GetDbPath());
            }
            else
            {
                string sql = "Select * from [Order]";
                return Connect.DowonloadData(sql, "Order", GetDbPath());
            }
        }
        else
        {

            string sql = "Select * from [Order]";
            return Connect.DowonloadData(sql, "Order", GetDbPath());
        }

    }
    [WebMethod]
    public DataTable GetProdDetails(string ordercode)
    {
        //מחזירה פרטי מוצרים שהוזמנו בהזמנה לפי הקוד שלה
        string sql = "SELECT OrderDetails.orcode, OrderDetails.prcode, OrderDetails.prquantity, Stock.ppic, Stock.pname FROM Stock INNER JOIN OrderDetails ON Stock.[pcode] = OrderDetails.[prcode] where OrderDetails.orcode ='" + ordercode + "'";
        DataTable dt = Connect.DowonloadData(sql, "Stock", GetDbPath());
        return dt;
    }

    [WebMethod]
    public void AddShift(Shift s)
    {
        //מוסיפה משמרת 
        string sql = "INSERT INTO [Shift] VALUES (@p1,@p2,@p3,@p4)";
        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = s.ShiftCode;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = s.ShiftKind;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = s.ShiftAdmin;
        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = s.ShiftDate;
        Connect.TakeAction(cmd, GetDbPath());
    }

    [WebMethod]
    public void AddShiftDetails(ShiftDetails sd)
    {
        //מוסיפה פרטי משמרת 
        string sql = "INSERT INTO [ShiftDetails] VALUES (@p1,@p2,@p3)";
        OleDbCommand cmd = new OleDbCommand(sql);
        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = sd.ShiftCode;
        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = sd.ShiftMembers;
        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = sd.ShiftStatus;
        Connect.TakeAction(cmd, GetDbPath());
    }

    [WebMethod]
    public DataTable GetAllUsers()
    {
        //מחזירה את כל פרטי כל הממשתמשים הרשומים באתר  
        string sql = "Select * from [Users]";
        return Connect.DowonloadData(sql, "Users", GetDbPath());

    }

    [WebMethod]
    public DataTable ShiftSearch(string code)
    {
        //מחפשת משמרת לפי הקוד שלה  
        if (code != null)
        {
            string sql = "Select * from [Shift] where [shiftcode] = '" + code + "'";
            return Connect.DowonloadData(sql, "Shift", GetDbPath());
        }
        else
        {

            string sql = "Select * from [Shift]";
            return Connect.DowonloadData(sql, "Shift", GetDbPath());
        }

    }

    [WebMethod]
    public DataTable ShiftSearchByDate(string code)
    {
        //מחפשת משמרת לפי התאריך שלה  
        if (code != null)
        {
            string sql = "Select * from [Shift] where [shiftdate] = '" + code + "'";
            return Connect.DowonloadData(sql, "Shift", GetDbPath());
        }
        else
        {
            string sql = "Select * from [Shift] where [shiftdate] = '" + null + "'";
            return Connect.DowonloadData(sql, "Shift", GetDbPath());
        }

    }

    [WebMethod]
    public DataTable ShiftDetailsSearch(string code)
    {
        //מחזירה פרטי משמרת שמתאימים לקוד מסויים 
        if (code != null)
        {
            string sql = "Select * from [ShiftDetails] where [shiftcode] = '" + code + "'";
            return Connect.DowonloadData(sql, "ShiftDetails", GetDbPath());
        }
        else
        {

            string sql = "Select * from [ShiftDetails]";
            return Connect.DowonloadData(sql, "ShiftDetails", GetDbPath());
        }

    }
    [WebMethod]
    public DataTable ShiftDetailsMemberSearch(string name)
    {
        //מחזירה פרטי משמרת שנמצא בה שם משתמש של חבר משמרת מסוים
        if (name != null)
        {
            string sql = "Select * from [ShiftDetails] where [shiftmembers] = '" + name + "'";
            return Connect.DowonloadData(sql, "ShiftDetails", GetDbPath());        
             
        }
        else
        {
            string sql = "Select * from [ShiftDetails]";
            return Connect.DowonloadData(sql, "ShiftDetails", GetDbPath());
        }

    }
    [WebMethod]
    public DataTable ShiftAdminSearch(string name)
    {
        //מחזירה משמרת שיש לה מנהל מסוים
        if (name != null)
        {

            string sql = "Select * from [Shift] where [shiftadmin] = '" + name + "'";
            DataTable admins = Connect.DowonloadData(sql, "Shift", GetDbPath());
            return admins;
        }
        else
        {
            string sql = "Select * from [Shift]";
            return Connect.DowonloadData(sql, "Shift", GetDbPath());
        }

    }



    [WebMethod]
    public void UpdateShift(Shift s)
    {
        //מעדכן משמרת
        // [shiftcode] = @ p1,
        string sql = "UPDATE [Shift]  SET [shiftkind] = @p1, [shiftadmin]=@p2, [shiftdate] = @p3 WHERE [shiftcode] ='" + s.ShiftCode + "'";
        OleDbCommand cmd = new OleDbCommand(sql);

       

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = s.ShiftKind;

        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = s.ShiftAdmin;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = s.ShiftDate;

        Connect.TakeAction(cmd, GetDbPath());

        DeleteShiftDetails(s.ShiftCode);
    }

    [WebMethod]
    public void DeleteShiftDetails(string code)
    {
        //מוחק פרטי משמרת לפי קוד משמרת מסוים 
        
        string sql = "DELETE FROM [ShiftDetails] WHERE [shiftcode]  ='" +  code + "'";
        Connect.TakeAction(new OleDbCommand(sql), GetDbPath());



    }

    [WebMethod]
    public DataTable GetMembersDetails(string shiftcode)
    {
        //מחזירה שם משתמש שם פרטי שם משפחה ותמונה של חברי משמרת במשמרת מסויימת לפי הקוד שלה
        string sql = "SELECT Users.username, Users.firstname, Users.lastname, Users.pic, ShiftDetails.shiftcode, ShiftDetails.shiftmembers FROM Users INNER JOIN ShiftDetails ON Users.[username] = ShiftDetails.[shiftmembers] where ShiftDetails.shiftcode ='" + shiftcode + "'";
        DataTable dt = Connect.DowonloadData(sql, "Users", GetDbPath());
        return dt;
    }

}
