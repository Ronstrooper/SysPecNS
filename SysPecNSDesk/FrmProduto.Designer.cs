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
            textBox1 = new TextBox();
            label1 = new Label();
            Produtos = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cmbCategoria = new ComboBox();
            textBox5 = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 23);
            textBox1.TabIndex = 0;
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
            Produtos.Controls.Add(textBox6);
            Produtos.Controls.Add(label7);
            Produtos.Controls.Add(label6);
            Produtos.Controls.Add(cmbCategoria);
            Produtos.Controls.Add(textBox5);
            Produtos.Controls.Add(label5);
            Produtos.Controls.Add(numericUpDown1);
            Produtos.Controls.Add(label4);
            Produtos.Controls.Add(label3);
            Produtos.Controls.Add(label2);
            Produtos.Controls.Add(textBox4);
            Produtos.Controls.Add(textBox3);
            Produtos.Controls.Add(textBox2);
            Produtos.Controls.Add(textBox1);
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
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(249, 217);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(150, 217);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
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
            // textBox6
            // 
            textBox6.Location = new Point(24, 218);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 147);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 145);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 12;
            label6.Text = "Descrição";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(181, 166);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(437, 23);
            cmbCategoria.TabIndex = 11;
            cmbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(24, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(124, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 86);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Estoque Mínimo";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(486, 107);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 85);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Unidade de Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 87);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor unitário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Código de barras";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(330, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Ex. Caixa";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 2;
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
            clnCategoria.Width = 50;
            // 
            // clnEstoque
            // 
            clnEstoque.HeaderText = "Estoque Mínimo";
            clnEstoque.Name = "clnEstoque";
            clnEstoque.ReadOnly = true;
            clnEstoque.Width = 50;
            // 
            // clsClasseDesc
            // 
            clsClasseDesc.HeaderText = "Classe Desconto";
            clsClasseDesc.Name = "clsClasseDesc";
            clsClasseDesc.ReadOnly = true;
            clsClasseDesc.Width = 50;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private GroupBox Produtos;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private ComboBox cmbCategoria;
        private TextBox textBox5;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvProdutos;
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
        private Label label9;
    }
}