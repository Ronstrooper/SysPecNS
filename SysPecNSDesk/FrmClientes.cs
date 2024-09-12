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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaGrid2();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtEmail.Text,
                txtCPF.Text,
                txtTelefone.Text,
                dtmDataNasc.Value
                );

            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome}, " +
                    $"foi inserido com sucesso , com o ID {cliente.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtNome.Focus();

                FrmClientes_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            } //parei aqui
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                CarregaGrid(textBox6.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista(nome);
            dataGridView1.Rows.Clear();
            int cont = 0;

            var list2 = Endereco.ObterListaPorClientesPorId(nome);

            foreach (var cliente in lista)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[cont].Cells[0].Value = cliente.Id;
                dataGridView1.Rows[cont].Cells[1].Value = cliente.Nome;
                dataGridView1.Rows[cont].Cells[2].Value = cliente.CPF;
                dataGridView1.Rows[cont].Cells[3].Value = cliente.Telefone;
                dataGridView1.Rows[cont].Cells[4].Value = cliente.Email;
                dataGridView1.Rows[cont].Cells[5].Value = cliente.Data_nasc;
                dataGridView1.Rows[cont].Cells[6].Value = cliente.Data_cad;
                dataGridView1.Rows[cont].Cells[7].Value = cliente.Ativo;

                cont++;
            }


        }

        private void CarregaGrid2(string nome = "")
        {
            var lista = Endereco.ObterLista(nome);
            dgvEndereco.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[cont].Cells[0].Value = endereco.Id;
                dgvEndereco.Rows[cont].Cells[1].Value = endereco.Cliente_id.Nome;
                dgvEndereco.Rows[cont].Cells[2].Value = endereco.Cliente_id.CPF;
                dgvEndereco.Rows[cont].Cells[3].Value = endereco.Cliente_id.Telefone; 
                dgvEndereco.Rows[cont].Cells[4].Value = endereco.Cliente_id.Email;
                dgvEndereco.Rows[cont].Cells[5].Value = endereco.Cliente_id.Data_nasc;
                dgvEndereco.Rows[cont].Cells[6].Value = endereco.Cliente_id.Data_cad;
                dgvEndereco.Rows[cont].Cells[7].Value = endereco.Cliente_id.Ativo;
                dgvEndereco.Rows[cont].Cells[8].Value = endereco.Cep + ", " + endereco.Tipo + ", " + endereco.Logradouro + ", " + endereco.Numero + ", " + endereco.Complemento + ", " + endereco.Bairro + ", " + endereco.Cidade + ", " + endereco.UF;

                cont++;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void brnInserir_Endereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                Cliente.ObterPorId(Convert.ToInt32(txtidCliente_Endereco.Text)),
                txtCEP_Endereco.Text,
                txtLogradou_Endereco.Text,
                txtNumero_Endereco.Text,
                txtComplemento_Endereco.Text,
                txtBairro_Endereco.Text,
                txtCidade_Endereco.Text,
                txtUF_Endereco.Text,
                txtTipo_Endereco.Text
                );


            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId.Text = endereco.Id.ToString();
                txtidCliente_Endereco.Text = endereco.Cliente_id.ToString();
                MessageBox.Show($"O Endereco {endereco.Cliente_id}, " +
                    $"foi inserido com sucesso , com o ID {endereco.Id}");
                txtId_Endereco.Clear();
                txtidCliente_Endereco.Clear();
                txtLogradou_Endereco.Clear();
                txtNumero_Endereco.Clear();
                txtComplemento_Endereco.Clear();
                txtBairro_Endereco.Clear();
                txtCidade_Endereco.Clear();
                txtUF_Endereco.Clear();
                txtTipo_Endereco.Clear();
                txtNome.Focus();

                FrmClientes_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brnInserir_Endereco_Click_1(object sender, EventArgs e) // Não funciona
        {
            Endereco endereco = new(
               Cliente.ObterPorId(Convert.ToInt32(txtidCliente_Endereco.Text)),
               txtCEP_Endereco.Text,
               txtLogradou_Endereco.Text,
               txtNumero_Endereco.Text,
               txtComplemento_Endereco.Text,
               txtBairro_Endereco.Text,
               txtCidade_Endereco.Text,
               txtUF_Endereco.Text,
               txtTipo_Endereco.Text
               );


            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId.Text = endereco.Id.ToString();
                txtidCliente_Endereco.Text = endereco.Cliente_id.ToString();
                MessageBox.Show($"O Endereco {endereco.Cliente_id}, " +
                    $" foi inserido com sucesso , com o ID {endereco.Id}");
                txtId_Endereco.Clear();
                txtidCliente_Endereco.Clear();
                txtLogradou_Endereco.Clear();
                txtNumero_Endereco.Clear();
                txtComplemento_Endereco.Clear();
                txtBairro_Endereco.Clear();
                txtCidade_Endereco.Clear();
                txtUF_Endereco.Clear();
                txtTipo_Endereco.Clear();
                txtNome.Focus();

                FrmClientes_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            }
        }
    }
}
