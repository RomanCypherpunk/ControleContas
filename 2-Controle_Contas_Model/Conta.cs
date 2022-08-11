using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Contas_Model
{
    public class Conta
    {
        public int IDConta { get; set; }

        public int IDGrupoContas { get; set; }

        public string DescricaoConta { get; set; }

        public string DescricaoGrupoContas { get; set; }

        public string Mes { get; set; }

        public string Ano { get; set; }

        public string Valor { get; set; }
    }

  
    
}
