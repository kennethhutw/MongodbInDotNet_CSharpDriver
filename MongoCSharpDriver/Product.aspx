<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="MongoCSharpDriver.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr >
                <td colspan="2">Add New Product</td>
                
            </tr>
            <tr>
                <td class="auto-style1">Product Name</td>
                <td>
                    <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">Quantity</td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </td>
               
            </tr>
              <tr>
                <td class="auto-style1">Quantity</td>
                <td>
                  
                    <asp:Button ID="btnNewProduct" runat="server" OnClick="btnNewProduct_Click" Text="Save" Width="83px" />
                  
                </td>
               
            </tr>
        </table>
    
         <table style="width:100%;">
            <tr>
                <td>Product</td>
                <td>&nbsp;</td>
             
            </tr>
            <tr>
                <td> <asp:GridView ID="gvProducts" runat="server">
                    </asp:GridView></td>
                <td>&nbsp;</td>
              
            </tr>
            <tr>
                <td>
                   
                    <asp:Button ID="btnDeleteById" runat="server" Text="Delete by id" OnClick="btnDeleteById_Click" />
                    <asp:TextBox ID="txtDeleteById" runat="server"></asp:TextBox>
                   
                </td>
                <td>&nbsp;</td>
              
            </tr>
              <tr>
                <td>
                    <asp:Button ID="btnUpdateByID" runat="server" Text="Update By ID" OnClick="btnUpdateByID_Click" />
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="ID : "></asp:Label>
                    <asp:TextBox ID="txtUpdateByID" runat="server"></asp:TextBox>
                  </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Quantity  : "></asp:Label>
                    <asp:TextBox ID="txtUpdateQuantity" runat="server"></asp:TextBox>&nbsp;</td>
              
            </tr>
              <tr>
                <td>
                    <asp:Button ID="btnQueryAll" runat="server" Text="QueryAll" OnClick="btnQueryAll_Click" />
             
                  </td>
                <td>&nbsp;</td>
              
            </tr>
              <tr>
                <td>
                    <asp:Button ID="btnQueryById" runat="server" Text="Query by id" OnClick="btnQueryById_Click" />
                    <asp:TextBox ID="txtQueryById" runat="server"></asp:TextBox>
                  </td>
                <td>&nbsp;</td>
              
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
