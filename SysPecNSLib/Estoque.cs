using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public Produto? Produto { get; set; } // Possível ser anulado?!
        public double? Quantidade { get; set; }
        public DateTime? Data_Ultimo_Movimento { get; set; }
        public Estoque() 
        { 
            //método construto vazio        
        }
        public Estoque(Produto produto, double? quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
        public Estoque(Produto produto, double? quantidade, DateTime? data_Ultimo_Movimento)
        {
            Produto = produto;
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }
        public void Inserir(int produto, int quantidade) // não sei se está certo
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (quantidade >= 1)
            {
                cmd.CommandText = $"insert estoques (produto_id, quantidade) values({Produto}, {Quantidade}))";
            }
            //cmd.CommandText = $"insert estoques (produto_id, quantidade) values ({Produto}, {Quantidade}))";
            else
            {
               //
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Atualizar(int idProduto, double Quantidade)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update estoques set quantidade = {Quantidade} where produto_id = {idProduto}";
            var dr = cmd.ExecuteReader();
            cmd.Connection.Close();
        }
        public static Estoque ObterPorProduto(int idProduto)
        {
            Estoque estoque = new Estoque();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from estoques where produto_id = {idProduto}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                estoque = new(
                    Produto.ObterPorId(dr.GetInt32(0)),
                    dr.GetDouble(1),
                    dr.GetDateTime(3)
                    );
            }
            return estoque;
        }
    }
}
