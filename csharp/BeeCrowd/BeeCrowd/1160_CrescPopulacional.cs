using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCrowd
{
    internal class Challenge_1160
    {
        //Dadas as informações de população e a taxa de crescimento de duas cidades quaisquer(A e B), 
        //quantos anos levará para que a cidade menor(sempre cidade A) ultrapasse a cidade B em população.
        //A taxa de crescimento da cidade A é maior do que a taxa de crescimento da cidade B.
        //Para mais de 100 anos exibir a mensagem "Mais de 1 seculo.".
        //A primeira linha da entrada contém um único inteiro T, indicando o número de casos de teste. 
        //Cada caso de teste contém 4 números: dois inteiros PA e PB (100 ≤ PA < 1000000, PA < PB ≤ 1000000) 
        //indicando a população de A e B, e dois valores G1 e G2 (0.1 ≤ G1 ≤ 10.0, 0.0 ≤ G2 ≤ 10.0, G2 < G1) 
        //com um digito após o ponto decimal cada, indicando o crescimento populacional de A e B (em percentual).
        //A população é sempre um valor inteiro. (102.5 pessoas = 102 pessoas)

        //static void Main(string[] args)
        //{
        //    int T = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < T; i++)
        //    {
        //        string input = Console.ReadLine();
        //        string[] inputs = input.Split(' ');
        //        int popA = int.Parse(inputs[0]);
        //        int popB = int.Parse(inputs[1]);
        //        double taxaA = double.Parse(inputs[2]);
        //        double taxaB = double.Parse(inputs[3]);

        //        int anos = 0;

        //        while (popA <= popB)
        //        {
        //            popA = (int)Math.Floor(popA * (1 + taxaA / 100));
        //            popB = (int)Math.Floor(popB * (1 + taxaB / 100));
        //            anos++;
        //            if (anos > 100)
        //            {
        //                break;
        //            }
        //        }

        //        if (anos > 100)
        //        {
        //            Console.WriteLine("Mais de 1 seculo.");
        //        }
        //        else
        //        {
        //            Console.WriteLine(anos + " anos.");
        //        }
        //    }
        //}

    }
}
