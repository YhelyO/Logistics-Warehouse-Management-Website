using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{
  
    public Users()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string username;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    private string firstname;

    public string Firstname
    {
        get { return firstname; }
        set { firstname = value; }
    }

    private string lastname;

    public string Lastname
    {
        get { return lastname; }
        set { lastname = value; }
    }

    private string adress;

    public string Adress
    {
        get { return adress; }
        set { adress = value; }
    }

    private string city;

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    private string phonenumber;

    public string Phonenumber
    {
        get { return phonenumber; }
        set { phonenumber = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private string pic;

    public string Pic
    {
        get { return pic; }
        set { pic = value; }
    }

    private string job;

    public string Job
    {
        get { return job; }
        set { job = value; }
    }

    private string gender;

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    private string datebirth;

    public string Datebirth
    {
        get { return datebirth; }
        set { datebirth = value; }
    }

    private string status;

    public string Status
    {
        get { return status; }
        set { status = value; }
    }
}