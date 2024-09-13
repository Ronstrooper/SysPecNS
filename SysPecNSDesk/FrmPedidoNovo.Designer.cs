namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoNovo));
            grbIdentificacao = new GroupBox();
            button2 = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            txtNomeClientes = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            label4 = new Label();
            txtTotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItens = new TextBox();
            txtQuantidadeItem = new TextBox();
            txtValorUnitItem = new TextBox();
            txtCodBar = new TextBox();
            txtDescricaoItem = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSrq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            textBox4 = new TextBox();
            txtDescontodoPedido = new TextBox();
            textBox2 = new TextBox();
            btnFechar = new Button();
            txtSubTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(button2);
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(txtNomeClientes);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Location = new Point(38, 65);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(619, 166);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(25, 98);
            button2.Name = "button2";
            button2.Size = new Size(116, 39);
            button2.TabIndex = 4;
            button2.Text = "Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCliente_Click;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(481, 51);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 64);
            btnInserePedido.TabIndex = 1;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(161, 110);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(66, 27);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // txtNomeClientes
            // 
            txtNomeClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeClientes.Location = new Point(238, 110);
            txtNomeClientes.Name = "txtNomeClientes";
            txtNomeClientes.Size = new Size(199, 27);
            txtNomeClientes.TabIndex = 1;
            txtNomeClientes.TextChanged += textBox3_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(161, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(276, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 51);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(label4);
            grbItens.Controls.Add(txtTotal);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItens);
            grbItens.Controls.Add(txtQuantidadeItem);
            grbItens.Controls.Add(txtValorUnitItem);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricaoItem);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(38, 237);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(619, 342);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(401, 67);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 14;
            label4.Text = "R$";
            label4.Click += label4_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.Navy;
            txtTotal.Location = new Point(500, 293);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 33);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(401, 301);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 19);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 19);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 10;
            label8.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 19);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 19);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 19);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(401, 37);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.RightToLeft = RightToLeft.Yes;
            txtDescontoItens.Size = new Size(70, 23);
            txtDescontoItens.TabIndex = 4;
            txtDescontoItens.Text = "0";
            // 
            // txtQuantidadeItem
            // 
            txtQuantidadeItem.Location = new Point(316, 37);
            txtQuantidadeItem.Name = "txtQuantidadeItem";
            txtQuantidadeItem.RightToLeft = RightToLeft.Yes;
            txtQuantidadeItem.Size = new Size(70, 23);
            txtQuantidadeItem.TabIndex = 3;
            txtQuantidadeItem.Text = "1";
            txtQuantidadeItem.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnitItem
            // 
            txtValorUnitItem.Location = new Point(238, 37);
            txtValorUnitItem.Name = "txtValorUnitItem";
            txtValorUnitItem.Size = new Size(72, 23);
            txtValorUnitItem.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(9, 37);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(95, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtDescricaoItem
            // 
            txtDescricaoItem.Location = new Point(110, 37);
            txtDescricaoItem.Name = "txtDescricaoItem";
            txtDescricaoItem.Size = new Size(122, 23);
            txtDescricaoItem.TabIndex = 1;
            txtDescricaoItem.TextChanged += txtDescricao_TextChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(500, 37);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 33);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSrq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(0, 94);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(608, 193);
            dgvItensPedido.TabIndex = 0;
            dgvItensPedido.CellContentClick += dgvItensPedido_CellContentClick;
            // 
            // clnSrq
            // 
            clnSrq.Frozen = true;
            clnSrq.HeaderText = "#SEQ";
            clnSrq.Name = "clnSrq";
            clnSrq.ReadOnly = true;
            clnSrq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 180;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 60;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 14);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(552, 9);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(220, 23);
            txtIdPedido.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(663, 474);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox2_TextChanged;
            // 
            // txtDescontodoPedido
            // 
            txtDescontodoPedido.Location = new Point(663, 428);
            txtDescontodoPedido.Name = "txtDescontodoPedido";
            txtDescontodoPedido.Size = new Size(100, 23);
            txtDescontodoPedido.TabIndex = 6;
            txtDescontodoPedido.Text = "0";
            txtDescontodoPedido.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(663, 372);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(676, 523);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 33);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(663, 328);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(687, 304);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 11;
            label11.Text = "Sub Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(662, 354);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 12;
            label12.Text = "Desconto Itens R$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(678, 410);
            label13.Name = "label13";
            label13.Size = new Size(73, 15);
            label13.TabIndex = 13;
            label13.Text = "Desconto R$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(697, 454);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 14;
            label14.Text = "Total ";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 592);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSubTotal);
            Controls.Add(btnFechar);
            Controls.Add(textBox2);
            Controls.Add(txtDescontodoPedido);
            Controls.Add(textBox4);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdPedido;
        private TextBox txtUsuario;
        private TextBox txtNomeClientes;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItens;
        private TextBox txtQuantidadeItem;
        private TextBox txtValorUnitItem;
        private TextBox txtCodBar;
        private TextBox txtDescricaoItem;
        private Label label9;
        private Label label8;
        private TextBox txtTotal;
        private Label label10;
        private TextBox textBox4;
        private TextBox txtDescontodoPedido;
        private TextBox textBox2;
        private Button btnFechar;
        private TextBox txtSubTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSrq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Button button2;
        private Label label4;
    }
}