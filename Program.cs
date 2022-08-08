﻿namespace LearningExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException ex)   
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException eg)
            {
                Console.WriteLine(eg.Message );
            }


            //use finally if you want something to happen no matter what
            finally
            {

            }
          

            Console.ReadLine();

        }
    }
}