﻿using SysPecNSLib;
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

            // preenchendo o datagrid com os usuários
            var Lista = Usuario.ObterLista();
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in Lista)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbNivel.SelectedValue.ToString);
            Usuario usuario = new();

        }
    }
}
