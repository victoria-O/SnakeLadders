using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{
   public class Jsnake
    {
        public int newPosition { get; set; }

        public int newPositionSnake(int position, int positionActual)
        {
            newPosition = positionActual - position;
            return newPosition;
        }
    }
}
