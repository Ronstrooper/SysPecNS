using System;
using System.Collections.Generic;
using System.Data;
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
        public Fornecedor(int id, string? razaoSocial, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public static Fornecedor ObterPorId(int id)
        {
            Fornecedor fornecedor = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select id, razao_social, fantasia, cnpj, contato, telefone, email from fornecedores where id = {id}";

            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                fornecedor = new Fornecedor(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetInt32(2),
                    dr.GetInt32(3),
                    dr.GetInt32(4),
                    dr.GetInt32(5),
                    dr.GetInt32(6)
                    );
            }
            cmd.Connection.Close();
            return fornecedor;
        }

    }
}
