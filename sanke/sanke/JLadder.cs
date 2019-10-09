using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{
    public class JLadder
    {
        public int newPosition { get; set; }
        public int newPositionLadder(int position, int positionActual)
        {
            newPosition = positionActual + position;
            return newPosition;
        }

        public void createLadder()
        {


        }
    }
}
