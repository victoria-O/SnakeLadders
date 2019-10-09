using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{
    public class Player
    {
        

            public int Identifier { get; set; }
           
            public int DiceNumber { get; set; }

            
            /// dado tirado por el jugador
           public int  throwDice()
            {
                GenerateRandom generateNumber = new GenerateRandom();
                DiceNumber=generateNumber.generateRandomNumbers();
                return DiceNumber;
            }
            
            
    }
}
