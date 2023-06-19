using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCrowd
{
    internal class Challenge_2593
    {
        //Recebe um texto e um conjunto de palavras(strings de busca) e deve retornar 
        //a primeira posição da primeira letra de cada palavra que está presente no texto.
        //A primeira posição do texto deve ser a posição 0 (zero).
        //Você deve procurar apenas as palavras exatas (a palavra AMAR é diferente de progrAMAR).
        //    Entradas:
        //    Na primeira linha: O texto, que contém no mínimo 50 e no máximo 10.000 caracteres.
        //    Na segunda linha: A quantidade de palavras a serem lidas.Com no mínimo 1 e no máximo 128.
        //    Na terceira linha: As palavras separadas por espaço.
        //A mesma palavra pode estar repetida no texto. Caso isso ocorra, as posições devem ser 
        //impressas uma na frente da outra, separadas por espaços em branco.
        //Caso a palavra não esteja contida no texto, retorne -1.

        //static void Main(string[] args)
        //{
        //    string texto = Console.ReadLine();
        //    int quantPalavras = int.Parse(Console.ReadLine());
        //    string inputPalavras = Console.ReadLine();

        //    string[] palavras = inputPalavras.Split(' ');

        //    List<int> indicesAchados = new List<int>();

        //    foreach (string palavra in palavras)
        //    {
        //        indicesAchados.Clear();
        //        int indice = texto.IndexOf(palavra);

        //        if (indice == -1)
        //        {
        //            Console.WriteLine(-1);
        //        }
        //        else
        //        {
        //            while (indice != -1)
        //            {
        //                bool palavraCompleta = VerificarPalavraCompleta(texto, palavra, indice);

        //                if (palavraCompleta)
        //                {
        //                    indicesAchados.Add(indice);
        //                }

        //                indice = texto.IndexOf(palavra, indice + 1);
        //            }
        //            string indicesTexto = string.Join(" ", indicesAchados);
        //            Console.WriteLine(indicesTexto);
        //        }
        //    }
        //}

        private static bool VerificarPalavraCompleta(string texto, string palavra, int indice)
        {
            bool semLetraAntes = indice == 0 || !char.IsLetterOrDigit(texto[indice - 1]);
            bool semLetraDepois = (indice + palavra.Length == texto.Length) ||
                !char.IsLetterOrDigit(texto[indice + palavra.Length]);

            return semLetraAntes && semLetraDepois;
        }
    }
}
