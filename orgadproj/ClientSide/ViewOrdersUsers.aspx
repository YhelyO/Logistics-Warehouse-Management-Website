<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewOrdersUsers.aspx.cs" Inherits="ViewOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>VIEW ORDERS</h1></center>
       <center>
    <table>
        <tr>
            <td>
                <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" />
            </td>
            <td>
                <asp:TextBox ID="srchkey" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="srchby" runat="server">                 
                    <asp:ListItem Value="1">By Code</asp:ListItem> 
                    <asp:ListItem Value="3">By Date</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField DataField="orcode" HeaderText="Order Code" />
            <asp:BoundField DataField="ordate" HeaderText="Date" />
            <asp:BoundField DataField="orhour" HeaderText="Time" />
        
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

    </asp:GridView>
        <br />
        <br />
         <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="3">
        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <ItemTemplate>
            <table cellspacing="3">
                <tr>
                   <td class="auto-style1">
                       Order
                       <asp:Label ID="Label1" runat="server" Text="Code:"></asp:Label>

                   </td>
                      <td class="auto-style1">
                          <asp:Label ID="orcode" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"orcode") %>'></asp:Label>

                   </td>
                    <td rowspan ="4">
                          <asp:Image ID="Image1" runat="server" Height="116px" Width="139px" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"ppic","mypics/{0}") %>' />
                    </td>
                </tr>
                  <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Name:"></asp:Label>
                   </td>
                      <td>
                          <asp:Label ID="pname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pname") %>'></asp:Label>
                   </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Quantity:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prquantity" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"prquantity") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Product Code:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prcode" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"prcode") %>'></asp:Label>
                    </td>
                </tr>
            </table>

        </ItemTemplate>
                 </asp:DataList>
        </center>
</asp:Content>

