using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{
    class Program
    {

        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Game game = new Game();
            game.startGame(player1, player2);

            Console.ReadKey();
        }
        



    }
}

