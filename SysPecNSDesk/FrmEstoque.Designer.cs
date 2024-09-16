namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            txtId = new TextBox();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            btnInsere = new Button();
            textBox4 = new TextBox();
            dvgProdutos = new DataGridView();
            label01 = new Label();
            txtUnidadeVenda = new TextBox();
            txtEstoqueMin = new TextBox();
            txtDisponivelEstoque = new TextBox();
            textBox8 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDesc = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCat = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(32, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(139, 105);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(180, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(32, 105);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(80, 23);
            txtCodBar.TabIndex = 2;
            // 
            // btnInsere
            // 
            btnInsere.Location = new Point(468, 168);
            btnInsere.Name = "btnInsere";
            btnInsere.Size = new Size(75, 23);
            btnInsere.TabIndex = 4;
            btnInsere.Text = "&Alterar";
            btnInsere.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(531, 23);
            textBox4.TabIndex = 6;
            // 
            // dvgProdutos
            // 
            dvgProdutos.AllowUserToAddRows = false;
            dvgProdutos.AllowUserToDeleteRows = false;
            dvgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnDesc, clnValorUnit, clnUnidadeVenda, clnCat, clnEstoqueMin });
            dvgProdutos.Location = new Point(12, 255);
            dvgProdutos.Name = "dvgProdutos";
            dvgProdutos.ReadOnly = true;
            dvgProdutos.Size = new Size(531, 170);
            dvgProdutos.TabIndex = 7;
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Location = new Point(32, 40);
            label01.Name = "label01";
            label01.Size = new Size(18, 15);
            label01.TabIndex = 8;
            label01.Text = "ID";
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(344, 105);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(178, 23);
            txtUnidadeVenda.TabIndex = 9;
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(32, 168);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.Size = new Size(80, 23);
            txtEstoqueMin.TabIndex = 10;
            // 
            // txtDisponivelEstoque
            // 
            txtDisponivelEstoque.Location = new Point(139, 168);
            txtDisponivelEstoque.Name = "txtDisponivelEstoque";
            txtDisponivelEstoque.Size = new Size(180, 23);
            txtDisponivelEstoque.TabIndex = 11;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(344, 168);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(102, 23);
            textBox8.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 87);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 13;
            label1.Text = "Cód. Barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 87);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 14;
            label2.Text = "Descrição Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 87);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 15;
            label3.Text = "Unidade Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 150);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 16;
            label4.Text = "Estoque Mín.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 150);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 17;
            label5.Text = "Quantidade em Estoque";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 150);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 18;
            label6.Text = "Entrada";
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnCodBar
            // 
            clnCodBar.HeaderText = "Código de Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 150;
            // 
            // clnDesc
            // 
            clnDesc.HeaderText = "Descrição";
            clnDesc.Name = "clnDesc";
            clnDesc.ReadOnly = true;
            clnDesc.Width = 150;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 150;
            // 
            // clnCat
            // 
            clnCat.HeaderText = "Categoria";
            clnCat.Name = "clnCat";
            clnCat.ReadOnly = true;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.HeaderText = "Estoque Minímo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 150;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 437);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(txtDisponivelEstoque);
            Controls.Add(txtEstoqueMin);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(label01);
            Controls.Add(dvgProdutos);
            Controls.Add(textBox4);
            Controls.Add(btnInsere);
            Controls.Add(txtCodBar);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private NumericUpDown numericUpDown1;
        private Button btnInsere;
        private Button button2;
        private TextBox textBox4;
        private DataGridView dvgProdutos;
        private Label label01;
        private TextBox txtUnidadeVenda;
        private TextBox txtEstoqueMin;
        private TextBox txtDisponivelEstoque;
        private TextBox textBox8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDesc;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCat;
        private DataGridViewTextBoxColumn clnEstoqueMin;
    }
}