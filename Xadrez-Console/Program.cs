using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;
using Xadrez_Console;

namespace xadrez_console{
    class Program{
        static void Main(string[] args){

            PosicaoXadrez pos = new PosicaoXadrez('a', 8);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
