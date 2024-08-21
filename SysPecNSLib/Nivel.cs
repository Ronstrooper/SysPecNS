using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            // consulta no banco e retornar o Nivel
            return nivel;
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            // consulta para retornar a lista de niveis

            return lista;
        }
        public bool Atualizar()
        {
            return true;

        }
        public void ExcluirNivel(int id)
        { 
            
        }
    }
}
