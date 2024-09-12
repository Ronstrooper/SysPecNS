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
    public partial class FrmClienteBuscar : Form
    {
        public FrmClienteBuscar()
        {
            InitializeComponent();
        }

        private void dgvItensPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Close();
        }

        private void FrmClienteBuscar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "") // não funciona, apagar se necessário
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int PosicaoLinha = dataGridView1.CurrentRow.Index;
            //Program.frmClienteBuscar.Id = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value);
            //Program.frmClienteBuscar.Nome = Convert.ToString(dataGridView1.Rows[PosicaoLinha].Cells[1].Value);
            //Program.frmClienteBuscar.CPF = Convert.ToString(dataGridView1.Rows[PosicaoLinha].Cells[2].Value);
            //Close();

            //APAGAR DAQUI PARA BAIXO SE ERRO PERSISTIR

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
