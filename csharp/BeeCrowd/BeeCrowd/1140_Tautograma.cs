using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeeCrowd
{
    internal class Challenge_1140
    {
        //Uma frase é um tautograma se todas suas palavras começam com a mesma letra.
        //Para cada caso de teste, imprima uma única linha contendo o caractere 'Y' 
        //se a sentença é um tautograma, ou um 'N' caso contrário.
        //Uma frase consiste de uma sequência de no máximo 50 palavras separadas por 
        //espaços simples. Uma palavra é uma sequência de no máximo 20 letras do alfabeto.
        //Uma palavra contém ao menos uma letra e uma sentença contém ao menos uma palavra.

        //static void Main(string[] args)
        //{
        //    string frase = Console.ReadLine();
        //    while (frase != "*")
        //    {
        //        string[] palavras = frase.Split(' ');

        //        char[] letrasPrimeiraPalavra = palavras[0].ToLower().ToCharArray();
        //        char inicialPrimeiraPalavra = letrasPrimeiraPalavra[0];

        //        bool tautograma = true;

        //        foreach (string palavra in palavras)
        //        {
        //            bool contemApenasCaracteresEspeciais = Regex.IsMatch(palavra, @"^[^\p{L}\p{N}]+$");
        //            char[] letrasPalavra = palavra.ToLower().ToCharArray();
        //            char inicial = letrasPalavra[0];

        //            if (!(inicial == inicialPrimeiraPalavra) || contemApenasCaracteresEspeciais)
        //            {
        //                Console.WriteLine("N");
        //                tautograma = false;
        //                break;
        //            }
        //        }
        //        if (tautograma == true)
        //        {
        //            Console.WriteLine("Y");
        //        }

        //        frase = Console.ReadLine();
        //    }
        //}
    }
}
