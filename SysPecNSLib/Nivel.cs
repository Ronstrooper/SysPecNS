using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Bcpg; // abreviar "System.Data" no "Command.Type" - CommandType é Enum, Tipo do C# que carrega objetos e valores do código.

namespace SysPecNSLib
{
    public class Nivel
    {
        // atributos
        // private int id;
        // private string nome;    //public string sigla (get { return nome; }; set { nome = value; })
        // private string sigla;

        // métodos de acesso get e set
        // public int Id { get => id; set => id = value; } //selecionar objeto, clicar com o botão direito > Ações rápidas e refatorações > encapsular campo 
     
        // propriedade
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // métodos construtores // nome do construtor é sempre o nome da classe
        public Nivel(){ }

        public Nivel(string nome, string sigla) // sobrecarga de métodos
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel(int id, string nome, string sigla) //usado para consultas
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        // métodos (requisitos) //incluir, alterar, consultar
        /// <summary>
        /// Método para inserir registro de nível na base de dados
        /// </summary>
        public void Inserir()
        {
            // conectando com o banco de dados
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis (nome, sigla) values('{Nome}','{Sigla}')"; // id não é necessário por ser auto_increment no banco de dados
            cmd.ExecuteNonQuery();  // equivalente ao Enter dado no prompt do MySql no Xampp
            cmd.Connection.Close();

        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new Nivel();
            // consulta no banco e retornar o Nivel
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM niveis where id = {id};";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            cmd.Connection.Close();
            return nivel; 
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new List<Nivel>();
            // consulta para retornar a lista de niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM niveis;";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lista.Add(
                    new(dr.GetInt32(0), 
                    dr.GetString(1),
                    dr.GetString(2)
                    )
                );
            }

            cmd.Connection.Close();
            return lista;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update niveis" +
                $"set nome = '{Nome}', sigla = '{Sigla}' where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;  //If ternário
            //return retorna valor com verificação booleana
            // "?" simula "se" lendo o comando executado como true
            // ":" (dois pontos) retorna falso

            //
            //if (cmd.ExecuteNonQuery()>0)
            //return true;
            //else
            //    return false; 
        }
        public void ExcluirNivel(int id)
        {
            // em geral, nada se exclui de uma tabela 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from niveis where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
