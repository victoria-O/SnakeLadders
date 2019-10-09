using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{
    public class Game
    {
        Board table = new Board();
        JLadder ladder = new JLadder();
        Jsnake snake = new Jsnake();
        

        public void startGame(Player player1, Player player2)
        {
            int number1=0, number2=0;
            int numberCompare = 0;
          //table.GenerarTablero();
           number1= player1.throwDice();
           number2 = player2.throwDice();

            Console.WriteLine("jugador 1:"+number1);
            Console.WriteLine("jugador 2:"+number2);
            numberCompare=CompareNumber(number1, number2);


            switch(numberCompare)
            {
                case 1:
                    {
                        int position1 = 0, position2=0;
                        do
                        {
                            int positionNew= 0;
                            number1 = player1.throwDice();
                            position1 = position1 + number1;
                            Console.WriteLine("jugador 1:" + number1);
                            Console.WriteLine("te mueves a la posicion" + position1);
                            table.moveOnTheBoard(position1, player1);
                            if(position1==20 || position1==35 || position1==5) 
                            {
                               positionNew= ladder.newPositionLadder(10,position1);
                                Console.WriteLine("pisaste una escalera avanzaras hasta el: {0}",positionNew);
                            }
                            if (position1 == 40 || position1 == 15 || position1 == 30)
                            {
                                positionNew =ladder.newPositionLadder(5, position1);
                                Console.WriteLine("pisaste la cabeza de una vivora retrocedes hasta el: {0}",positionNew);
                            }


                        } while (position1 == 50 || position2 == 50);

                        


                        break;
                    }
                case 2:
                    {
                        number2 = player2.throwDice();
                        Console.WriteLine("jugador 2:" + number2);

                        break;
                    }
                case 3:
                    {
                        number1 = player1.throwDice();
                        number2 = player2.throwDice();
                        Console.WriteLine("jugador 1:" + number1);
                        Console.WriteLine("jugador 2:" + number2);
                        numberCompare = CompareNumber(number1, number2);
                        break;
                    }
            }
            
            
           
           



        }

        public int CompareNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine("inicia el jugador 1");
                return 1;
            }
            else if (number2 > number1)
            {
                Console.WriteLine("inicia el jugador 2");
                return 2;
            }
            else if (number1 == number2)
            {
                Console.WriteLine("numeros iguales lanzar de nuevo");
                return 3;

            }
            return 0;
        }

         
    }
}
