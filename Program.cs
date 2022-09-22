using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsRunning = true;
            int Operation;
            double num1;
            double num2;
            double res;


            while (IsRunning == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("КАЛЬКУЛЯТОР УБИВАТОР 5000");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("=======================================================");
                Console.ResetColor();

                Console.WriteLine("Выберете операцию:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1.Сложить 2 числа\n2.Вычесть первое из второго\n3.Перемножить два числа\n4.Разделить первое на второе\n5.Возвести в степень N первое число\n6.Найти квадратный корень из числа\n7.Найти 1 процент от числа\n8.Найти факториал из числа\n9.Выйти из программы");
                Console.ResetColor();
                Operation = Convert.ToInt32(Console.ReadLine());

                switch (Operation)
                {
                    case 1:
                        Console.WriteLine("Введите два числа: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        res = num1 + num2;
                        Console.WriteLine($"Результат: {num1} + {num2} = {res}");
                        break;
                    case 2:
                        Console.WriteLine("Введите два числа: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        res = num1 - num2;
                        Console.WriteLine($"Результат: {num1} - {num2} = {res}");
                        break;
                    case 3:
                        Console.WriteLine("Введите два числа: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        res = num1 * num2;
                        Console.WriteLine($"Результат: {num1} * {num2} = {res}");
                        break;
                    case 4:
                        Console.WriteLine("Введите два числа: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        res = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {res}");
                        break;
                    case 5:
                        Console.WriteLine("Введите число и его степень: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        res = Math.Pow(num1, num2);
                        Console.WriteLine($"Результат: {num1}^{num2} = {res}");
                        break;
                    case 6:
                        Console.WriteLine("Введите два число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        res = Math.Sqrt(num1);
                        Console.WriteLine($"Квадратный корень из {num1} = {res}");
                        break;
                    case 7:
                        Console.WriteLine("Введите два число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        res = num1 / 100;
                        Console.WriteLine($"Один процент от {num1} = {res}");
                        break;
                    case 8:
                        Console.WriteLine("Введите два число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        res = 0;
                        for (int i = 2; i <= num1; i++)
                        {
                            res = num1 * i;
                        }
                        Console.WriteLine($"Факториал числа {num1} = {res}");
                        break;
                    case 9:
                        IsRunning = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
