using System;
using System.Collections.Generic;
using System.Data;
using Controle_Contas_Model;

namespace Controle_Contas_DB
{
    public class ListOperator
    {
        private DataManager db = new DataManager();

        public void Insert(string Query)
        {
            db.execute(Query);
        }

        public void Delete(string Query)
        {
            db.execute(Query);

        }

        public List<Conta> ComboBox()
        {
            string sql = "seselect g.Descricao as Valor from tbl_lcto as l join tbl_Contas c on l.IDConta = c.IDonta join tbl_GrupoContas g on c.IDGrupoContas = g.IDGrupoContas group by g.Descricao lect g.Descricao, MONTH(l.DataLCTO) as Mês, YEAR(l.DataLCTO) as Ano , sum(l.Valor) as Valor from tbl_lcto as l join tbl_Contas c on l.IDConta = c.IDonta join tbl_GrupoContas g on c.IDGrupoContas = g.IDGrupoContas group by g.Descricao, MONTH(l.DataLCTO), YEAR(l.DataLCTO) order by Valor desc";

            List<Conta> contas = new List<Conta>();

            DataTable dt = db.executeTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                contas.Add(new Conta
                {
                    DescricaoGrupoContas = row[0].ToString()
                });
            }
            return contas;
        }

        public List<Conta> GetAllLcto()
        {
            string sql = "select g.Descricao, MONTH(l.DataLCTO) as Mês, YEAR(l.DataLCTO) as Ano , sum(l.Valor) as Valor from tbl_lcto as l join tbl_Contas c on l.IDConta = c.IDonta join tbl_GrupoContas g on c.IDGrupoContas = g.IDGrupoContas group by g.Descricao, MONTH(l.DataLCTO), YEAR(l.DataLCTO) order by Valor desc";

            List<Conta> contas = new List<Conta>();

            DataTable dt = db.executeTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                contas.Add(new Conta
                {
                    DescricaoGrupoContas = row[0].ToString(),
                    Mes = row[1].ToString(),
                    Ano = row[2].ToString(),
                    Valor = row[3].ToString()
                });
            }
            return contas;
        }
        public List<Conta> GetMonthCost()
        {
            string sql = "select MONTH(l.DataLCTO) as Mês, YEAR(l.DataLCTO) as Ano , sum(l.Valor) as Valor from tbl_lcto as l join tbl_Contas c on l.IDConta = c.IDonta join tbl_GrupoContas g on c.IDGrupoContas = g.IDGrupoContas group by MONTH(l.DataLCTO), YEAR(l.DataLCTO) order by Valor desc";

            var contas = new List<Conta>();

            DataTable dt = db.executeTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                contas.Add(new Conta
                {
                    Mes = row[0].ToString(),
                    Ano = row[1].ToString(),
                    Valor = row[2].ToString()
                });
            }
            return contas;
        }

        public List<Conta> GetGroupCost()
        {
            string sql = "select g.Descricao as Mês, sum(l.Valor) as Valor from tbl_lcto as l join tbl_Contas c on l.IDConta = c.IDonta join tbl_GrupoContas g on c.IDGrupoContas = g.IDGrupoContas group by g.Descricao order by Valor desc";

            var contas = new List<Conta>();

            DataTable dt = db.executeTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                contas.Add(new Conta
                {
                    DescricaoGrupoContas = row[0].ToString(),
                    Valor = row[1].ToString()
                });
            }
            return contas;
        }

        public List<Conta> GetContas()
        {
            string sql = "select c.IDonta, c.Descricao from tbl_Contas as c order by c.IDonta";

            var contas = new List<Conta>();

            DataTable dt = db.executeTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                contas.Add(new Conta
                {
                    IDConta = Convert.ToInt32(row[0].ToString()),
                    DescricaoConta = row[1].ToString()
                });
            }
            return contas;
        }

        public List<Conta> GetAllContas()
        {
            string sql = "select l.IDconta, c.Descricao, MONTH(l.DataLCTO) as Mês, YEAR(l.DataLCTO) as Ano , sum(l.Valor) as Valor from tbl_lcto as l join tbl_Contas c on l.IDConta = c.IDonta join tbl_GrupoContas g on c.IDGrupoContas = g.IDGrupoContas group by c.Descricao, MONTH(l.DataLCTO), YEAR(l.DataLCTO), l.IDconta order by Valor desc";

            var contas = new List<Conta>();

            DataTable dt = db.executeTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                contas.Add(new Conta
                {
                    IDConta = Convert.ToInt32(row[0].ToString()),
                    DescricaoConta = row[1].ToString(),
                    Mes = row[2].ToString(),
                    Ano = row[3].ToString(),
                    Valor = row[4].ToString()
                });
            }
            return contas;
        }
    }
}