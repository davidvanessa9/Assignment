using System;
using System.Text;

namespace Course6
{
    class Program
    {

        //functions for the one-dimensional arrays
        static int SumOfArray(int[] v)
        {
            int i, S = 0;
            for (i = 0; i < v.Length; i++)
            {
                S += v[i];
            }

            return S;
        }

        static int MaxOfArray(int[] v)
        {
            int i, max = v[0];
            for(i = 1; i < v.Length; i++)
            {
                if (v[i] > max)
                    max = v[i];
            }

            return max;
        }

        //function for the multi-dimensional arrays
        static void displayPoints(int[,] v)
        {
            int i, j, n=1;
            for (i = 0; i < v.Length/2; i++)
            {
                
                Console.WriteLine("The coordinates of the " + n + " point are: x=" + v[i, 0] + " y=" + v[i, 1]);
                n++;
            }
               

        }

        //practice with string
        public static void concatString(String s1)
        {
            String st = "changed";
            s1 = String.Concat(s1, st);
        }

        //practice with stringbuilder
        public static void concatStringBuilder(StringBuilder s2)
        {

            s2.Append("changed");
        }


        static void Main(string[] args)
        {
            //using one-dimensional arrays
            int[] numbers = new int[7] { 1, 2, 3, 4, 5, 6, 7 }; 
            int[] numbers1 = new int[5] { 2, 0, 23, 15, 4 };

            //using multi-dimensional arrays
            int[,] points = new int[3, 2] { { 0, 0 }, { 3, 2 }, { 1, 4 } };
            

            Console.WriteLine("The sum of the first array is: "+SumOfArray(numbers));
            Console.WriteLine("The maximum number of the second array is: " + MaxOfArray(numbers1));

            displayPoints(points);

            //practice with string and stringbuilder

            String s1 = "Sir ";
            concatString(s1); 
            Console.WriteLine("String: " + s1);

            StringBuilder s2 = new StringBuilder("Sir ");
            concatStringBuilder(s2);
            Console.WriteLine("StringBuilder: " + s2);

            //practice with split
            string rasa, varsta;
            string[] lines = System.IO.File.ReadAllLines(@"D:\Course6\Course6\split.txt");
            foreach (string line in lines)
            {
                string[] parti = line.Split(';');
                rasa = parti[0];
                varsta = parti[1];
                Console.WriteLine(rasa + " " + varsta);
            }

                Console.ReadKey();
        }
    }
}
