<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddItem.aspx.cs" Inherits="AddItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <center><h1>WELCOMNE TO THE EMPIRE OF THE MAHSAN HOOLIGANS ORGANIZATION</h1></center>
     <center><h1>ADD ITEM</h1></center>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Product Code:"></asp:Label>
            </td>
            <td>
                  <asp:TextBox ID="pcode" runat="server"></asp:TextBox>
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
                <asp:Label ID="Label6" runat="server" Text="Product Picture:"></asp:Label>
            </td>
            <td>
                <asp:FileUpload ID="pic" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Add Item" OnClick="Button1_Click" />
            </td>
        </tr>
        
        
    </table>
</asp:Content>

