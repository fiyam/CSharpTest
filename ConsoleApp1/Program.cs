using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        /*
         *Write a program wich takes as input a sorted array
         *and updates it so that all duplicates have been removed
         *and the remaining elements have been shifted left to fill the emptied indices.
         *Return the number of valid elements . Many languages have library functions
         *for performing this operation , you may not use them .
         */


        /*
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 4, 7, 7, 8, 9, 10};
            int endOfList = DeleteDuplicates(array);

            for (int i = 0; i < endOfList; i++)
            { 
                Console.WriteLine(array[i]);
            }

        }

        private static int DeleteDuplicates(int[] array)
        {
            if (array.Length == 0)
                return 0;
            int endOfList = 0;
            for (int i = 0 ; i < array.Length ; i++ )
            {
                if (array[endOfList] != array[i])
                {
                    endOfList++;
                    array[endOfList] = array[i];
                }
            }
            return endOfList + 1;
        }

        */

        private const int i = 0;
        static void Main(string[] args)
        {
            //int[] array = { 2, 7, 12, 8 };

            //private const int i=1 ;



            string line;
            List<int> parsedNumbers = new List<int>();

            //Open the file
            System.IO.StreamReader file =
               new System.IO.StreamReader("C:\\Users\\User\\OneDrive\\Desktop\\array.txt");

            //Read in the next line, cancel if there is no next line
            while ((line = file.ReadLine()) != null)
            {
                int temp = Int32.Parse(line);
                parsedNumbers.Add(temp);
            }

            //int[] result = parsedNumbers.ToArray();


            int target = 1999999;


            List<int> parsedNumbers1 = random_generator();

            int[] result = parsedNumbers1.ToArray();




            //int[] answer = TowSum(result, target);

            Stopwatch sw;
            sw = Stopwatch.StartNew();


            //int[] answer = TowSumDictionary(Enumerable.Range(1, 1000000).ToArray(), target);
            int[] answer = TowSum(Enumerable.Range(1, 1000000).ToArray(), target);


            sw.Stop();
            
            foreach (var i in answer)
            {
                Console.WriteLine(i);          
            }



            Console.WriteLine("Time taken: {0}ms", sw.ElapsedMilliseconds);

        }


        //generate unique random number
        public static List<int> random_generator()
        {

            Random random = new Random();

            List<int> random_container = new List<int>();

            do
            {

                int random_number = random.Next(10000);

                if (!random_container.Contains(random_number)){

                    random_container.Add(random_number);
                    }
            }
            while (random_container.Count != 10000);


            return random_container;
        }







        private static int[] TowSum(int[] array, int target)
        {

            
            int[] sumArray = new int[] {  };

            for (int i = 0; i < array.Length-1 ; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ( (array[i] + array[j]) == target)
                    {
                        sumArray = new int[]{ i , j};
                    }
                }
            }
            return sumArray;

            }



        private static int[] TowSumDictionary(int[] array, int target)
        {

            Dictionary<int, int> prevNumbers = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int complement = target - array[i];

                if (prevNumbers.ContainsKey(complement))
                    return new int[] { prevNumbers[complement], i };

                prevNumbers.Add(array[i], i);

            }
            return null;
        }










    }


}
