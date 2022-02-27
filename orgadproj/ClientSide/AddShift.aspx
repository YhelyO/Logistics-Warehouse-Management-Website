<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddShift.aspx.cs" Inherits="AddShift" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>ADD Shift</h1></center>
    <table>
                 <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Shif Code:"></asp:Label>
            </td>
                    <td>
                          <asp:TextBox ID="shiftcode" runat="server"></asp:TextBox>
                        </td>

        </tr>

                 <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Shif Admin:"></asp:Label>
            </td>
                    <td>
                               <asp:DataList ID="DataList2" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="3" OnSelectedIndexChanged="DataList2_SelectedIndexChanged1" OnEditCommand="DataList2_EditCommand" >
        <footerstyle backcolor="#99CCCC" forecolor="#003399" />
        <headerstyle backcolor="#003399" font-bold="True" forecolor="#CCCCFF" />
        <itemstyle backcolor="White" forecolor="#003399" />
        <ItemTemplate>
            <table cellspacing ="3">
                <tr>
                    <td>
                        
                        <asp:Label ID="Label2" runat="server" Text="UserName: "></asp:Label>
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
                        <asp:Label ID="Label3" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="lastname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"lastname") %>'></asp:Label>
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
                        <asp:Label ID="Label7" runat="server" Text="UserName: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="username" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"username") %>'></asp:Label>
                    </td>
                      </tr>
                <tr>
                    <td>
                                <asp:Label ID="Label2" runat="server" Text="First Name: "></asp:Label>
                    </td>
                    <td>
                      <asp:Label ID="firstname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"firstname") %>'></asp:Label>
                    </td>

                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="lastname" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                 
                     </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn" runat="server" Text="Add To Shift" CommandName="Edit"/></td>
                </tr>
            </table>
        </EditItemTemplate>
        <selecteditemstyle backcolor="#009999" font-bold="True" forecolor="#CCFF99" />

    </asp:DataList>
                         

                        </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Shift Kind:"></asp:Label>
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
                <asp:Label ID="Label3" runat="server" Text="Shift Date:"></asp:Label>
            </td>
<td>
                                <asp:Calendar ID="shiftdate" runat="server"></asp:Calendar>
                            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Shift Status:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="on"/>
                    <asp:ListItem Text="of"/>
                </asp:DropDownList>

            </td>
        </tr>

         <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Shift Members:"></asp:Label>
            </td>
<td>
                              
                          
    
     <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" RepeatColumns="3" OnSelectedIndexChanged="DataList1_SelectedIndexChanged"  >
        <footerstyle backcolor="#99CCCC" forecolor="#003399" />
        <headerstyle backcolor="#003399" font-bold="True" forecolor="#CCCCFF" />
        <itemstyle backcolor="White" forecolor="#003399" />
        <ItemTemplate>
            <table cellspacing ="3">
                <tr>
                    <td>
                        
                        <asp:Label ID="Label2" runat="server" Text="UserName: "></asp:Label>
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
                        <asp:Label ID="Label3" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="lastname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"lastname") %>'></asp:Label>
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
                        <asp:Label ID="Label7" runat="server" Text="UserName: "></asp:Label>
                    </td>
                    <td>
                        
                        <asp:Label ID="username" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"username") %>'></asp:Label>
                    </td>
                      </tr>
                <tr>
                    <td>
                                <asp:Label ID="Label2" runat="server" Text="First Name: "></asp:Label>
                    </td>
                    <td>
                      <asp:Label ID="firstname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"firstname") %>'></asp:Label>
                    </td>

                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="lastname" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                 
                     </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn" runat="server" Text="Add To Shift" CommandName="Edit"  /></td>
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
        
          </td>
        </tr>

            </table>
    <asp:Button ID="shiftbtn" runat="server" Text="Set Shift" OnClick="shiftbtn_Click"  />
</asp:Content>

