<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inserir.aspx.cs" Inherits="Inserir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 613px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="drop_contas" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="txt_valor" runat="server" OnTextChanged="TextBox1_TextChanged">valor</asp:TextBox>
        <asp:Button ID="btn_inserir" runat="server" Text="Inserir" />
    </form>
</body>
</html>
