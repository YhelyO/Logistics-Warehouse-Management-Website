<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>REGISTER</h1></center>
     <div class="section">
			
			<div class="container">
                    <table>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label></td>
                            <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>
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
                            <td><asp:Label ID="Label8" runat="server" Text="Phone Number:"></asp:Label></td>
                                               
                            <td>
                                <asp:DropDownList ID="kd" runat="server">
                                <asp:ListItem Text="+972"/>
                                <asp:ListItem Text="+1"/>
                                </asp:DropDownList>
                                <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox></td>
                        </tr>
   
                        <tr>
                            <td><asp:Label ID="Label9" runat="server" Text="Email:"></asp:Label></td>
                            <td><asp:TextBox ID="email" runat="server"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="ima slh alai" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label10" runat="server" Text="Picture:"></asp:Label></td>
                            <td><asp:FileUpload ID="pic" runat="server"></asp:FileUpload></td>
                            <td>
                            <asp:image ImageUrl="~/mypics/dfpic.jpg" ID="defpic"  runat="server" Height="82px" Width ="103px">
                            </asp:image>
                            </td>
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
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
			</div>
			
		</div>
</asp:Content>

