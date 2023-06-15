using System;
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
            foreach (Produto item in listaProdutos)
            {
                Console.WriteLine(item.Nome + " " + item.Quantidade + " unidade(s)");
            }

            // alterando valor da lista
            lista[0] = "Tomate";

            // excluindo item da lista
            lista.RemoveAt(2); // por índice
            lista.Remove("Requeijão"); // por item

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

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
        }
    }
}