namespace SysPecNSDesk
{
    partial class Cliente
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
            groupBox1 = new GroupBox();
            tabCliente = new TabControl();
            tabPage1 = new TabPage();
            tabEndereco = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            tabCliente.SuspendLayout();
            tabPage1.SuspendLayout();
            tabEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPage1);
            tabCliente.Controls.Add(tabEndereco);
            tabCliente.Location = new Point(188, 27);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(573, 390);
            tabCliente.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(565, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabEndereco
            // 
            tabEndereco.Controls.Add(dataGridView1);
            tabEndereco.Controls.Add(textBox3);
            tabEndereco.Location = new Point(4, 24);
            tabEndereco.Name = "tabEndereco";
            tabEndereco.Padding = new Padding(3);
            tabEndereco.Size = new Size(565, 362);
            tabEndereco.TabIndex = 1;
            tabEndereco.Text = "Endereco";
            tabEndereco.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(42, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 120);
            dataGridView1.TabIndex = 1;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabCliente);
            Controls.Add(groupBox1);
            Name = "Cliente";
            Text = "Cliente";
            tabCliente.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabEndereco.ResumeLayout(false);
            tabEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabCliente;
        private TabPage tabPage1;
        private TabPage tabEndereco;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox3;
        private DataGridView dataGridView1;
    }
}