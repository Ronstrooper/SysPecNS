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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid1();
            LimpaTela();
            CarregaGrid2();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCNPJ.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );

            fornecedor.Inserir();

            MessageBox.Show($"Fornecedor {fornecedor.Fantasia}, gravado com sucesso com o Cnpj {fornecedor.CNPJ}");
            FrmFornecedor_Load(sender, e);



        }

        public void LimpaTela()
        {
            txtId.Clear();
            txtRazaoSocial.Clear();
            txtFantasia.Clear();
            txtCNPJ.Clear();
            txtContato.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        public void CarregaGrid1()
        {
            var lista = SysPecNSLib.Fornecedor.ObterLista();
            dtgFornecedor.Rows.Clear();
            int count = 0;
            foreach (var fornecedor in lista)
            {
                dtgFornecedor.Rows.Add();
                dtgFornecedor.Rows[count].Cells[0].Value = fornecedor.Id;
                dtgFornecedor.Rows[count].Cells[1].Value = fornecedor.RazaoSocial;
                dtgFornecedor.Rows[count].Cells[2].Value = fornecedor.Fantasia;
                dtgFornecedor.Rows[count].Cells[3].Value = fornecedor.CNPJ;
                dtgFornecedor.Rows[count].Cells[4].Value = fornecedor.Contato;
                dtgFornecedor.Rows[count].Cells[5].Value = fornecedor.Telefone;
                dtgFornecedor.Rows[count].Cells[6].Value = fornecedor.Email;
                count++;
            }
        }

        public void CarregaGrid2()
        {
            var lista = Fornecedor.ObterListapdtFornecedor();
            dtgProdutoFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dtgProdutoFornecedor.Rows.Add();
                dtgProdutoFornecedor.Rows[cont].Cells[0].Value = fornecedor.ProdutoId.Id;
                dtgProdutoFornecedor.Rows[cont].Cells[1].Value = fornecedor.ProdutoId.CodBar;
                dtgProdutoFornecedor.Rows[cont].Cells[2].Value = fornecedor.ProdutoId.Descricao;
                dtgProdutoFornecedor.Rows[cont].Cells[3].Value = fornecedor.FornecedorId.Id; //fornecedorid corrigir na classe Fornecedor
                dtgProdutoFornecedor.Rows[cont].Cells[4].Value = fornecedor.FornecedorId.Fantasia; //fornecedorid corrigir na classe Fornecedor
                cont++;
            }

            var lista1 = Produto.ObterLista();
            dtgFornecedor1.Rows.Clear();
            int count = 0;
            foreach (var produto in lista1)
            {
                dtgFornecedor1.Rows.Add();
                dtgFornecedor1.Rows[count].Cells[0].Value = produto.Id;
                dtgFornecedor1.Rows[count].Cells[1].Value = produto.CodBar;
                dtgFornecedor1.Rows[count].Cells[2].Value = produto.Descricao;
                count++;
            }

            var lista2 = SysPecNSLib.Fornecedor.ObterLista();
            dtgFornecedor1.Rows.Clear();
            int count1 = 0;
            foreach (var fornecedor in lista2)
            {
                dtgFornecedor1.Rows.Add();
                dtgFornecedor1.Rows[count1].Cells[0].Value = fornecedor.Id;
                dtgFornecedor1.Rows[count1].Cells[1].Value = fornecedor.Fantasia;
                count1++;
            }


        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (btnConsulta.Text == "&Consultar")
            {
                LimpaTela();
                btnConsulta.Text = "&Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Fornecedor fornecedor = Fornecedor.ObterPorId(int.Parse(txtId.Text));
                    txtRazaoSocial.Text = fornecedor.RazaoSocial;
                    txtFantasia.Text = fornecedor.Fantasia;
                    txtCNPJ.Text = fornecedor.CNPJ;
                    txtContato.Text = fornecedor.Contato;
                    txtTelefone.Text = fornecedor.Telefone;
                    txtEmail.Text = fornecedor.Email;
                    //nudEstoqueMinimo.Value = produto.EstoqueMinimo;

                    btnUpdate.Enabled = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                int.Parse(txtId.Text),
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCNPJ.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );
            fornecedor.Atualizar();
            MessageBox.Show($"Produto {fornecedor.Id} - {fornecedor.Fantasia} atualizado com sucesso");
            btnUpdate.Enabled = false;
            txtId.ReadOnly = true;
            btnConsulta.Text = "&Consultar";
            LimpaTela();
            FrmFornecedor_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddProdutoFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                Produto.ObterPorId(int.Parse(txtProdutoId.Text)),
                Fornecedor.ObterPorId(Convert.ToInt32(txtFornecedorId.Text))
                );
            fornecedor.InserirpdtFornecedor();
            txtFornecedorId.Clear();
            txtProdutoId.Clear();
            txtProdutoId.Focus();
            FrmFornecedor_Load(sender, e);
        }
    }
}
