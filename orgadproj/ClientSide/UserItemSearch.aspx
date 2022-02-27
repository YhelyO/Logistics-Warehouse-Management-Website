<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"  MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="UserItemSearch.aspx.cs" Inherits="UserItemSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

<%--    <script type="text/javascript">

    window.scrollTo = function( x,y ) 
    {
        return true;
    }
</script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
           <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>SEARCH AND ORDER ITEMS</h1></center> <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Order Code"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ordercode" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="date" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Time"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="orderhour" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="UserName:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="orderedbyuser" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button ID="srchbtn" runat="server" Text="Search: " OnClick="srchbtn_Click" />
            </td>
            <td>
                <asp:TextBox ID="srchpname" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="3" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnEditCommand="DataList1_EditCommand">
        <footerstyle backcolor="#99CCCC" forecolor="#003399" />
        <headerstyle backcolor="#003399" font-bold="True" forecolor="#CCCCFF" />
        <itemstyle backcolor="White" forecolor="#003399" />
        <ItemTemplate>
            <table cellspacing ="3">
                <tr>
                    <td>
                        
                        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="pname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pname") %>'></asp:Label>

                    </td>
                    <td rowspan ="2">
                        <asp:Image ID="ppic" runat="server" Height="89px" Width="84px" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"ppic","mypics/{0}") %>' />
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Code: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="pcode" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pcode") %>'></asp:Label>
                    </td>
                      </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Quantity: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="pquantity" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pquantity") %>'></asp:Label>
                    </td>
                       <td>
                        
                           <asp:Button ID="select" runat="server" Text="Select" CommandName="select"  />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <EditItemTemplate>
            <table>
                  <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Code: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="pcode" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pcode") %>'></asp:Label>
                    </td>
                      </tr>
                <tr>
                    <td>
                                <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
                    </td>
                    <td>
                      <asp:Label ID="pname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pname") %>'></asp:Label>
                    </td>

                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Quantity: "></asp:Label>
                    </td>
                     <td>
                         <asp:DropDownList ID="dprqua" runat="server">
                             <asp:ListItem>0</asp:ListItem>
                             <asp:ListItem>1</asp:ListItem>
                             <asp:ListItem>2</asp:ListItem>
                             <asp:ListItem>3</asp:ListItem>
                             <asp:ListItem>4</asp:ListItem>
                             <asp:ListItem>5</asp:ListItem>
                         </asp:DropDownList></td>
                     </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn" runat="server" Text="Add To Cart" CommandName="Edit" OnClick="btn_Click" /></td>
                </tr>
            </table>
        </EditItemTemplate>
        <selecteditemstyle backcolor="#009999" font-bold="True" forecolor="#CCFF99" />

    </asp:DataList>
    <asp:GridView ID="grdorder" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" EnableModelValidation="True" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="grdorder_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:CommandField ButtonType="Button" SelectText="Delete" ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    </asp:GridView>
    <asp:Button ID="orderbtn" runat="server" Text="Order" OnClick="orderbtn_Click" />
</asp:Content>

