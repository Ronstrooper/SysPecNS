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
    }
}
