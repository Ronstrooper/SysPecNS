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
            txtNome = new TextBox();
            txtId = new TextBox();
            btnInserir = new Button();
            tabEndereco = new TabPage();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            dtmDataNasc = new DateTimePicker();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewCheckBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabEndereco);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 436);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(dtmDataNasc);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(157, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(259, 23);
            txtNome.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(30, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(246, 155);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // tabEndereco
            // 
            tabEndereco.Controls.Add(dataGridView1);
            tabEndereco.Controls.Add(textBox3);
            tabEndereco.Location = new Point(4, 24);
            tabEndereco.Name = "tabEndereco";
            tabEndereco.Padding = new Padding(3);
            tabEndereco.Size = new Size(791, 408);
            tabEndereco.TabIndex = 1;
            tabEndereco.Text = "Endereco";
            tabEndereco.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 120);
            dataGridView1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(437, 34);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(259, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(246, 105);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(170, 23);
            txtTelefone.TabIndex = 5;
            // 
            // dtmDataNasc
            // 
            dtmDataNasc.Location = new Point(437, 106);
            dtmDataNasc.Name = "dtmDataNasc";
            dtmDataNasc.Size = new Size(259, 23);
            dtmDataNasc.TabIndex = 6;
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(31, 161);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 16);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 16);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 10;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 88);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 88);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 88);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 13;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 143);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 14;
            label7.Text = "Ativo";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(31, 184);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(728, 23);
            textBox6.TabIndex = 15;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView2.Location = new Point(31, 213);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(727, 192);
            dataGridView2.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "NOME";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "CPF";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "TELEFONE";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Data de Nascimento";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cadastro";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ativo";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 50;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(tabControl1);
            Name = "FrmClientes";
            Text = "Cliente";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabEndereco.ResumeLayout(false);
            tabEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabEndereco;
        private TextBox txtNome;
        private TextBox txtId;
        private Button btnInserir;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private DateTimePicker dtmDataNasc;
        private TextBox txtTelefone;
        private Label label1;
        private CheckBox checkBox1;
        private DataGridView dataGridView2;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewCheckBoxColumn Column8;
    }
}