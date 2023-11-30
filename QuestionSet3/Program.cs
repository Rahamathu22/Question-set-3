using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSet3
{
    class Program
    {
        static void Main(string[] args)
        {
            ForQ9();
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }

        public static void ForQ1()
        {
            int Number = GetInteger("Enter a Number");
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void WhileQ1()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            while (i <= Number)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void Doq1()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= Number);
        }

        public static void ForQ2()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2= GetInteger("Enter a Number2");
            for (int i = Number1; i < Number2; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileQ2()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            int i = Number1;
            while (i < Number2)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void DoQ2()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            int i = Number1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < Number2);
        }

        public static void ForQ3()
        {
            int Number = GetInteger("Enter a Number");
            for (int i = 1; i <= Number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void WhileQ3()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            while (i <= Number)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                    i++;
                
            }
        }

        public static void DoQ3()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            }
            while (i <= Number);
        }

        public static void ForQ4()
        {
            int Number = GetInteger("Enter a Number");
            for (int i = 1; i <= Number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void WhileQ4()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            while (i <= Number)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            }
        }

        public static void DoQ4()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            }
            while (i <= Number);
        }

        public static void ForQ5()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            for (int i = Number1; i < Number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void WhileQ5()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            int i = Number1;
            while (i < Number2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public static void DoQ5()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            int i = Number1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i < Number2);
        }

        public static void ForQ6()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            for (int i = Number1; i < Number2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void WhileQ6()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            int i = Number1;
            while (i < Number2)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public static void DoQ6()
        {
            int Number1 = GetInteger("Enter a Number1");
            int Number2 = GetInteger("Enter a Number2");
            int i = Number1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i < Number2);
        }

        public static void ForQ7()
        {
            int Number = GetInteger("Enter a Number");
            for (int i = 1; i <= 100; i++)
            {
                if (i % Number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void WhileQ7()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            while (i <= 100)
            {
                if (i % Number == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public static void DoQ7()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            do
            {
                if (i % Number == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 100);
        }

        public static void ForQ8()
        {
            int Number = GetInteger("Enter a Number");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i*Number);
            }
        }

        public static void WhileQ8()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i*Number);
                i++;
            }
        }

        public static void DoQ8()
        {
            int Number = GetInteger("Enter a Number");
            int i = 1;
            do
            {
                Console.WriteLine(i * Number);
                i++;
            }
            while (i <= 20);
        }

        public static void ForQ9()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.WriteLine(j + "X" + i + "=" + i * j);
                }
            }
        }

        public static void WhileQ9()
        {
            int i = 1;
            int j = 1;
            while (i <= 5)
            {
                while (j <= 20)
                {
                    Console.WriteLine(j + "X" + i + "=" + i * j);
                    j++;
                }
                i++;
            }
        }

        public static void DoQ9()
        {
            int i = 1;
            int j = 1;
            do
            {
                do
                {
                    Console.WriteLine(j + "X" + i + "=" + i * j);
                    j++;
                }
                while (j <= 20);
                i++;
            }
            while (i <= 5);
        }

        public static void ForQ10()
        {
            int Number = GetInteger("Enter a Number");
            int sum = 0;
            for (int i = 1; i <= Number; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of numbers is:"+sum);
        }

        public static void WhileQ10()
        {
            int Number = GetInteger("Enter a Number");
            int sum = 0;
            int i = 1;
            while (i <= Number)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("The sum of numbers is:"+sum);
        }

        public static void DoQ10()
        {
            int Number = GetInteger("Enter a Number");
            int sum = 0;
            int i = 1;
            do
            {
                sum = sum + i;
                i++;
            }
            while (i <= Number);
            Console.WriteLine("The sum of numbers is:"+sum);
        }
    }
 }
