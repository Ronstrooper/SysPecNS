namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            dtgFornecedor = new DataGridView();
            Identificação = new DataGridViewTextBoxColumn();
            RznSocial = new DataGridViewTextBoxColumn();
            Fntsia = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            cont = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            btnConsulta = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtContato = new TextBox();
            txtCNPJ = new TextBox();
            txtFantasia = new TextBox();
            txtRazaoSocial = new TextBox();
            txtId = new TextBox();
            tabPage2 = new TabPage();
            dtgProdutoFornecedor = new DataGridView();
            IDProduto = new DataGridViewTextBoxColumn();
            CodBarra = new DataGridViewTextBoxColumn();
            Desc = new DataGridViewTextBoxColumn();
            IDFornecedor = new DataGridViewTextBoxColumn();
            forn = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn = new Button();
            dtgFornecedor1 = new DataGridView();
            IDFornecedordtg1 = new DataGridViewTextBoxColumn();
            Fant = new DataGridViewTextBoxColumn();
            dtgProduto = new DataGridView();
            IDProdutodtg1 = new DataGridViewTextBoxColumn();
            CDBar = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            txtFornecedorId = new TextBox();
            txtProdutoId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutoFornecedor).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProduto).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(883, 524);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtgFornecedor);
            tabPage1.Controls.Add(btnConsulta);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtContato);
            tabPage1.Controls.Add(txtCNPJ);
            tabPage1.Controls.Add(txtFantasia);
            tabPage1.Controls.Add(txtRazaoSocial);
            tabPage1.Controls.Add(txtId);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(875, 496);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgFornecedor
            // 
            dtgFornecedor.AllowUserToAddRows = false;
            dtgFornecedor.AllowUserToDeleteRows = false;
            dtgFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFornecedor.Columns.AddRange(new DataGridViewColumn[] { Identificação, RznSocial, Fntsia, cnpj, cont, Tel, mail });
            dtgFornecedor.Location = new Point(28, 319);
            dtgFornecedor.Name = "dtgFornecedor";
            dtgFornecedor.ReadOnly = true;
            dtgFornecedor.RowHeadersVisible = false;
            dtgFornecedor.Size = new Size(564, 150);
            dtgFornecedor.TabIndex = 17;
            // 
            // Identificação
            // 
            Identificação.Frozen = true;
            Identificação.HeaderText = "ID";
            Identificação.Name = "Identificação";
            Identificação.ReadOnly = true;
            // 
            // RznSocial
            // 
            RznSocial.Frozen = true;
            RznSocial.HeaderText = "Razão Social";
            RznSocial.Name = "RznSocial";
            RznSocial.ReadOnly = true;
            // 
            // Fntsia
            // 
            Fntsia.Frozen = true;
            Fntsia.HeaderText = "Fantasia";
            Fntsia.Name = "Fntsia";
            Fntsia.ReadOnly = true;
            // 
            // cnpj
            // 
            cnpj.Frozen = true;
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            // 
            // cont
            // 
            cont.Frozen = true;
            cont.HeaderText = "Contato";
            cont.Name = "cont";
            cont.ReadOnly = true;
            // 
            // Tel
            // 
            Tel.Frozen = true;
            Tel.HeaderText = "Telefone";
            Tel.Name = "Tel";
            Tel.ReadOnly = true;
            // 
            // mail
            // 
            mail.Frozen = true;
            mail.HeaderText = "Email";
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(459, 277);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(75, 23);
            btnConsulta.TabIndex = 16;
            btnConsulta.Text = "&Continuar";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(360, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(264, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "&Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 248);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 159);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 159);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Contato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 159);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 72);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 9;
            label3.Text = "Fantasia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Razão Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 72);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(384, 188);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(189, 188);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(176, 23);
            txtContato.TabIndex = 4;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(22, 188);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(146, 23);
            txtCNPJ.TabIndex = 3;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(384, 99);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(150, 23);
            txtFantasia.TabIndex = 2;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(147, 99);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(218, 23);
            txtRazaoSocial.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 99);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgProdutoFornecedor);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(875, 496);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgProdutoFornecedor
            // 
            dtgProdutoFornecedor.AllowUserToAddRows = false;
            dtgProdutoFornecedor.AllowUserToDeleteRows = false;
            dtgProdutoFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutoFornecedor.Columns.AddRange(new DataGridViewColumn[] { IDProduto, CodBarra, Desc, IDFornecedor, forn });
            dtgProdutoFornecedor.Location = new Point(121, 310);
            dtgProdutoFornecedor.Name = "dtgProdutoFornecedor";
            dtgProdutoFornecedor.ReadOnly = true;
            dtgProdutoFornecedor.RowHeadersVisible = false;
            dtgProdutoFornecedor.Size = new Size(651, 180);
            dtgProdutoFornecedor.TabIndex = 1;
            // 
            // IDProduto
            // 
            IDProduto.HeaderText = "ID do Produto";
            IDProduto.Name = "IDProduto";
            IDProduto.ReadOnly = true;
            IDProduto.Width = 150;
            // 
            // CodBarra
            // 
            CodBarra.HeaderText = "Código de Barras";
            CodBarra.Name = "CodBarra";
            CodBarra.ReadOnly = true;
            CodBarra.Width = 150;
            // 
            // Desc
            // 
            Desc.HeaderText = "Descrição";
            Desc.Name = "Desc";
            Desc.ReadOnly = true;
            // 
            // IDFornecedor
            // 
            IDFornecedor.HeaderText = "ID do Fornecedor";
            IDFornecedor.Name = "IDFornecedor";
            IDFornecedor.ReadOnly = true;
            IDFornecedor.Width = 150;
            // 
            // forn
            // 
            forn.HeaderText = "Nome Fantasia";
            forn.Name = "forn";
            forn.ReadOnly = true;
            forn.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn);
            groupBox1.Controls.Add(dtgFornecedor1);
            groupBox1.Controls.Add(dtgProduto);
            groupBox1.Controls.Add(txtFornecedorId);
            groupBox1.Controls.Add(txtProdutoId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(27, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 277);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn
            // 
            btn.Location = new Point(41, 246);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 6;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            // 
            // dtgFornecedor1
            // 
            dtgFornecedor1.AllowUserToAddRows = false;
            dtgFornecedor1.AllowUserToDeleteRows = false;
            dtgFornecedor1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFornecedor1.Columns.AddRange(new DataGridViewColumn[] { IDFornecedordtg1, Fant });
            dtgFornecedor1.Location = new Point(429, 90);
            dtgFornecedor1.Name = "dtgFornecedor1";
            dtgFornecedor1.ReadOnly = true;
            dtgFornecedor1.RowHeadersVisible = false;
            dtgFornecedor1.Size = new Size(353, 150);
            dtgFornecedor1.TabIndex = 5;
            // 
            // IDFornecedordtg1
            // 
            IDFornecedordtg1.HeaderText = "ID";
            IDFornecedordtg1.Name = "IDFornecedordtg1";
            IDFornecedordtg1.ReadOnly = true;
            // 
            // Fant
            // 
            Fant.HeaderText = "Fantasia";
            Fant.Name = "Fant";
            Fant.ReadOnly = true;
            Fant.Width = 250;
            // 
            // dtgProduto
            // 
            dtgProduto.AllowUserToAddRows = false;
            dtgProduto.AllowUserToDeleteRows = false;
            dtgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduto.Columns.AddRange(new DataGridViewColumn[] { IDProdutodtg1, CDBar, Descricao });
            dtgProduto.Location = new Point(39, 90);
            dtgProduto.Name = "dtgProduto";
            dtgProduto.ReadOnly = true;
            dtgProduto.RowHeadersVisible = false;
            dtgProduto.Size = new Size(353, 150);
            dtgProduto.TabIndex = 4;
            // 
            // IDProdutodtg1
            // 
            IDProdutodtg1.HeaderText = "ID";
            IDProdutodtg1.Name = "IDProdutodtg1";
            IDProdutodtg1.ReadOnly = true;
            // 
            // CDBar
            // 
            CDBar.HeaderText = "Código de Barra";
            CDBar.Name = "CDBar";
            CDBar.ReadOnly = true;
            CDBar.Width = 150;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // txtFornecedorId
            // 
            txtFornecedorId.Location = new Point(429, 48);
            txtFornecedorId.Name = "txtFornecedorId";
            txtFornecedorId.Size = new Size(146, 23);
            txtFornecedorId.TabIndex = 3;
            // 
            // txtProdutoId
            // 
            txtProdutoId.Location = new Point(37, 48);
            txtProdutoId.Name = "txtProdutoId";
            txtProdutoId.Size = new Size(146, 23);
            txtProdutoId.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(429, 27);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 1;
            label9.Text = "ID do Fornecedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 27);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 0;
            label8.Text = "ID do Produto";
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 548);
            Controls.Add(tabControl1);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProdutoFornecedor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtContato;
        private TextBox txtCNPJ;
        private TextBox txtFantasia;
        private TextBox txtRazaoSocial;
        private TextBox txtId;
        private Button btnConsulta;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dtgFornecedor;
        private DataGridViewTextBoxColumn Identificação;
        private DataGridViewTextBoxColumn RznSocial;
        private DataGridViewTextBoxColumn Fntsia;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn cont;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn mail;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private TextBox txtFornecedorId;
        private TextBox txtProdutoId;
        private Button btn;
        private DataGridView dtgFornecedor1;
        private DataGridView dtgProduto;
        private DataGridViewTextBoxColumn IDFornecedordtg1;
        private DataGridViewTextBoxColumn Fant;
        private DataGridViewTextBoxColumn IDProdutodtg1;
        private DataGridViewTextBoxColumn CDBar;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridView dtgProdutoFornecedor;
        private DataGridViewTextBoxColumn IDProduto;
        private DataGridViewTextBoxColumn CodBarra;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn IDFornecedor;
        private DataGridViewTextBoxColumn forn;
    }
}