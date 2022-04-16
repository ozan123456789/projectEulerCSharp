using System;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution of problem 2:" + solution2());
        }


       static int solution2(int limit = 4000000)
        {
            int sum = 0;
            int first = 1,
                second = 2,
                third = first + second;

            while (third<limit)
            {
                if (third % 2 == 0)
                {
                    sum += third;
                }

                first = second;
                second = third;
                third = first + second;

                

            }


            return third;
        }
    }
}
