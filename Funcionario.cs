using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public void AumentarSalario(int percentual)
        {
            if (percentual > 0)
            {
                double aumento = Salario * (percentual / 100);
                Salario += aumento;
            }
            else
            {
                Console.Write("\nPercentual inválido\n");
            }
        }

        public void ConsultarSalario()
        {
            Console.Write("--- Aumento final ---\n");
            Console.WriteLine($"{Salario}");
        }
    }
}