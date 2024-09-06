using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public string? CNPJ { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public Fornecedor() { }
        public Fornecedor(int id, string? razaoSocial, string? fantasia, string? cNPJ, string? contato, string? telefone, string? email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cNPJ;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public static Fornecedor ObterPorId(int id)
        {
            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            //cmd.CommandType = System.Data.CommandType.Text; 
            cmd.CommandText = $"select * from fornecedor where id = {id}";

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fornecedor = new( //Get deve ser de acordo com o método construtor criado
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    );
            }
            cmd.Connection.Close();
            return fornecedor;
        }
    }
}
