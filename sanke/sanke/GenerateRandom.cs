using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanke
{
   public   class GenerateRandom
    {
        private Random random_Number = new Random();

       public int  generateRandomNumbers()
        {
            int numberSend = 0;
            int[] array = new int[6];

            GenerateRandom objects = new GenerateRandom();
            array = objects.generateNonRepeatedNumbers(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                numberSend = array[5];
            }
            return numberSend;
        }

       
       //funcion que genera numeros aleatorios sin repetir
       
    public int[] generateNonRepeatedNumbers(int[] array)
    {
        int num;
        for (int i = 0; i < array.Length; i++)
        {
            do
            {
                //num = r.Next(1, array.Length);
                num = random_Number.Next(1, 7);
            } while (isRepeated(array, num));
            array[i] = num;
        }
        return array;
    }

    
     // Función que verifica que un valor no se encuentre dentro del array
    public static bool isRepeated(int[] array, int random_Number)
    {
        for (int i = 0; i < array.Length; i++)
            if (random_Number == array[i])
                return true;
        return false;
    }
}
}
