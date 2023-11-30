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
            ForQ7();
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
    }
 }
