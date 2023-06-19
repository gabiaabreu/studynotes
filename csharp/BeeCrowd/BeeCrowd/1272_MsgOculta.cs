using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeeCrowd
{
    internal class Challenge_1272
    {
        //Neste problema a mensagem oculta em um texto é composto pelas primeiras letras de cada 
        //palavra do texto, na ordem em que aparecem.
        //É dado um texto composto apenas por letras minúsculas ou espaços. Pode haver mais 
        //de um espaço entre as palavras. O texto pode iniciar, terminar ou conter somente espaços.
        //A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste.

        //static void Main(string[] args)
        //{
        //    int N = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < N; i++)
        //    {
        //        string frase = Console.ReadLine();
        //        bool contemNumeros = Regex.IsMatch(frase, @"\d");
        //        bool contemCaracteresEspeciais = Regex.IsMatch(frase, @"[^a-zA-Z0-9\s]");

        //        if (!contemNumeros && !contemCaracteresEspeciais)
        //        {
        //            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //            List<char> iniciais = new List<char>();

        //            foreach (string palavra in palavras)
        //            {
        //                char[] letras = palavra.ToCharArray();
        //                char inicial = letras[0];

        //                iniciais.Add(inicial);
        //            }
        //            string msgOculta = new string(iniciais.ToArray());

        //            Console.WriteLine(msgOculta);
        //        }
        //    }
        //}
    }
}
