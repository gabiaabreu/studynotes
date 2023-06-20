using System;
using System.Collections;
using System.Collections.Generic;

namespace EstruturaDeDados
{
    class Program
    {
        static void Main(string[] args) // só pode existir um método Main (entry point) em cada solution
        {
            /*
             * 
             * 
             * LISTA
             * 
             * 
             */

            // lista de strings
            List<string> lista = new List<string>();

            lista.Add("Cenoura");
            lista.Add("Abobrinha");
            lista.Add("Pão");
            lista.Add("Requeijão");

            // lista de Produtos
            List<Produto> listaProdutos = new List<Produto>();

            Produto primeiroProduto = new Produto()
            {
                Nome = "Batata",
                Quantidade = 5
            };

            Produto segundoProduto = new Produto();
            segundoProduto.Nome = "Repolho";
            segundoProduto.Quantidade = 1;

            listaProdutos.Add(primeiroProduto);
            listaProdutos.Add(segundoProduto);

            // imprimindo valores da lista
            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine(produto.Nome + " " + produto.Quantidade + " unidade(s)");
            }

            // alterando valor da lista
            lista[0] = "Tomate";

            // excluindo item da lista
            lista.RemoveAt(2); // por índice
            lista.Remove("Requeijão"); // por item

            // acessando valor da lista
            string meuItem = lista[1];
            Console.WriteLine(meuItem); // Abobrinha

            /*
             * 
             * 
             * MAPA/DICIONÁRIO
             * 
             * 
             */

            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "A"},
                {2, "B"},
                {3, "C"},
                {4, "D"},
                {5, "E"},
            };

            // adicionando item
            dict.Add(6, "G");

            // alterando item
            dict[6] = "F"; // atenção, o 6 não é o índice e sim a chave

            // verificando se possui valor x
            Console.WriteLine(dict.ContainsKey(6));
            Console.WriteLine(dict.ContainsValue("G"));

            // exibindo todos os valores
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("chave: {0} valor: {1}", item.Key, item.Value);
            }

            foreach (var valor in dict.Values)
            {
                Console.WriteLine(valor);
            }

            // exibindo valor específico
            string valorProcurado;
            if (dict.TryGetValue(8, out valorProcurado))
            {
                Console.WriteLine(valorProcurado);
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar o valor");
            }

            // acessando valor
            string value = dict[4];

            /*
            * 
            * 
            * FILA
            * First In First Out
            * 
            * 
            */

            Queue<string> fila = new Queue<string>();

            // inserindo valores
            fila.Enqueue("Gabi");
            fila.Enqueue("Matheus");
            fila.Enqueue("Daniela");

            // acessando primeiro item da fila
            Console.WriteLine(fila.Peek()); // Gabi

            // removendo item
            fila.Dequeue(); // tira Gabi

            // contando itens
            Console.WriteLine(fila.Count()); // 2

            // exibindo itens
            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa); // Matheus Daniela
            }

            /*
            * 
            * 
            * PILHA
            * Last In First Out
            * 
            * 
            */

            Stack<string> pilhaGenerica = new Stack<string>();
            // a pilha genérica é obrigatoriamente tipada

            Stack pilhaNaoGenerica = new Stack();
            // a pilha não genérica é dinamicamente tipada, pode armazenar vários tipos
            // ao retirar objeto da pilha, necessário fazer conversão de tipo 
            // usa System.Collections

            // adicionando itens
            pilhaGenerica.Push("Mcdonalds");

            pilhaNaoGenerica.Push("Burger King");
            pilhaNaoGenerica.Push(49);
            pilhaNaoGenerica.Push(1.20);

            // retirando último item
            string valorRetirado = pilhaGenerica.Pop();

            double valorRetiradoDnv = (double)pilhaNaoGenerica.Pop();

            // imprimindo valores
            foreach (string valor in pilhaGenerica)
            {
                Console.WriteLine(valor);
            }

            foreach (var valor in pilhaNaoGenerica)
            {
                Console.WriteLine(valor);
            }

            // acessando último valor
            pilhaGenerica.Peek();

            /* Se você deseja acessar outros elementos da não há um método específico para fazer isso diretamente.
            A natureza da pilha é que você só tem acesso ao elemento do topo. Para acessar outros elementos, 
            você precisará remover os elementos superiores usando o método Pop() até chegar ao elemento desejado. */

            // Remover elementos até chegar ao elemento desejado
            Stack<int> pilhaExemplo = new Stack<int>();
            int thing;
            while (pilhaExemplo.Count > 0)
            {
                thing = pilhaExemplo.Pop();
                if (thing == 20)
                {
                    Console.WriteLine(thing); // Saída: 20
                    break;
                }
            }
        }
    }
}