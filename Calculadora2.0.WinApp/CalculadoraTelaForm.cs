namespace Calculadora2._0.WinApp
{
    public partial class CalculadoraTelaForm : Form
    {
        private Calculadora calculadora;
        public CalculadoraTelaForm()
        {
            InitializeComponent();

            calculadora = new Calculadora();
            ConfigurarBotoes();
        }

        private void ConfigurarBotoes()
        {
            btn1.Click += AtribuirNumero;
            btn2.Click += AtribuirNumero;
            btn3.Click += AtribuirNumero;
            btn4.Click += AtribuirNumero;
            btn5.Click += AtribuirNumero;
            btn6.Click += AtribuirNumero;
            btn7.Click += AtribuirNumero;
            btn8.Click += AtribuirNumero;
            btn9.Click += AtribuirNumero;
            btn0.Click += AtribuirNumero;

            btnSomar.Click += RegistrarOperacao;
            btnSubtrair.Click += RegistrarOperacao;
            btnDividir.Click += RegistrarOperacao;
            btnMultiplicar.Click += RegistrarOperacao;

            btnIgual.Click += ExecutarCalculo;
        }

        private void AtribuirNumero(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            txtNumeros.Text += botaoClicado.Text;
        }

        private void RegistrarOperacao(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeros.Text))
                return;

            calculadora.primeiroNumero = Convert.ToDecimal(txtNumeros.Text);

            Button botaoClicado = (Button)sender;

            calculadora.operacao = Convert.ToChar(botaoClicado.Tag);

            txtCalculo.Text = txtNumeros.Text + " " + botaoClicado.Text;

            txtNumeros.Text = "";
        }

        private void ExecutarCalculo(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeros.Text))
                return;

            // precisamos do primeiro número

            // precisamos da operação selecionada

            //precisamos do segundo número

            calculadora.segundoNumero = Convert.ToDecimal(txtNumeros.Text);

            try
            {
                txtCalculo.Text = calculadora.Calcular();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Segundo número inválido");
            }

            txtNumeros.Text = "";
        }

        private void Limpar(object? sender, EventArgs e)
        {
            txtNumeros.ResetText();
            txtCalculo.ResetText();

            calculadora.Reset();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}