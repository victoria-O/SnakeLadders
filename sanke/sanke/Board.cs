using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{

    /// <summary>
    /// Representa el Tablero del juego
    /// </summary>
    public class Board
    {
        int[] array = new int[50];
        int number = 1;
        public void GenerarTablero()
        {
            

            for (int i = 0; i <= array.Length; i++)
            {
               array[i] = number + i;
                Console.WriteLine(array[i]);
            }
        }
        public void moveOnTheBoard(int position, Player player)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                array[position] = player.Identifier;
            }

        }
    }
}
