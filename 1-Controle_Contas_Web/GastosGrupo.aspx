<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GastosGrupo.aspx.cs" Inherits="TopClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:GridView ID="gridGroupCost" AutoGenerateColumns="False" runat="server" CellPadding="4" GridLines="None" Height="176px" OnSelectedIndexChanged="grid2_SelectedIndexChanged" Width="368px" ForeColor="#333333">
               <AlternatingRowStyle BackColor="White" />
              <Columns>
                  <asp:BoundField  DataField="DescricaoGrupoContas" HeaderText="Grupo de Conta" />
                  <asp:BoundField DataField="Valor" HeaderText="Valor (R$)"/>
              </Columns>
               <EditRowStyle BackColor="#7C6F57" />
               <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
               <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#E3EAEB" />
               <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#F8FAFA" />
               <SortedAscendingHeaderStyle BackColor="#246B61" />
               <SortedDescendingCellStyle BackColor="#D4DFE1" />
               <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
