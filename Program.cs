using System;

namespace hometask_16_march_mnethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(maxelement(10, 300, 4152, -52));
            Console.WriteLine(number(7));
        }

        #region Hometask1
        //Integer array qebul edib geriye bu arrayin en boyuk elementini qaytaran metod yazin.
        //Mes: input {10,50,-5,34}, output 50.
        static int maxelement(params int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        #endregion

        #region Hometask2
        //. Bir integer eded qebul edib, bu ededi binary edede chevirende neche 1 oldugunu tapin.
        //Mes: input 7(binary chevirende 111 alinir), output 3.

        static int number(int num)
        {
            int counter = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    counter++;
                }
                num = num / 2;
            }
            return counter;

            #endregion
        }
    }


    }


        
 
