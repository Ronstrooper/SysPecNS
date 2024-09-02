using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Produto
    {
        public int Id { get; set; } //Id maiúsculo para criar propriedade
        public string? CodBar { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria Categoria { get; set; }
        public double EstoqueMinino { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? Imagem { get; set; } // matriz de bytes
        public DateTime DataCad { get; set; }
        public Produto() 
        { 
        
        } //método construtor vazio
        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinino, double classeDesconto) //método construtor que será usado para inserir dados na tebala do banco de dados
        {
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinino = estoqueMinino;
            ClasseDesconto = classeDesconto;
        }
        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinino, double classeDesconto, byte[]? imagem)
        {
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinino = estoqueMinino;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }
        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinino, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinino = estoqueMinino;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public Produto(int id, string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinino, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {
            Id = id;
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinino = estoqueMinino;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minino", EstoqueMinino);
            cmd.Parameters.AddWithValue("spclasse_desconto",ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minino", EstoqueMinino);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            cmd.ExecuteNonQuery();
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new(); //criação objeto Produto, se valendo de um método construto vazio
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3), // de acordo com o método construtor e banco de dados
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)), // campo espera objeto do tipo categoria 
                    dr.GetDouble(6), // double no banoc de daados
                    dr.GetDouble(7),
                    (byte[])dr.GetValue(8), // imagem vem nulo, campo que pode ser nulo, poderia ser apenas "null"
                    dr.GetDateTime(9) //Datetime no método construtor
                    );
            }

            return produto; //métrodo construtor entrega um objeto do valor produto
        }
        public static List<Produto> ObterLista()
        {
            List <Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from produtos order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add( new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3), // de acordo com o método construtor e banco de dados
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)), // campo espera objeto do tipo categoria 
                    dr.GetDouble(6), // double no banoc de daados
                    dr.GetDouble(7),
                    (byte[])dr.GetValue(8), // imagem vem nulo, campo que pode ser nulo, poderia ser apenas "null"
                    dr.GetDateTime(9) //Datetime no método construtor
                    ));
            }

            return produtos;
            
            
        }
    }
}
//sp_produto_insert
//spcod_barras 
//spdescricao
//spvalor_unit 
//spunidade_venda 
//spcategoria_id 
//spestoque_minimo 
//spclasse_desconto