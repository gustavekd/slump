using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("slumpa fram 10 tal mellan 1-20 och beräkna medelvärdet");
            Random randomerare = new Random();

            int tal;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                tal = randomerare.Next(1, 21);
                Console.Write(tal + " ");
                sum = sum + tal;
            }
            Console.WriteLine("medelvärdet =" + sum / 10);

            //övning2 

            Console.WriteLine("Slumpa ut 20 tal mellan 15 och 30 och räkna ut dess medianvärde");

            int[] numbarray = new int[20];
            Array.Sort(numbarray);
            for (int j = 0; j < 20; j++)

            {
                numbarray[j] = randomerare.Next(15, 31);
            }
            Array.Sort(numbarray);
            for (int j = 0; j < 20; j++)
            {
                Console.Write(numbarray[j] + " ");
                sum = sum + numbarray[j];
            }
            Console.WriteLine("medianvärdet är " + (numbarray[9] + numbarray[10]) / 2.0);

            //övning 3 
            Console.WriteLine("Du ska gissa ett tal som slumpas fram från 0 till 100");
            int randomtal = randomerare.Next(101);
            int talet = 1;

            while (talet != randomtal)
            {
                Console.WriteLine("vad gissar du");
                talet = int.Parse(Console.ReadLine());

                if (talet < randomtal)
                    Console.WriteLine("För lågt!");
                if (talet > randomtal)
                    Console.WriteLine("För högt!");
            }
             
            Console.WriteLine("Rätt gissat!");
            

        }

    }

}
