using System.Reflection.Metadata;

namespace ConsoleApp1
{
    internal static class Calculator
    {
        private const string Divide = "/";
        private const string Multiply = "*";
        private const string Add = "+";
        private const string Subtract = "-";

        public static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Welcome to My First Calculator");
            Console.WriteLine("******************************");

            string option;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1 for -> Basic Calculator");
                Console.WriteLine("2 for -> Tip Calculator");
                Console.WriteLine("0 for -> Exit");
                Console.WriteLine();
                Console.WriteLine("Please Enter Your Selection");

                option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1" :
                        BasicOperation();
                        break;
                    case "2":
                        TipOperation();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("**Invalid Input. Please select valid option**");
                        break;
                }
            } while (option != "0");
        }

        private static void BasicOperation()
        {
            var number1 = GetNumber("Enter Your First Number: ");
            var operation = GetOperator();
            var number2 = GetNumber("Enter Second Number: ");
            
            while (operation == Divide && number2 == 0)
            {
                Console.WriteLine("\n** Enter Valid Value. It can't be 0");
                number2 = GetNumber("Enter Second Number: ");
            }

            var result = operation switch
            {
                Divide => number1 / number2,
                Multiply => number1 * number2,
                Add => number1 + number2,
                Subtract => number1 + number2, 
                // => 0
                
            };
            
            Console.WriteLine();
            Console.WriteLine("Your Result: " + result);

        }

        private static void TipOperation()
        {
            var amount = GetNumber("Enter Amount: $");
            string opt;
            do
            {
                Console.WriteLine("Enter *1* for 18%");
                Console.WriteLine("Enter *2* for 20%");
                Console.WriteLine("Enter *3* for 25%");
                Console.WriteLine("Please Enter Your Selection");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                    Console.WriteLine("Your Tip amount is: $" +((amount * 18)/100) );
                        break;
                    case "2":
                        Console.WriteLine("Your Tip amount is: $" +((amount * 20)/100) );
                        break;
                    case "3":
                        Console.WriteLine("Your Tip amount is: $" +((amount * 25)/100) );
                        break;
                    default:
                        Console.WriteLine("\n** Invalid Option. Try Again **\n");
                        opt = "0";
                        break; 
                }

            } while (opt == "0");
        }

        private static decimal GetNumber(string message)
        {
            decimal number;
            Console.Write(message);
            try
            {
                number = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\n** Invalid Value. Try Again **\n");
                return GetNumber(message);
            }

            return number;
        }

        private static string GetOperator()
        {
            Console.Write("Enter one of the following Operators (/,*,+,-): ");
            var sign = Console.ReadLine();

            switch (sign)
            {
                case Divide:
                case Multiply:
                case Add:
                case Subtract:
                    break;
                default:
                    Console.WriteLine("\n** Invalid Input. Select Valid Operator **\n");
                    sign = GetOperator();
                    break;
            }

            return sign;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}

