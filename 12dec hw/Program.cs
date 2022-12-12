using System;

namespace _12dec_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = Sum(135, 64);
            Console.WriteLine(result);



            var answer = square(7);
            Console.WriteLine(answer);



            var check = letter("kazim");
            Console.WriteLine(check);


            var average1 = average(3, 18, 44, 75);
            Console.WriteLine(average1);


            var answer2 = sum1(275);
            Console.WriteLine(answer2);


        }

     //Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int n1,int n2)
        {
            return n1 + n2;
        }

        //Verilmiş ədədin kvadratını qaytaran metod

        static int square(int num1)
        {
            return num1 * num1;
        }



        //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod


        static bool letter (string word)
        {

            var i = 0;
                return (word[i] == 'a') || word[i] == 'A';
            
            
        }

        //Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod




        static int average(int a,int b,int c,int d)
        {
            return (a + b + c + d) / 4;
        }
         //Verilmiş ədədin rəqəmləri cəmini qaytaran metod
         static int sum1(int number)
        {
            int numbers = (number % 10) + (number - number % 10) / 10;
            if (number < 0)
                return numbers;

 
           
            
            

                

            
           
            



        }
    }
}

