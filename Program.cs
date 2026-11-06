using ClassesObjetos;

/*1. Apresentação de pessoas*/
Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.Idade = 17;
p1.Cidade = "São Paulo";

p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Victor";
p2.Idade = 17;
p2.Cidade = "São Caetano";

p2.Apresentar();

/*2. Métodos de instância e métodos estáticos*/

Calculadora n1 = new Calculadora();

n1.Somar(3,5);
n1.Subtrair(3,5);
n1.Multiplicar(3,5);
Calculadora.Dividir(4,2);
