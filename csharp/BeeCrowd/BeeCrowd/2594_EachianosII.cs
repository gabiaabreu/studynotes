using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeeCrowd
{
    internal class Challenge_2594
    {
        //Recebe uma lista de pequenos textos seguidos de palavras (strings de busca) 
        //e deve retornar a primeira posição dessas palavras em cada texto.
        //Você deve procurar apenas as palavras exatas.
        //Entrada:
        //    Na primeira linha: A quantidade de textos (2 ≤ q ≤ 100.000) a serem lidos, 
        //    que também será a mesma quantidade de palavras a serem buscadas em cada texto.
        //    Em outras palavras, será fornecida uma palavra para cada texto.

        //    Nas linhas seguintes, para cada entrada, o programa irá receber, consecutivamente:
        //        O texto de no mínimo 10 e no máximo 128 caracteres;
        //        A palavra a ser buscada. Uma palavra nunca será maior que o texto.
        //Saída:
        //    Para cada par texto/palavra de busca, deve ser impressa uma linha com a lista das 
        //    posições da primeira letra onde a palavra está localizada no respectivo texto.
        //    Caso a palavra não esteja contida no texto, retorne -1

        //static void Main(string[] args)
        //{
        //    int N = int.Parse(Console.ReadLine()); // quantidade de textos e de palavras (1 pra cada)

        //    List<int> indicesAchados = new List<int>();
        //    List<string> resultados = new List<string>();

        //    for (int i = 0; i < N; i++)
        //    {
        //        indicesAchados.Clear();
        //        string texto = Console.ReadLine();
        //        string palavra = Console.ReadLine();

        //        int indice = texto.IndexOf(palavra);
        //        if (indice == -1)
        //        {
        //            indicesAchados.Add(-1);
        //        }

        //        while (indice != -1)
        //        {
        //            bool palavraCompleta = VerificarPalavraCompleta(texto, palavra, indice);
        //            if (palavraCompleta)
        //            {
        //                if (indicesAchados.Contains(-1))
        //                {
        //                    indicesAchados.RemoveAll(x => x == -1);
        //                }
        //                indicesAchados.Add(indice);
        //            }
        //            else
        //            {
        //                if (indicesAchados.Count == 0)
        //                {
        //                    indicesAchados.Add(-1);
        //                }
        //            }
        //            indice = texto.IndexOf(palavra, indice + 1);
        //        }
        //        resultados.Add(string.Join(" ", indicesAchados));
        //    }
        //    foreach (string resultado in resultados)
        //    {
        //        Console.WriteLine(resultado);
        //    }
        //}

        //private static bool VerificarPalavraCompleta(string texto, string palavra, int indice)
        //{
        //    bool semLetraAntes = indice == 0 || !char.IsLetterOrDigit(texto[indice - 1]);
        //    bool semLetraDepois = (indice + palavra.Length == texto.Length) ||
        //        !char.IsLetterOrDigit(texto[indice + palavra.Length]);

        //    return semLetraAntes && semLetraDepois;
        //}
    }
}
