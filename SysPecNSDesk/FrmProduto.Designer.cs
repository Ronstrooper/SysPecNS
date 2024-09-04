namespace SysPecNSDesk
{
    partial class FrmProduto
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
            components = new System.ComponentModel.Container();
            txtId = new TextBox();
            label1 = new Label();
            Produtos = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            label8 = new Label();
            txtDesconto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            label5 = new Label();
            npEstoqueMinimo = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUnidadeVenda = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCódigo = new DataGridViewTextBoxColumn();
            clnDes = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnUnidade = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoque = new DataGridViewTextBoxColumn();
            clsClasseDesc = new DataGridViewTextBoxColumn();
            clnImagem = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            label9 = new Label();
            Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(24, 47);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(76, 23);
            txtId.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // Produtos
            // 
            Produtos.Controls.Add(btnConsultar);
            Produtos.Controls.Add(btnEditar);
            Produtos.Controls.Add(btnAdicionar);
            Produtos.Controls.Add(label8);
            Produtos.Controls.Add(txtDesconto);
            Produtos.Controls.Add(label7);
            Produtos.Controls.Add(label6);
            Produtos.Controls.Add(cmbCategoria);
            Produtos.Controls.Add(txtDescricao);
            Produtos.Controls.Add(label5);
            Produtos.Controls.Add(npEstoqueMinimo);
            Produtos.Controls.Add(label4);
            Produtos.Controls.Add(label3);
            Produtos.Controls.Add(label2);
            Produtos.Controls.Add(txtUnidadeVenda);
            Produtos.Controls.Add(txtValorUnit);
            Produtos.Controls.Add(txtCodBar);
            Produtos.Controls.Add(txtId);
            Produtos.Controls.Add(label1);
            Produtos.Location = new Point(65, 69);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(676, 273);
            Produtos.TabIndex = 2;
            Produtos.TabStop = false;
            Produtos.Text = "Produtos";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(348, 217);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(249, 217);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(150, 217);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 200);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 15;
            label8.Text = "Desconto";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(24, 218);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 140);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 26);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 12;
            label6.Text = "Descrição";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(25, 161);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(342, 23);
            cmbCategoria.TabIndex = 5;
            cmbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(302, 47);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(234, 23);
            txtDescricao.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 85);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Estoque Mínimo";
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(348, 106);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(50, 23);
            npEstoqueMinimo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 84);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Unidade de Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 86);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor unitário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 29);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Código de barras";
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(186, 106);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(125, 23);
            txtUnidadeVenda.TabIndex = 3;
            txtUnidadeVenda.Text = "Ex. Caixa";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(24, 106);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(130, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(134, 47);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(124, 23);
            txtCodBar.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCódigo, clnDes, clnValor, clnUnidade, clnCategoria, clnEstoque, clsClasseDesc, clnImagem, clnDataCad });
            dgvProdutos.Location = new Point(68, 360);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.RowHeadersWidth = 10;
            dgvProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProdutos.Size = new Size(673, 150);
            dgvProdutos.TabIndex = 3;
            dgvProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCódigo
            // 
            clnCódigo.HeaderText = "Código de Barras";
            clnCódigo.Name = "clnCódigo";
            clnCódigo.ReadOnly = true;
            clnCódigo.Width = 150;
            // 
            // clnDes
            // 
            clnDes.HeaderText = "Descrição";
            clnDes.Name = "clnDes";
            clnDes.ReadOnly = true;
            clnDes.Width = 150;
            // 
            // clnValor
            // 
            clnValor.HeaderText = "Valor Unitário";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            clnValor.Width = 150;
            // 
            // clnUnidade
            // 
            clnUnidade.HeaderText = "Unidade Venda";
            clnUnidade.Name = "clnUnidade";
            clnUnidade.ReadOnly = true;
            clnUnidade.Width = 150;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria ID";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoque
            // 
            clnEstoque.HeaderText = "Estoque Mínimo";
            clnEstoque.Name = "clnEstoque";
            clnEstoque.ReadOnly = true;
            clnEstoque.Width = 150;
            // 
            // clsClasseDesc
            // 
            clsClasseDesc.HeaderText = "Classe Desconto";
            clsClasseDesc.Name = "clsClasseDesc";
            clsClasseDesc.ReadOnly = true;
            clsClasseDesc.Width = 150;
            // 
            // clnImagem
            // 
            clnImagem.HeaderText = "Imagem";
            clnImagem.Name = "clnImagem";
            clnImagem.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 150;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(352, 18);
            label9.Name = "label9";
            label9.Size = new Size(136, 39);
            label9.TabIndex = 4;
            label9.Text = "Produtos";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(label9);
            Controls.Add(dgvProdutos);
            Controls.Add(Produtos);
            Name = "FrmProduto";
            Text = "FormProdutos";
            Produtos.ResumeLayout(false);
            Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private GroupBox Produtos;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUnidadeVenda;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Label label8;
        private TextBox txtDesconto;
        private Label label7;
        private Label label6;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private Label label5;
        private NumericUpDown npEstoqueMinimo;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvProdutos;
        private Label label9;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCódigo;
        private DataGridViewTextBoxColumn clnDes;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnUnidade;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoque;
        private DataGridViewTextBoxColumn clsClasseDesc;
        private DataGridViewTextBoxColumn clnImagem;
        private DataGridViewTextBoxColumn clnDataCad;
    }
}