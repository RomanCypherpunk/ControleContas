using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Contas_DB;

public partial class TopClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListOperator listOperator = new ListOperator();
        gridGroupCost.DataSource = listOperator.GetGroupCost();
        gridGroupCost.DataBind();


    }

    protected void grid2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}