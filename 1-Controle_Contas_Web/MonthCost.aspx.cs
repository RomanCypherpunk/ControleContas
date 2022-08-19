using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Contas_DB;

public partial class MonthCost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListOperator listOperator = new ListOperator();
        grid2.DataSource = listOperator.GetMonthCost();
        grid2.DataBind();

   
    }






    protected void grid2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}