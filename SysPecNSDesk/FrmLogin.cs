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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //código e método para sair da aplicação
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text); //se tiver email e senha no banco de dados, já funcionou
                if (usuario.Id > 0) //Close(); // se o ID de usuário for > 0 é porque ele logou
                {
                    if (usuario.Ativo)
                    {
                        Program.UsuarioLogado = usuario; //usuário logado que foi criado na classe program
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário está inativo. \n Procure a gerência."); // \n pula de linha
                        Application.Exit(); // para sair da aplicação caso a senha ou usuário estejam bloqueados
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos, ou inexiste. \n Procure a gerência");
                    //Application.Exit();
                    txtEmail.Focus();
                }

            }
            else
            {
                MessageBox.Show("Você deve preencher email e senha");
                txtEmail.Focus();
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
