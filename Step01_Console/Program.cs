using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== 계산기 ====");

            Console.Write("첫 번째 숫자: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("연산자 (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("두 번째 숫자: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            if (op == "+") result = num1 + num2;
            else if (op == "-") result = num1 - num2;
            else if (op == "*") result = num1 * num2;
            else if (op == "/") result = num2 != 0 ? num1 / num2 : double.NaN;
            else Console.WriteLine("알 수 없는 연산자입니다.");

            Console.WriteLine($"결과: {result}");
            Console.WriteLine("계속하려면 아무 키나 누르세요...");
            Console.ReadKey();
        }
    }
}
