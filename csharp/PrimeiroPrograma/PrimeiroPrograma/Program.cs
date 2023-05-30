using System.Globalization;

Console.WriteLine("Hello, World!");

// TIPANDO em c#

int nota = 10;
// long, float, double, decimal, 'char', bool, "string", object

// NOMEANDO em c#

//camelCase -> parâmetros de métodos, variáveis dentro de métodos
//PascalCase -> namespaces, classes, properties e membros
//_lastName -> atributos internos da classe

//IMPRIMINDO em c#

Console.WriteLine("oi");
Console.Write("oi");    // não tem a quebra de linha

//cw tab tab -> preenche automatico

string nome = "gabi";
int idade = 25;
double saldo = 2000;

Console.WriteLine(nota.ToString("F2")); // 2 casas decimais
Console.WriteLine(nota.ToString("F2", CultureInfo.InvariantCulture)); // imprime com . ao invés de ,

Console.WriteLine("{0} tem {1} anos e {2:F2} reais", nome, idade, saldo); // placeholders e concatenação

Console.WriteLine($"{nome} tem {idade} anos e {saldo:F2} reais"); // interpolação

Console.WriteLine(nome + " tem " + idade + " anos e " + saldo.ToString("F2") + " reais"); // concatenação