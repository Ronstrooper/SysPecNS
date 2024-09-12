namespace SysPecNSDesk
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            TELEFONE = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Data_nasc = new DataGridViewTextBoxColumn();
            Data_cad = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            textBox6 = new TextBox();
            btnInserir = new Button();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtmDataNasc = new DateTimePicker();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtId = new TextBox();
            tabPage2 = new TabPage();
            dgvEndereco = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Logradouro = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewCheckBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            txtBuscaClientes_Endereco = new TextBox();
            label17 = new Label();
            txtLogradou_Endereco = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            brnInserir_Endereco = new Button();
            txtTipo_Endereco = new TextBox();
            txtUF_Endereco = new TextBox();
            txtCidade_Endereco = new TextBox();
            txtBairro_Endereco = new TextBox();
            txtComplemento_Endereco = new TextBox();
            txtNumero_Endereco = new TextBox();
            txtCEP_Endereco = new TextBox();
            txtidCliente_Endereco = new TextBox();
            txtId_Endereco = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(908, 541);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtmDataNasc);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtId);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(900, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Cpf, TELEFONE, Email, Data_nasc, Data_cad, Ativo });
            dataGridView1.Location = new Point(29, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(799, 182);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "NOME";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            // 
            // TELEFONE
            // 
            TELEFONE.HeaderText = "Telefone";
            TELEFONE.Name = "TELEFONE";
            TELEFONE.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Data_nasc
            // 
            Data_nasc.HeaderText = "Data de Nascimento";
            Data_nasc.Name = "Data_nasc";
            Data_nasc.ReadOnly = true;
            // 
            // Data_cad
            // 
            Data_cad.HeaderText = "Cadastro";
            Data_cad.Name = "Data_cad";
            Data_cad.ReadOnly = true;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(77, 283);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(675, 23);
            textBox6.TabIndex = 15;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(127, 218);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 14;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 218);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 194);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 12;
            label7.Text = "Ativo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(523, 111);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 11;
            label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 111);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 111);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 39);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 39);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // dtmDataNasc
            // 
            dtmDataNasc.Location = new Point(523, 142);
            dtmDataNasc.Name = "dtmDataNasc";
            dtmDataNasc.Size = new Size(264, 23);
            dtmDataNasc.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(162, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(337, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(523, 66);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(162, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(307, 142);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(192, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvEndereco);
            tabPage2.Controls.Add(txtBuscaClientes_Endereco);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(txtLogradou_Endereco);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(brnInserir_Endereco);
            tabPage2.Controls.Add(txtTipo_Endereco);
            tabPage2.Controls.Add(txtUF_Endereco);
            tabPage2.Controls.Add(txtCidade_Endereco);
            tabPage2.Controls.Add(txtBairro_Endereco);
            tabPage2.Controls.Add(txtComplemento_Endereco);
            tabPage2.Controls.Add(txtNumero_Endereco);
            tabPage2.Controls.Add(txtCEP_Endereco);
            tabPage2.Controls.Add(txtidCliente_Endereco);
            tabPage2.Controls.Add(txtId_Endereco);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(900, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEndereco
            // 
            dgvEndereco.AllowUserToAddRows = false;
            dgvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEndereco.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, IDCliente, CEP, Logradouro, Numero, Complemento, Bairro, Cidade, UF });
            dgvEndereco.Location = new Point(53, 297);
            dgvEndereco.Name = "dgvEndereco";
            dgvEndereco.ReadOnly = true;
            dgvEndereco.RowHeadersVisible = false;
            dgvEndereco.Size = new Size(761, 206);
            dgvEndereco.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "Cliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            // 
            // CEP
            // 
            CEP.HeaderText = "Cpf";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            // 
            // Logradouro
            // 
            Logradouro.HeaderText = "Telefone";
            Logradouro.Name = "Logradouro";
            Logradouro.ReadOnly = true;
            // 
            // Numero
            // 
            Numero.HeaderText = "Email";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Complemento
            // 
            Complemento.HeaderText = "Data de Nascimento";
            Complemento.Name = "Complemento";
            Complemento.ReadOnly = true;
            // 
            // Bairro
            // 
            Bairro.HeaderText = "Cadastro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            Cidade.HeaderText = "Ativo";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            // 
            // UF
            // 
            UF.HeaderText = "Endereco";
            UF.Name = "UF";
            UF.ReadOnly = true;
            // 
            // txtBuscaClientes_Endereco
            // 
            txtBuscaClientes_Endereco.Location = new Point(70, 253);
            txtBuscaClientes_Endereco.Name = "txtBuscaClientes_Endereco";
            txtBuscaClientes_Endereco.Size = new Size(698, 23);
            txtBuscaClientes_Endereco.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(459, 33);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 20;
            label17.Text = "Logradouro";
            // 
            // txtLogradou_Endereco
            // 
            txtLogradou_Endereco.Location = new Point(456, 56);
            txtLogradou_Endereco.Name = "txtLogradou_Endereco";
            txtLogradou_Endereco.Size = new Size(191, 23);
            txtLogradou_Endereco.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(287, 168);
            label16.Name = "label16";
            label16.Size = new Size(30, 15);
            label16.TabIndex = 18;
            label16.Text = "Tipo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(160, 168);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 17;
            label15.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 168);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 16;
            label14.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(348, 107);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 15;
            label13.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(160, 107);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 14;
            label12.Text = "Complemento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 107);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 13;
            label11.Text = "Número";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(287, 33);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 12;
            label10.Text = "CEP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(155, 33);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 11;
            label9.Text = "ID do Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 33);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 10;
            label8.Text = "ID";
            // 
            // brnInserir_Endereco
            // 
            brnInserir_Endereco.Location = new Point(444, 185);
            brnInserir_Endereco.Name = "brnInserir_Endereco";
            brnInserir_Endereco.Size = new Size(75, 23);
            brnInserir_Endereco.TabIndex = 9;
            brnInserir_Endereco.Text = "Inserir";
            brnInserir_Endereco.UseVisualStyleBackColor = true;
            brnInserir_Endereco.Click += brnInserir_Endereco_Click_1;
            // 
            // txtTipo_Endereco
            // 
            txtTipo_Endereco.Location = new Point(287, 186);
            txtTipo_Endereco.Name = "txtTipo_Endereco";
            txtTipo_Endereco.Size = new Size(117, 23);
            txtTipo_Endereco.TabIndex = 8;
            // 
            // txtUF_Endereco
            // 
            txtUF_Endereco.Location = new Point(160, 186);
            txtUF_Endereco.Name = "txtUF_Endereco";
            txtUF_Endereco.Size = new Size(100, 23);
            txtUF_Endereco.TabIndex = 7;
            // 
            // txtCidade_Endereco
            // 
            txtCidade_Endereco.Location = new Point(28, 186);
            txtCidade_Endereco.Name = "txtCidade_Endereco";
            txtCidade_Endereco.Size = new Size(100, 23);
            txtCidade_Endereco.TabIndex = 6;
            // 
            // txtBairro_Endereco
            // 
            txtBairro_Endereco.Location = new Point(348, 125);
            txtBairro_Endereco.Name = "txtBairro_Endereco";
            txtBairro_Endereco.Size = new Size(171, 23);
            txtBairro_Endereco.TabIndex = 5;
            // 
            // txtComplemento_Endereco
            // 
            txtComplemento_Endereco.Location = new Point(160, 125);
            txtComplemento_Endereco.Name = "txtComplemento_Endereco";
            txtComplemento_Endereco.Size = new Size(166, 23);
            txtComplemento_Endereco.TabIndex = 4;
            // 
            // txtNumero_Endereco
            // 
            txtNumero_Endereco.Location = new Point(28, 125);
            txtNumero_Endereco.Name = "txtNumero_Endereco";
            txtNumero_Endereco.Size = new Size(100, 23);
            txtNumero_Endereco.TabIndex = 3;
            // 
            // txtCEP_Endereco
            // 
            txtCEP_Endereco.Location = new Point(287, 56);
            txtCEP_Endereco.Name = "txtCEP_Endereco";
            txtCEP_Endereco.Size = new Size(147, 23);
            txtCEP_Endereco.TabIndex = 2;
            // 
            // txtidCliente_Endereco
            // 
            txtidCliente_Endereco.Location = new Point(155, 56);
            txtidCliente_Endereco.Name = "txtidCliente_Endereco";
            txtidCliente_Endereco.Size = new Size(105, 23);
            txtidCliente_Endereco.TabIndex = 1;
            // 
            // txtId_Endereco
            // 
            txtId_Endereco.Location = new Point(28, 56);
            txtId_Endereco.Name = "txtId_Endereco";
            txtId_Endereco.Size = new Size(100, 23);
            txtId_Endereco.TabIndex = 0;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 541);
            Controls.Add(tabControl1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtmDataNasc;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtId;
        private TabPage tabPage2;
        private Button btnInserir;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn TELEFONE;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Data_nasc;
        private DataGridViewTextBoxColumn Data_cad;
        private DataGridViewCheckBoxColumn Ativo;
        private Button brnInserir_Endereco;
        private TextBox txtTipo_Endereco;
        private TextBox txtUF_Endereco;
        private TextBox txtCidade_Endereco;
        private TextBox txtBairro_Endereco;
        private TextBox txtComplemento_Endereco;
        private TextBox txtNumero_Endereco;
        private TextBox txtCEP_Endereco;
        private TextBox txtidCliente_Endereco;
        private TextBox txtId_Endereco;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label17;
        private TextBox txtLogradou_Endereco;
        private DataGridView dgvEndereco;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Logradouro;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewCheckBoxColumn Cidade;
        private DataGridViewTextBoxColumn UF;
        private TextBox txtBuscaClientes_Endereco;
    }
}