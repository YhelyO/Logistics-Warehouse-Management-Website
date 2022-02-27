<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateUser.aspx.cs" Inherits="UpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 41px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
            <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>UPDATE USER </h1></center>  <table>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label></td>
                            <td><asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></td>
                            <td><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
                        </tr>
                        
                        <tr>
                            <td><asp:Label ID="Label3" runat="server" Text="First Name:"></asp:Label></td>
                            <td><asp:TextBox ID="firstname" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="Last Name:"></asp:Label></td>
                            <td><asp:TextBox ID="lastname" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label5" runat="server" Text="Adress:"></asp:Label></td>
                            <td><asp:TextBox ID="adress" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label6" runat="server" Text="City:"></asp:Label></td>
                            <td>
                            <asp:DropDownList ID="city" runat="server">
                                <asp:ListItem Text="Ramat Chen"/>
                                <asp:ListItem Text="Not Ramat Chen"/>  
                            </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label8" runat="server" Text="Phone Number:">
                                </asp:Label></td>
                                                <td><asp:DropDownList ID="DropDownList1" runat="server">
                               <asp:ListItem Text="+972"/>
                                <asp:ListItem Text="+1"/>
                        </asp:DropDownList> 
                            <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox></td>
                        </tr>
   
                        <tr>
                            <td class="auto-style1"><asp:Label ID="Label9" runat="server" Text="Email:"></asp:Label></td>
                            <td class="auto-style1"><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
                        </tr>
        
                        <tr>
                            <td><asp:Label ID="Label10" runat="server" Text="Picture:"></asp:Label></td>
                            <td><asp:Image ID="img" runat="server" Heigh="65px" Width="131px" Height="101px" /></td>
                            
                            <td><asp:FileUpload ID="pic" runat="server"></asp:FileUpload></td>
                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label12" runat="server" Text="Gender:"></asp:Label></td>
                            <td>
                            <asp:DropDownList ID="gender" runat="server">
                                <asp:ListItem Text="Male"/>
                                <asp:ListItem Text="Female"/>  
                            </asp:DropDownList>
                      </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label13" runat="server" Text="Date Birth:"></asp:Label></td>
                            <td>
                                <asp:Calendar ID="birthday" runat="server"></asp:Calendar>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label14" runat="server" Text="Status:"></asp:Label></td>
                            <td><asp:TextBox ID="status" runat="server"></asp:TextBox></td>
                        </tr>
                    </table>
                <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
</asp:Content>

