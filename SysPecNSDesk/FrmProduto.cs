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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "nome";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinino;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;

                count++;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodBar.Text, txtDescricao.Text, double.Parse(txtValorUnit.Text), txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)npEstoqueMinimo.Value, double.Parse(txtDesconto.Text)

                );
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto inserido com sucesso com o id {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCodBar.Clear();
                txtValorUnit.Clear();
                txtUnidadeVenda.Clear();
                txtDescricao.Clear();
                txtDesconto.Clear();
                txtUnidadeVenda.Clear();
                npEstoqueMinimo.Value = 0;
                btnConsultar.Text = "&Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;
            }
        }
    }
}
