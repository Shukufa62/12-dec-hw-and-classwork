using System;

namespace _12_dec_class_work
{
    class Program
    {
        static void Main(string[] args)


        {
            int number = 90;
            var result = Increment(number);
            Console.WriteLine(result);



            string fulname = Makefullname("aysel", "cavadzade");
            Console.WriteLine(fulname);

            var sumresult = Sum(90, 91);

            Console.WriteLine(sumresult);


            string num1Str = Console.ReadLine();
            int n1 = Convert.ToInt32(num1Str);
            string num2str = Console.ReadLine();
            int n2 = Convert.ToInt32(num2str);
            var result1 = sum(n1, n2);
                Console.WriteLine( result1 );




        }


        static int Increment(int num)
        {
            num++;
            return num;
        }

        static string Makefullname(string name,string surname)

        {

            var fn = $"{name} {surname}";
            return fn;

            


        }


        static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }



        static int sum(int n1,int n2)
        {
            return n1 + n2;
        }
    }


}

        