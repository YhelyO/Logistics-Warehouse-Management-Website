<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminSearch.aspx.cs" Inherits="AdminSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:button runat="server" text="Search" OnClick="Unnamed1_Click" /> <asp:textbox ID="use" runat="server"></asp:textbox> <asp:dropdownlist ID="drpby" runat="server">
        <asp:ListItem Value="1">User Name</asp:ListItem>
        <asp:ListItem Value="2">First Name</asp:ListItem>
    </asp:dropdownlist>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField DataField="username" HeaderText="User Name" ReadOnly="True" />
            <asp:BoundField DataField="password" HeaderText="Password" ReadOnly="True" />
            <asp:BoundField DataField="firstname" HeaderText="First Name" ReadOnly="True" />
            <asp:BoundField DataField="lastname" HeaderText="Last Name" ReadOnly="True" />
            <asp:BoundField DataField="adress" HeaderText="Adress" ReadOnly="True" />
            <asp:BoundField DataField="city" HeaderText="City" ReadOnly="True" />
            <asp:BoundField DataField="phonenumber" HeaderText="Phone Number" ReadOnly="True" />
            <asp:BoundField DataField="email" HeaderText="Email" ReadOnly="True" />
            <asp:TemplateField HeaderText="Picture">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"pic","mypics/{0}") %>' Height="79px" Width="88px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="job" HeaderText="Job" ReadOnly="True" />
            <asp:BoundField DataField="gender" HeaderText="Gender" ReadOnly="True" />
            <asp:BoundField DataField="datebirth" HeaderText="Birthday" ReadOnly="True" />
            <asp:BoundField DataField="status" HeaderText="Status" ReadOnly="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>
     <table>
                        <tr>
                            <td><asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label></td>
                            <td><asp:TextBox ID="username" runat="server"  ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label></td>
                            <td><asp:TextBox ID="password" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        
                        <tr>
                            <td><asp:Label ID="Label3" runat="server" Text="First Name:"></asp:Label></td>
                            <td><asp:TextBox ID="firstname" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label4" runat="server" Text="Last Name:"></asp:Label></td>
                            <td><asp:TextBox ID="lastname" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label5" runat="server" Text="Adress:"></asp:Label></td>
                            <td><asp:TextBox ID="adress" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label6" runat="server" Text="City:"></asp:Label></td>
                            <td>
                                <asp:textbox ID="city" runat="server" ReadOnly="True"></asp:textbox>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label8" runat="server" Text="Phone Number:">
                                </asp:Label></td>
                                                
                            <td><asp:TextBox ID="phonenumber" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
   
                        <tr>
                            <td><asp:Label ID="Label9" runat="server" Text="Email:"></asp:Label></td>
                            <td><asp:TextBox ID="email" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
        
                        <tr>
                            <asp:Image ID="img" runat="server" Heigh="65px" Width="62px" />
                            <td><asp:Label ID="Label10" runat="server" Text="Picture:"></asp:Label></td>
                            <td><asp:FileUpload ID="pic" runat="server"></asp:FileUpload></td>
                            
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label11" runat="server" Text="Job:"></asp:Label></td>
                            <td>
                           <asp:textbox ID="job" runat="server" ReadOnly="True"></asp:textbox>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label12" runat="server" Text="Gender:"></asp:Label></td>
                            <td>
                           <asp:textbox ID="gender" runat="server" ReadOnly="True"></asp:textbox>
                      </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label13" runat="server" Text="Date Birth:"></asp:Label></td>
                            <td>
                                <asp:textbox ID="birthday" runat="server" ReadOnly="True"></asp:textbox>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label14" runat="server" Text="Status:"></asp:Label></td>
                            <td><asp:TextBox ID="status" runat="server" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                    </table>
</asp:Content>

