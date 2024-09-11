using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario {get; set;}
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; } //string é método primitivo 
        public double Desconto { get; set; }
        public List<ItemPedido> Items { get; set; } 
        public Pedido() { }
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Items = itens;
        }
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spcliente_id",Cliente.Id);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar()); // dando erro
        }
        public void AlterarStatus() //somente alteração do status e desconto
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set status = {Status} where id = {Id}";
            cmd.ExecuteNonQuery();

        }
        public void AtualizarDesconto() //alterar valor desconto dever ser chamado somente pelo objeto em questão
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set desconto = {Desconto} where id = {Id}"; // Status e Desconto são propriedades da própria classe
            cmd.ExecuteNonQuery();
        }
        public static Pedido ObterPorId(int id) //se só colocar o número do pedido, terá que trazer a coleção de dados que esse pedido deve ter
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader(); // leitor
            // retorna um registro ou retorna nenhum registro
            if (dr.Read())
            {
                //pedido.Id = dr.GetInt32(0);
                //pedido.Cliente = Cliente.ObterPorId(dr.GetInt32(1)); //pedido.Cliente
                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)), //posição 1 na consulta banco de dados passando pelo método construtor inteiro
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3), //pega hora e data do banco de dados
                    dr.GetString(4), // retorna status do pedido
                    dr.GetDouble(5) // pega o valor do desconto no banco de dados
                    //[Incluir Lista de Itens]
                     ,ItemPedido.ObterListaPorPedido(dr.GetInt32(0)) //Id do Pedido // busca uma coleção de itens associado a ele, na classe ItemPedido.
                    );
            }

            return pedido;
        }
        public static List<Pedido> ObterLista() // 
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;           
            cmd.CommandText = $"select * from pedidos"; //retorna tudo
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)), //posição 1 na consulta banco de dados passando pelo método construtor inteiro
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3), //pega hora e data do banco de dados
                    dr.GetString(4), // retorna status do pedido
                    dr.GetDouble(5) // pega o valor do desconto no banco de dados
                    ));
            }

            return pedidos;
        }
        public static List<Pedido> ObterListaPorCliente(int id) // este método puxa o cliente por id, retornando lista de pedido do cliente informado, caso haja pedido
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where cliente_id = {id}"; //retorna tudo
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)), 
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3), 
                    dr.GetString(4), 
                    dr.GetDouble(5)
                    ));
            }


            return pedidos;
        }
        public static List<Pedido> ObterListaPorUsuario(int id) // 
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where usuario_id = {id}"; //retorna pedido de acordo com id inserido
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)), 
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3), 
                    dr.GetString(4), 
                    dr.GetDouble(5) 
                    ));
            }

            return pedidos;
        }
    }
}
