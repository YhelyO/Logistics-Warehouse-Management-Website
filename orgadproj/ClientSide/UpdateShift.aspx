<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateShift.aspx.cs" Inherits="UpdateShift" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        height: 42px;
    }
    .auto-style2 {
        height: 301px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>UPDATE SHIFT</h1></center>

    <table>
       <tr>
           <td>
               <asp:Button ID="srch" runat="server" Text="search by code" OnClick="srch_Click" />
           </td>

        
           <td>
               <asp:TextBox ID="srchcode" runat="server"></asp:TextBox>
           </td>
          </tr>     
    </table>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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

    

        <table>
                 <tr>
            <td class="auto-style1">
                <asp:Label ID="label6" runat="server" Text="Shif Code:"></asp:Label>
            </td>
                    <td class="auto-style1">
                          <asp:TextBox ID="shiftcode" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>

        </tr>

                 <tr>
                            <td> <asp:Label runat="server" Text="Selected Admin:" ID="Label22"></asp:Label>  </td>
                               <td>  <asp:Label ID="slctd_admin" runat="server" Text=""></asp:Label>     </td>
                          
                        </tr>

                 <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Shif Admin:"></asp:Label>
            </td>
                    <td class="auto-style2">
                               <asp:DataList ID="DataList2" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="3" OnSelectedIndexChanged="DataList2_SelectedIndexChanged">
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
                        
                           <asp:Button ID="select" runat="server" Text="Select" CommandName="select" OnClick="select_Click" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <selecteditemstyle backcolor="#009999" font-bold="True" forecolor="#CCFF99" />

    </asp:DataList>
                                              

                        </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Shift Kind:"></asp:Label>
            </td>
            <td>
                                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem Text="החזרה"/>
                    <asp:ListItem Text="הוצאה"/>
                </asp:DropDownList>

                
            </td>
        </tr>


         <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Shift Date:"></asp:Label>
            </td>
<td>
                                <asp:Calendar ID="shiftdate" runat="server"></asp:Calendar>
                            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Shift Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="dprstatus" runat="server">
                    <asp:ListItem Text="on"/>
                    <asp:ListItem Text="of"/>
                </asp:DropDownList>

            </td>
        </tr>

         <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Shift Members:"></asp:Label>
            </td>
<td>
                                     
    
     <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="3"  OnEditCommand="DataList1_EditCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" >
        <footerstyle backcolor="#99CCCC" forecolor="#003399" />
        <headerstyle backcolor="#003399" font-bold="True" forecolor="#CCCCFF" />
        <itemstyle backcolor="White" forecolor="#003399" />
        <ItemTemplate>
            <table cellspacing ="3">
                <tr>
                    <td>
                        
                        <asp:Label ID="Label16" runat="server" Text="UserName: "></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="username" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"username") %>'></asp:Label>

                    </td>
                    <td rowspan ="2">
                        <asp:Image ID="Image1" runat="server" Height="89px" Width="84px" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"pic","mypics/{0}") %>' />
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label18" runat="server" Text="First Name: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="Label19" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"firstname") %>'></asp:Label>
                    </td>
                      </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label20" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="Label21" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"lastname") %>'></asp:Label>
                    </td>
                       <td>
                        
                           <asp:Button ID="Button1" runat="server" Text="Add" CommandName="Edit"/>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
       

<%--        <selecteditemstyle backcolor="#009999" font-bold="True" forecolor="#CCFF99" />--%>

    </asp:DataList>
    <asp:GridView ID="grdorder" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" EnableModelValidation="True" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="grdorder_SelectedIndexChanged" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:CommandField ButtonType="Button" SelectText="Delete" ShowSelectButton="True" />
            <asp:BoundField DataField="shiftmembers" HeaderText="User Name" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    </asp:GridView>
        
          </td>
        </tr>
            <tr>
                <td>
                    </td>
                <td>   <asp:Button ID="updatebtn" runat="server" Text="Update Shift" OnClick="updatebtn_Click" /></td>
            </tr>
            </table>

</asp:Content>


