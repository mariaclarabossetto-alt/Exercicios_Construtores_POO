using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public string Carga {get; set;}
        public double Salario {get; private set;}

        public void AumentarSalario(int percentual)
        {
            Console.Write("Aumento");
            Console.WriteLine(Salario*percentual);
        }
    }
}