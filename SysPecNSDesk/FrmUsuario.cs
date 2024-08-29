using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // carregando o combobox de niveis
            var niveis = Nivel.ObterLista(); // busca a classe nivel e armazena os dados da tabela nivel no db
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome"; // nome vindo da tabela niveis
            cmbNivel.ValueMember = "Id";
            CarregaGrid();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbNivel.SelectedValue.ToString());
            Usuario usuario = new(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show($"O usuário {usuario.Nome}, foi inserido com sucesso, com o Id {usuario.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtConfSenha.Clear();
                txtSenha.Clear();
                txtNome.Focus();
                FrmUsuario_Load(sender, e); // recarrega a página do formulário após inserção de cliente
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0) // se usuário digitar ao menos um caractere
            {
                CarregaGrid(txtBusca.Text); // mostra apenas o que for buscado através do like db
            }
            else
            {
                CarregaGrid(); // mostra todos os registros
            }
        }
        private void CarregaGrid(string nome = "")
        {
            // preenchendo o datagrid com os usuários
            var Lista = Usuario.ObterLista(nome);
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in Lista) // para cada usuário na lista
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;
                cont++;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro ?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // pergunta ao usuário se ele deseja mesmo sair ou fechar a janela
                if (msg == DialogResult.No) this.Close();
            }
            else
            {
                Close();
            }

        }
        private bool VerificaControles()
        {
            if (txtNome.Text != String.Empty
                || txtNome.Text != String.Empty
                || txtEmail.Text != String.Empty
                || txtConfSenha.Text != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaoLinha = dgvUsuarios.CurrentRow.Index;
            id = Convert.ToInt32(dgvUsuarios.Rows[posicaoLinha].Cells[0].Value); //pega o conteúdo que vem como objeto, converte para Int32 
            MessageBox.Show(id.ToString());
        }
    }
}
