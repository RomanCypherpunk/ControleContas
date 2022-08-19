using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controle_Contas_DB;
using Controle_Contas_Model;

public partial class Inserir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ListOperator listOperator = new ListOperator();
    }

    private void drop_Contas_Load(object sender, EventArgs e)
    {
        /* ListOperator listOperator = new ListOperator();

        drop_contas.DataSource = listOperator.ComboBox(); */

        ListOperator listOperator = new ListOperator();
        

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

   
}