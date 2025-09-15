using System;
using System.Text;
using System.Threading.Tasks;
namespace colculatore
{
    class Program
    {
        static void Main(string[] args)
        {
            double memory = 0;
            double res = 0;
            string value;
            do
            {
                Console.WriteLine("Выберите операцию (+, -, *, /, %, 1/x, x^2, sqrt(x), M+, M-, MR):");
                string symbol = Console.ReadLine();

                if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "%" || symbol == "/")
                {
                    Console.WriteLine("Введите первое число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (symbol)
                    {
                        case "+":
                            res = num1 + num2;
                            Console.WriteLine("Сложение: " + res);
                            memory = res;
                            break;
                        case "-":
                            res = num1 - num2;
                            Console.WriteLine("Вычетание: " + res);
                            memory = res;
                            break;
                        case "*":
                            res = num1 * num2;
                            Console.WriteLine("Умножение: " + res);
                            memory = res;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Нельзя делить на ноль! Попробуйте ещё раз");
                            }
                            else
                            {
                                res = num1 / num2;
                                Console.WriteLine("Деление: " + res);
                                memory = res;
                            }
                            break;
                        case "%":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Нельзя делить на ноль! Попробуйте ещё раз");
                            }
                            else
                            {
                                res = num1 % num2;
                                Console.WriteLine("Остаток от деления: " + res);
                                memory = res;
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                else if (symbol == "1/x" || symbol == "x^2" || symbol == "sqrt(x)" || symbol == "M-" || symbol == "M+")
                {
                    Console.WriteLine("Введите число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    switch (symbol)
                    {
                        case "1/x":
                            if (num1 == 0)
                            {
                                Console.WriteLine("Нельзя делить на ноль! Попробуйте ещё раз");
                            }
                            else
                            {
                                res = 1 / num1;
                                Console.WriteLine("1 делить на x: " + res);
                                memory = res;
                            }
                            break;
                        case "x^2":
                            res = Math.Pow(num1, 2);
                            Console.WriteLine("Число в квадрате: " + res);
                            memory = res;
                            break;
                        case "sqrt(x)":
                            if (num1 < 0)
                            {
                                Console.WriteLine("Нельзя брать корень из отрицательного числа! Попробуйте ещё раз");
                            }
                            else
                            {
                                res = Math.Sqrt(num1);
                                Console.WriteLine("Квадратный корень из x: " + res);
                                memory = res;
                            }
                            break;
                        case "M+":
                            memory += num1;
                            Console.WriteLine("Прибавлено к памяти " + num1);
                            break;
                        case "M-":
                            memory -= num1;
                            Console.WriteLine("Вычтено из памяти " + num1);
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                else if (symbol == "MR")
                {
                    Console.WriteLine("Значение в памяти: " + memory);
                }
                else
                {
                    Console.WriteLine("Некорректные данные! Попробуйте ещё раз");
                }

                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
