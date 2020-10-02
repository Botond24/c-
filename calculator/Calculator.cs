using System;

namespace c_
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nGive me another one:");
            var n2 = Convert.ToInt32(Console.ReadLine());
            var n3 = 0;
            Console.WriteLine("\nWhat do you want with these? (+, -, *, /)");
            var oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                    Console.WriteLine($"\n So you want to add {n1} to {n2}?");
                    break;
                
                case "-":
                    Console.WriteLine($"\n So you want to subtract {n2} from {n1}?");
                    break;
                
                case "*":
                    Console.WriteLine($"\n So you want to multiply {n1} with {n2}?");
                    break;
                
                case "/":
                    Console.WriteLine($"\n So you want to  divide {n1} with {n2}?");
                    break;

                default:
                    Console.WriteLine("You done fucked up!");
                    break;
            }
            switch (Console.ReadLine())
            {
                case "Y":
                case "Yes":
                case "y":
                case "yes":
                    if (oper == "+")
                    {
                        n3 = n1+n2;
                        Console.WriteLine($"\n Your number is: {n3}");
                    }
                    else if (oper == "-")
                    {
                        n3 = n1-n2;
                        Console.WriteLine($"\n Your number is: {n3}");
                    }
                    else if (oper == "*")
                    {
                        n3 = n1*n2;
                        Console.WriteLine($"\n Your number is: {n3}");
                    }
                    else if (oper == "/")
                    {
                        n3 = n1/n2;
                        Console.WriteLine($"\n Your number is: {n3}");
                    }
                    break;
                case "N":
                case "No":
                case "n":
                case "no":
                    break;
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
