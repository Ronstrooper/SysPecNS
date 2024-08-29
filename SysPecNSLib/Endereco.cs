﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo_endereco { get; set; }
         public Endereco()
        {
            Id = 0;
        }
        public Endereco(int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Cliente_id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }
        public Endereco(int id, int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Id = id;
            Cep = cep;
            Cliente_id = cliente_id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);
            var dr = cmd.ExecuteNonQuery();

        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                
            }
        }
    }
}
