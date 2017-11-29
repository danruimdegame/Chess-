using System;
using CAMPO_DE_BATALHA;
using CHESS;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
         
    }
}
