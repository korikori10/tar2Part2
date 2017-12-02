<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="priceLBL" runat="server" Text="Label"></asp:Label>
        <asp:PlaceHolder ID="cartPH" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
