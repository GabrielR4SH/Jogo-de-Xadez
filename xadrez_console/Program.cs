using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PosicaoXadrez pos = new PosicaoXadrez('g', 5);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine(); 
            */

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                //
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 3));

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(6, 5));
                
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 2));




                Tela.ImprimirTabuleiro(tab);
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
