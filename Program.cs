using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 80)
            {
                int input = 0;
                int[] results = new int[n];
                for (int i = 0; i < n; i++)
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    // Console.WriteLine($"Palindrom liczby {input} : [{Palindrom(input)}] reverse : {ReverseInt(input)}");
                    results[i] = input;

                }

                for (int i = 0; i < n; i++)
                {
                    Sumowanie(results[i]);
                }
            }
            Console.ReadKey();

        }

        public static int Counter(int counter)
        {
            int c = counter;
            return c;
        }
        public static void Sumowanie(int liczba)
        {
            int counter = 0;
            int sum = 0;
            bool flaga = true;
            // dopóki liczba nie jest palindromem
            while (flaga)
            {
                // sprawdź czy liczba jest palidromem
                if(Palindrom(liczba) == true)
                {
                    flaga = false;
                    sum = liczba;
                }else if (Palindrom(liczba) == false)
                {
                    counter++;
                    
                    liczba = liczba + ReverseInt(liczba);
                    sum = liczba;
                    
                    
                }
            }

            Console.WriteLine($"{sum} {counter}");
        }

        public static bool Palindrom(int liczba)
        {
            char[] chars = liczba.ToString().ToCharArray();

        
            bool flaga = true;
            var len = liczba.ToString().Length;
            int j = len;
            int i = 0;
   
            for (j = len - 1, i = 0; i < len; i++, j--)
            {
                //   Console.WriteLine($"i ={i} , j = {j}");
           //     Console.WriteLine($"{chars[i]} ==   {chars[j]}");
                if (chars[i] != chars[j])
                {
                    flaga = false;
             
                }
               


            }
            return flaga;

        }
        public static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }



    }
}
