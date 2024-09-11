namespace SysPecNSDesk
{
    partial class FrmClienteBuscar
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            TELEFONE = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Data_nasc = new DataGridViewTextBoxColumn();
            Data_cad = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Cpf, TELEFONE, Email, Data_nasc, Data_cad, Ativo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(776, 320);
            dataGridView1.TabIndex = 17;
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
            // FrmClienteBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 320);
            Controls.Add(dataGridView1);
            Name = "FrmClienteBuscar";
            Text = "FrmClienteBuscar";
            Load += FrmClienteBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn TELEFONE;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Data_nasc;
        private DataGridViewTextBoxColumn Data_cad;
        private DataGridViewCheckBoxColumn Ativo;
    }
}