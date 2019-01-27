using System;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
         
            int n4 = 5;
            printTriangle(n4);
            

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {

                Console.Write("The prime numbers between {0} and {1} are : \n", x, y);
                //loop for iterating through each number between the range
                for (int num = x; num <= y; num++)
                {
                    //Method for checking if a number is prime or not
                    isPrime(num);
                }
                Console.WriteLine();
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
        public static void isPrime(int n)
        {
            try
            {
                int i, ctr;
                ctr = 0;
                if (n > 0)
                {
                    for (i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && n != 1)
                    {
                        Console.Write("{0} ", n);
                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing isPrime");
            }

        }

        public static double getSeriesResult(int n)
        {
            try
            {
                double term = 1;
                double res = 0;
                for (int i = 1; i <= n; i++)
                {
                    res += (factorial(i)) * term / (i + 1);
                    term = term * (-1);
                }

                return Math.Round(res, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }
        public static int factorial(int n)
        {
            int result = n;

            for (int i = 1; i < n; i++)
            {
                result = result * i;
            }
            return result;
        }
        public static long decimalToBinary(long n)
        {
            try
            {
                long remainder;

                string result = string.Empty;
                while (n > 0)
                {
                    remainder = n % 2;
                    n /= 2;
                    result = remainder.ToString() + result;

                }
                return Convert.ToInt64(result);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                int num = Convert.ToInt32(n);
                int sum = 0;
                int power = 1;
                while (num > 0)
                {
                    int reminder = num % 10;
                    num = num / 10;

                    sum = sum + reminder * power;

                    power = power * 2;
                }

                return sum;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int space;
                for (int i = 1; i <= n; ++i)
                {
                    int k = 0;
                    for (space = 1; space <= n - i; ++space)
                    {
                        Console.Write(" ");
                    }
                    while (k != 2 * i - 1)
                    {
                        Console.Write("*");
                        ++k;
                    }
                    Console.WriteLine();
                }
                

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                var output = a
                    .GroupBy(num => num)
                    .OrderBy(group => group.Key)
                    .Select(group => new { value = group.Key, count = group.Count() });
                Console.WriteLine(String.Format("{0,2} {1,2}", "Number", "Frequency"));
                foreach (var item in output)
                {
                    Console.WriteLine(String.Format("|{0,3}|{1,3}|", item.value, item.count.ToString()));
                }
                Console.ReadLine();
            }
           
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }
}
