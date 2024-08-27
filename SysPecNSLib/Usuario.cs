using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Usuario
    {
        public int Id { get; set; }
       public string? Nome { get; set; }
       public string? Email { get; set; }
       public string? Senha { get; set; }
       public Nivel Nivel { get; set; }
       public bool Ativo { get; set; }
        public Usuario() // se criar um objeto usuário vazio, ele também cria um valor vazio para Nivel //vai depender de quem usar isso
        {
            Nivel = new();
        }
        public Usuario(string nome, string? email, string? senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(int id, string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public void Inserir()    // Método construtor da classe de usuário //Esqueleto para usar em todas as classes
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert"; // comando procedure para inserir usuario no procedure do banco de dados
            cmd.Parameters.AddWithValue("spnome", Nome); //parametros para adicionar valor ao stored procedure usuario Nome
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        /// <summary>
        /// Obter por Id é um método estático que retorna
        /// Um objeto usuário completo baseado no id informado
        /// </summary>
        /// <param name="id">Id do usuário buscado</param>
        /// <returns>Objeto Usuário com todos os campos</returns>
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }
        public static List<Usuario> ObterLista(string? nome="") 
        {
            List<Usuario> Lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome == "")
            {
                comandosSQL.CommandText = "select * from usuarios order by nome";
            }
            else
            {
                comandosSQL.CommandText = $"select * from usuarios where nome like '%{nome}%' order by nome"; // opção para puxar dados do db, pode ser usado para puxar nomes, produtos, etc.
            }
            comandosSQL.CommandText = "select * from usuarios order by nome";
            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                        )
                    );
            }

            return Lista;
        }
        public static Usuario EfetuarLogin(string email, string senha) // caso login seja efetuado com sucesso, o usuario vai ter um id associado a ele
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{email} and senha = md5('{senha}')";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            // cmd.Connection.Close(); comando para fechar a conexão
            return usuario;
        }
        public void Atualizar()
        {
            // pode atualizar nome, senha, nivel... etc
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            //cmd.Parameters.Add("spid", MySqlDbType.Int32.Value = Id);
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
