using System;
using CAMPO_DE_BATALHA;
using CHESS;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Azul), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
         
    }
}
