using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysPecNSDesk
{
    public partial class FrmPedidoNovo : Form
    {
        Produto produto;
        ItemPedido itempedido;
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome; //valor que vai aparecer no txtUsuario
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //txtCliente
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new( //Botão Abrir no frmPedido
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbItens.Enabled = true; //permite digitar itens 
            grbIdentificacao.Enabled = false;
            txtCodBar.Focus(); //cursor´já vai direto para o código de barras piscando
            //MessageBox.Show($"Novo pedido criado - {pedido.Id}"); não descomentar

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_Leave(object sender, EventArgs e)
        {
            if (txtCodBar.TextLength > 0)
            {
                produto = Produto.ObterPorId(txtCodBar.Text); //Produto só existe dentro do txtCodBar_Leave
                txtDescricaoItem.Text = produto.Descricao;
                if (produto.ClasseDesconto == 0) // não permite desconto caso o produto não tenha a opção disponível no banco de dados
                {
                    txtDescontoItens.Enabled = false;
                }
                else
                {
                    txtDescontoItens.Enabled = true;
                    label4.Text = $"{produto.ValorUnit * produto.ClasseDesconto}"; //label 4 tá errado e deveria ser substituído por btn?

                }
                txtValorUnitItem.Text = produto.ValorUnit.ToString(); //double para string
                txtValorUnitItem.ReadOnly = true;
                txtQuantidadeItem.Focus(); // leva o cursor para a caixa quantidade

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidadeItem.Text),
                double.Parse(txtDescontoItens.Text)
                );

            item.Inserir(); // comando de inserir o objeto // somente o método inserir insere no banco de dados
            produto = new(); // instância vazia da variável produto
            txtDescontoItens.Text = "0";
            txtDescricaoItem.Clear();
            txtValorUnitItem.Text = "0";
            txtQuantidadeItem.Text = "1";
            txtCodBar.Clear();
            txtCodBar.Focus();
            txtDescontodoPedido.Enabled = true;

            PreencherGridItens(); // PreencherGirdItens
        }


        private void PreencherGridItens() // método preenche Grid ^ //PreencherGirdItens
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text)); // pega o valor do txtIdPedido no FrmPedidoNovo
            dgvItensPedido.Rows.Clear(); // limpa o grid de pedidos

            int linha = 0;
            double desconto = 0;
            double total = 0;
            double subtotal = 0; // COMENTAR SE NECESSÁRIO
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{linha + 1}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade.ToString("#0.000");
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto.ToString("#0.00"); // puxa o objeto desconto
                dgvItensPedido.Rows[linha].Cells[6].Value = (item.ValorUnit * item.Quantidade - item.Desconto).ToString("#0.00");
                linha++;
                total += item.ValorUnit * item.Quantidade - item.Desconto;
                desconto += item.Desconto;
                subtotal *= item.ValorUnit * item.Quantidade; // COMENTAR SE NECESSÁRIO
                //subtotal *= item.ValorUnit * item.Quantidade;    
            }
            txtTotal.Text = total.ToString("#0.00"); // mostra o valor em casa decimal 
            textBox2.Text = desconto.ToString("#0.00");
            // textBox4.Text = desconto.ToString("#0.00"); // COMENTAR SE NECESSÁRIO
            txtSubTotal.Text = subtotal.ToString("#0.00"); // COMENTAR SE DER ERRO
            //textBox2.Text = desconto.ToString("#0.00");
            //txtSubTotal.Text = subtotal.ToString("#0.00");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {


            FrmClienteBuscar frmClienteBuscar = new(); // recebe valor vazio
            frmClienteBuscar.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            //itempedido = ItemPedido.ObterPorId(txtQuantidade.Text); //vai dar erro ao descomentar


        }

        private void btnFechar_Click(object sender, EventArgs e) // botão fechar pedido
        {
            //double total = double.Parse(txtSubTotal.Text) - double.Parse(textBox2.Text) - double.Parse(txtDescontodoPedido.Text);
            //textBox4.Text = total.ToString("#0.00");
            //if (double.Parse(txtTotal.Text) > double.Parse(txtDescontodoPedido.Text) || (double.Parse(txtTotal.Text) == double.Parse(txtDescontodoPedido.Text)))
            //{
            //    if (txtTotal.Text == textBox4.Text)
            //    {
            //        Pedido pedido = new(
            //            int.Parse(txtIdPedido.Text),
            //            "F"
            //        );

            //        pedido.AlterarStatus();

            //        Close();
            //    }
            //    else
            //    {
            //        txtTotal.Text = textBox4.Text;

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("O valor do desconto é maior que o preço do pedido");
            //    txtDescontodoPedido.Text = Convert.ToString(0);
            //}
        }

    }
}
