

namespace Calculadora2._0.WinApp
{
    public class Calculadora
    {
        public decimal primeiroNumero;
        public decimal segundoNumero;
        public char operacao;

        public string Calcular()
        {
            decimal resultado = 0;

            switch (operacao)
            {
                case '+': resultado = primeiroNumero + segundoNumero; break;
                case '-': resultado = primeiroNumero - segundoNumero; break;
                case '*': resultado = primeiroNumero * segundoNumero; break;
                case '/': resultado = primeiroNumero / segundoNumero; break;
            }

            return Math.Round(resultado, 2).ToString();
        }

        internal void Reset()
        {
            primeiroNumero = 0;
            segundoNumero = 0;
            operacao = char.MinValue;
        }
    }
}
