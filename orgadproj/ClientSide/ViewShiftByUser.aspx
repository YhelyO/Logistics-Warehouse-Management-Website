<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewShiftByUser.aspx.cs" Inherits="ViewShiftByUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>UPDATE SHIFT</h1></center>

    <table>
       <tr>
           <td>
               <asp:Button ID="srch" runat="server" Text="search by date" OnClick="srch_Click" />
           </td>

        
           <td>
               <asp:TextBox ID="srchdate" runat="server"></asp:TextBox>
           </td>
          </tr>     
    </table>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" EnableModelValidation="True" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField DataField="shiftcode" HeaderText="Code" />
            <asp:BoundField DataField="shiftkind" HeaderText="Kind" />
            <asp:BoundField DataField="shiftadmin" HeaderText="Admin" />
            <asp:BoundField DataField="shiftdate" HeaderText="Date" />
            
           
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:Label ID="test" runat="server" Text="Label"></asp:Label>
                   <asp:DataList ID="DataList2" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="3">
        <footerstyle backcolor="#99CCCC" forecolor="#003399" />
        <headerstyle backcolor="#003399" font-bold="True" forecolor="#CCCCFF" />
        <itemstyle backcolor="White" forecolor="#003399" />
        <ItemTemplate>
            <table cellspacing ="3">
                <tr>
                    <td>
                        
                        <asp:Label ID="Label1" runat="server" Text="UserName: "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="username" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"username") %>'></asp:Label>

                    </td>
                    <td rowspan ="2">
                        <asp:Image ID="pic" runat="server" Height="89px" Width="84px" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"pic","mypics/{0}") %>' />
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="First Name: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="firstname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"firstname") %>'></asp:Label>
                    </td>
                      </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="lastname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"lastname") %>'></asp:Label>
                    </td>
                       <td>
                        
                          <%-- <asp:Button ID="select" runat="server" Text="Select" CommandName="select" OnClick="select_Click" />--%>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <selecteditemstyle backcolor="#009999" font-bold="True" forecolor="#CCFF99" />

    </asp:DataList>
   
</asp:Content>

