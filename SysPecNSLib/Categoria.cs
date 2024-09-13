using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Categoria
    {
        public int Id { get; set; } // métodos construtores
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria() { } // método vazio que retonar new new();
        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id, string? sigla)
        {
            Id = id;
            Sigla = sigla;
        }
        public Categoria(int id, string? nome, string? sigla=null) // 

        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public void Inserir() // métodos das classe
        {
            var cmd = Banco.Abrir(); //quando inserir categoria é importante verificar se há alguma procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert"; //procedure insert
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());  //data reader //Scalar, retorna um núnico valor,
            cmd.Connection.Close();
        }
        public static Categoria ObterPorId(int id) //ObterPorId
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new (dr.GetInt32(0), dr.GetString(1),null);
                
            }
            cmd.Connection.Close();
            return categoria; 
        }
        public static List<Categoria> ObterLista() //construção método obter da classe
        {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorias.Add(new(dr.GetInt32(0), dr.GetString(1)));

            }
            cmd.Connection.Close();
            return categorias;

        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery(); //procedure não retorna nada 
            cmd.Connection.Close();
        }
        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from categoria where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
