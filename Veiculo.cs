namespace ClassesObjetos
{
    public class Veiculo
    {
        private double velocidade;
        public double Velocidade
        {
            get
            {
                return velocidade;
            }

            set
            {
                if (value >= 0 && value <= 200)
                {
                    velocidade = value;
                    Console.WriteLine($"{velocidade}Km/h");
                }
                else
                {
                    value = velocidade;
                    Console.WriteLine($"{value}Km/h");
                }
            }
        }
    }
}