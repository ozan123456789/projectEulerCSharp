using System;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(multiples_of());
        }

        static int multiples_of(int n1=3,int n2=5,int limit=1000)
        {
            var sum = 0;

            for(int i=3; i<limit; i++)
            {
                if(i %3 == 0 || i % 5 == 0){
                    sum += i;
            }
            }

            return sum;
        }
    }
}
