using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('c', 1);


            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());


            Console.ReadLine();



        }
    }
}
