<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateItem.aspx.cs" Inherits="UpdateItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>UPDATE ITEM</h1></center>
     <table>
       <tr>
           <td>
               <asp:Button ID="srch" runat="server" Text="search" OnClick="srch_Click" />
           </td>

        
           <td>
               <asp:TextBox ID="itemname" runat="server"></asp:TextBox>
           </td>
          </tr>     
    </table>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" EnableModelValidation="True" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:BoundField DataField="pcode" HeaderText="Code" />
            <asp:BoundField DataField="pname" HeaderText="Name" />
            <asp:BoundField DataField="pdescribe" HeaderText="Describe" />
            <asp:BoundField DataField="pquantity" HeaderText="Quantity" />
            <asp:BoundField DataField="pkind" HeaderText="Kind" />
            <asp:TemplateField HeaderText="Pic">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ppic") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image2" runat="server" Height="94px" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"ppic","mypics/{0}") %>' Width="116px" />
                </ItemTemplate>
            </asp:TemplateField>
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
                <asp:Label ID="Label1" runat="server" Text="Product Code:"></asp:Label>
            </td>
            <td class="auto-style1">
                  <asp:TextBox ID="pcode" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Product Name:"></asp:Label>
            </td>
            <td>
                  <asp:TextBox ID="pname" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Product Describe:"></asp:Label>
            </td>
            <td>
                  <asp:TextBox ID="pdescribe" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Product Quantity:"></asp:Label>
            </td>
            <td>
                  <asp:TextBox ID="pquantity" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Product Kind:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="Reusable"/>
                    <asp:ListItem Text="Disposable"/>
                </asp:DropDownList>

            </td>
        </tr>

        <tr>
            <td>
                <asp:Image ID="img" ImageUrl = "~/images/tent3-large.png" runat="server" Height="139px" ImageAlign="Middle" Width="164px" />
            </td>
            <td>
                <asp:FileUpload ID="pic" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Update Item" OnClick="Button1_Click" />
            </td>
        </tr>
        
        
    </table>
</asp:Content>

