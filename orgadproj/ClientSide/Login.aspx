<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>LOGIN</h1></center>
    <table>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label></td>
                            <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></td>
                            <td class="auto-style1"><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
                        </tr>

                       <tr>
                            <td><asp:Label ID="Label3" runat="server" Text="Job:"></asp:Label></td>
                        <td> <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Text="Madrich" Value="1"/>  
                               <asp:ListItem Text="MahsanHooligans" Value="2"/>
                           </asp:DropDownList>
                            </td>  
                        </tr>

        </table>
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
    <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
    
</asp:Content>


