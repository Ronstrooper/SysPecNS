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

namespace SysPecNSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this; //define o formulário Usuario como filho do FrmPrincipal
            frmUsuario.Show(); // Mostra o formulário Usuario na tela, mas permite que o usuário abra mais de uma janela na mesma instância
            //frmUsuario.ShowDialog(); // Mostra o diálogo mas impede que qualquer outra janela seja exibida, usada apenas para obrigar a janela a ser executada em primeiro plano

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja Sair ?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // pergunta ao usuário se ele deseja mesmo sair ou fechar a janela
            if (msg == DialogResult.Yes) Application.Exit(); // fecha o programa ou sai da sesssão 
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new(); //FrmProduto
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) // Load do Formulário Login
        {
            FrmLogin frmLogin = new(); //Load do Formulário de Login dentro do Formulário Principal
            //frmLogin.MdiParent = this;
            frmLogin.ShowDialog();
            Text += $" ({Program.UsuarioLogado.Email})"; //código para inserir o email do usuário na barra da janela
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}"; //atribui valor ao usuário logado na Strip do form principal
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo = new();
            frmPedidoNovo.MdiParent = this;
            frmPedidoNovo.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new();
            frmFornecedor.MdiParent = this;
            frmFornecedor.Show();
        }
    }
}
