using SysPecNSLib;

namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá TI96");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && cmbOperacao.SelectedIndex > 4)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero1 = 0;
            if (textBox1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(textBox1.Text);
            }

            double numero2 = 0;
            if (posicaoOperacao < 5)
            {
                if (txtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                }
            }
            double resultado = 0;
            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Sqrt(numero1);
                    break;
                case 6:
                    resultado = Math.Log(numero1);
                    break;
                default:
                    break;
            }
            lsResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}");
            textBox1.Clear();
            txtNumero2.Clear();
            textBox1.Focus();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e) //botão confirmar
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = true;
            }
            else
            {
                txtNumero2.Enabled = false;
            }
            textBox1.Clear(); //limpar caixa
            txtNumero2.Clear();
            textBox1.Focus();// barra piscando
            txtNumero2.Enabled = true;
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(textBox2.Text, textBox3.Text);
            nivel.Inserir();
            MessageBox.Show("Nível gravado com sucesso");
            button2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
