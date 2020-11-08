using System;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace MasterClassCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            chapterFortyFive();
            
        }
        public static int convertorCalculator() 
        {
            Console.WriteLine("Please enter your first number: ");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string number2Input = Console.ReadLine();


            int number1 = int.Parse(number1Input);
            int number2 = int.Parse(number2Input);
            int addition = number1 + number2;
            Console.WriteLine("De twee getallen bij elkaar opgeteld zijn: {0}", addition);
            return addition;
        }
        public static void stringToIntErrorCatcher()
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter a number next time.");
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Overflow exception, the number you entered is to large. ");
            }
        }

        public static void chapterFortyFive()
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num 3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("the ! operator negates {0}", !isSunny) ;

            // increment operators (dont forget Pre and Post operators ) 
            int num = 0;
            // ++ for increment -- for decrement 
            num++;
            Console.WriteLine("so ++ increases by: {0}", num);
            Console.WriteLine("so num++ increases by 1 in next line: {0}", num++);
            Console.WriteLine("see: {0}", num);
            Console.WriteLine("and ++num increases it on the same line: {0}", ++num);

            // download rest of chapter and insert. 
            Console.Read();

        }

    }

}
