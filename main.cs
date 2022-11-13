// Implementing a calculator in
// C# using switch statement.
using System;
using System.Text;
using System.Threading.Tasks;
 
namespace kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Zadej první číslo:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadej druhé číslo:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zadej operátor(/,+,-,*):");
                string symbol = Console.ReadLine();
 
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Sčítání:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Odčítání:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Násobení:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Dělení:" + res);
                        break;
                    default:
                        Console.WriteLine("Špatný input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Checeš pokračovat?(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");
        }
    }
 
}
