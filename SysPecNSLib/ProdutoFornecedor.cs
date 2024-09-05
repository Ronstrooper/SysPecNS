using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class ProdutoFornecedor
    {
        public int ProdutoId { get; set; }
        public int FornecedorId { get; set; }

        public ProdutoFornecedor(){}
        public ProdutoFornecedor (int produtoid, int fornecedorid)
        {
            ProdutoId = produtoId;
            FornecedorId = fornecedorId;
        }
        public static List<ProdutoFornecedor>ObterListaPorFornecedor(int fornecedorId)
        {
            List<ProdutoFornecedor> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select produto_id, fornecedor_id from produtofornecedor where fornecedor_id = {fornecedorId}";

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(newProdutoFornecedor)
            }
        }
    }
}
