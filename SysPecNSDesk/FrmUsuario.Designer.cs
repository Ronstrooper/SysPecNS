namespace SysPecNSDesk
{
    partial class FrmUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btnInserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            cmbNivel = new ComboBox();
            txtSenha = new TextBox();
            label6 = new Label();
            txtConfSenha = new TextBox();
            chkAtivo = new CheckBox();
            btnEditar = new Button();
            btnDeletar = new Button();
            txtBusca = new TextBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(152, 408);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 9;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btnInserir
            // 
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.Cursor = Cursors.Hand;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnInserir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnInserir.ForeColor = SystemColors.ControlText;
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.Location = new Point(188, 207);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 72);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 40);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 40);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 93);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 93);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "Nivel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 142);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "Senha";
            // 
            // txtId
            // 
            txtId.Location = new Point(242, 58);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(332, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(228, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(242, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 23);
            txtEmail.TabIndex = 1;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(439, 111);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 2;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(245, 160);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(75, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 142);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 15;
            label6.Text = "Confirma Senha";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(332, 160);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(92, 23);
            txtConfSenha.TabIndex = 4;
            txtConfSenha.UseSystemPasswordChar = true;
            txtConfSenha.TextChanged += textBox5_TextChanged;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(439, 164);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 16;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnEditar.Location = new Point(308, 207);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 72);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnDeletar.Location = new Point(428, 207);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 72);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "De&letar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(152, 367);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 8;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(543, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 72);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmUsuario
            // 
            AcceptButton = btnInserir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnCancelar;
            ClientSize = new Size(803, 604);
            Controls.Add(btnCancelar);
            Controls.Add(txtBusca);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(chkAtivo);
            Controls.Add(txtConfSenha);
            Controls.Add(label6);
            Controls.Add(txtSenha);
            Controls.Add(cmbNivel);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInserir);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btnInserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private ComboBox cmbNivel;
        private TextBox txtSenha;
        private Label label6;
        private TextBox txtConfSenha;
        private CheckBox chkAtivo;
        private Button btnEditar;
        private Button btnDeletar;
        private TextBox txtBusca;
        private Button btnCancelar;
    }
}