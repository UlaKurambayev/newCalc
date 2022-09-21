namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string? answer;
            do
            {
                Console.Clear();
                int result;
                
                
                Console.WriteLine("******************************\nWelcome to MyFirst Calculator!\n******************************");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                Console.WriteLine("Please enter your First Number:");
                var num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Operator (/,*,+,-): ");
                var operation = Console.ReadLine();

                while(operation != "/" && operation != "*"&& operation !="+" && operation !="-")
                {
                    Console.WriteLine("Wrong Input. Please enter one of the following operators(/,*,+,-)");
                    operation = Console.ReadLine();
                }

                Console.WriteLine("Please enter your Second Number:");
                var num2 = Convert.ToInt32(Console.ReadLine());
               

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition:" + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Subtraction:" + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Multiplication:" + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Division:" + result);
                        break;

                    // default:
                    //     Console.WriteLine("Wrong Input");
                    //     break;

                }

                Console.ReadLine();
                Console.WriteLine("Do yo want to Continue(Press y for Yes and Press n for No)");
                answer = Console.ReadLine();
            }
            while (answer is "y" or "Y");
            
            Console.WriteLine("Thank you fo using My First Calculator with C#");
           




           



        }

    }

}