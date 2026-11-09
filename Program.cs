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

n1.Somar(3, 5);
n1.Subtrair(3, 5);
n1.Multiplicar(3, 5);
Calculadora.Dividir(4, 2);

/*3. Propriedades com validação*/

Veiculo v1 = new Veiculo();

v1.Velocidade = 210;
//Revisar 3

/*4. Propriedades e controle de acesso*/

Funcionario f1 = new Funcionario("Heloísa", "Chefe", 5000.00);

// f1.Salario = "2000.00"
// O salario não pode ser mudado pois sua escrita é privada

f1.AumentarSalario(200);
f1.ConsultarSalario();

/*5. Construtores e sobrecarga*/

Livro l1 = new Livro();
Livro l2 = new Livro("A Hora da Estrela");
Livro l3 = new Livro("Dom Casmurro", "Machado de Assis");
Livro l4 = new Livro("Capitães de Areia", "Jorge Amado ", 280);

l1.ExibirDados();
l2.ExibirDados();
l3.ExibirDados();
l4.ExibirDados();





