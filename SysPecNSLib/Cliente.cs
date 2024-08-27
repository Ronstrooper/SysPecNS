using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Cliente // criação dos métodos construtores 
    {
    public int Id { get; set; } // interroagação "?" indica que o valor pode ser nulo
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public DateTime DataNascimento { get; set; } // de acordo com data_nasc no banco de dados
    public DateTime DataCadastro { get; set; } // de acordo com data_cad no banco de dados
    public bool Ativo { get; set; }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime dataNascimento, DateTime dataCadastro, bool ativo) // 3 métodos construtores
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime dataNascimento, DateTime dataCadastro, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime dataNascimento, DateTime dataCadastro)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);

        }

            



    }
}
