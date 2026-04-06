namespace BibliotecaDeDesconto
{
    public class CalculadoraDesconto
    {
        public double AplicarDesconto(double valor, double percentual)
        {
            return valor - (valor * percentual / 100);
        }

        public double CalcularFrete(double peso, double distanciaKm)
        {
            return peso * distanciaKm * 0.05;
        }
    }
}