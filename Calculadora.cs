namespace ClassesObjetos
{
    public class Calculadora
    {
        public void Somar(double numeroA, double numeroB)
        {
          Console.WriteLine($"Soma de {numeroA} + {numeroB}");
          Console.WriteLine(numeroA + numeroB);
        }

        public void Subtrair(double numeroA, double numeroB)
        {
          Console.WriteLine($"Subtração de {numeroA} - {numeroB}");
          Console.WriteLine(numeroA - numeroB);
        }
        
        public void Multiplicar(double numeroA, double numeroB)
        {
          Console.WriteLine($"Multiplicação de {numeroA} * {numeroB}");
          Console.WriteLine(numeroA * numeroB);
        }
        public static void Dividir(double numeroA, double numeroB)
        {
          Console.WriteLine($"Divisão de {numeroA} / {numeroB}");
          Console.WriteLine(numeroA / numeroB);
        }

    }
}