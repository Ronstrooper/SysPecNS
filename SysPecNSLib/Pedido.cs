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
            Id = Convert.ToInt32(cmd.ExecuteScalar()); 
        }
        public void Alterar() { }
        public static Pedido ObterPorId(int id) //se só colocar o número do pedido, terá que trazer a coleção de dados que esse pedido deve ter
        {
            Pedido pedido = new();

            return pedido;
        }
        public static List<Pedido> ObterLista(int idCliente = 0, int idUsuario = 0) // busca id do cliente //se só colocar o número do pedido, teos que esse pedido deve ter
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
        public void AlterarStatus() { } // só poderá alterar status e valor do pedido
    }
}
