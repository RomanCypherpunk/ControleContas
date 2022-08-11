using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Contas_DB;

public partial class ListagemContas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListOperator listOperator = new ListOperator();
        gridListaContas.DataSource = listOperator.GetAllContas();
        gridListaContas.DataBind();

    

    }
}