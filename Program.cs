using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Практикум 9 - Сакары Анны";

            //практикум по счёту в moodle: 12

            //ПРАКТИКУМ 12
            //Вычислить значение функции для целых аргументов двумя способами(1 - й способ: полный условный оператор;
            //2 - й способ: тернарная операция):
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x > 0)
            {
                y = Math.Pow(Math.Sin(x), 2) * x;
                Console.WriteLine($"y = {y}");
            }
            else
            {
                y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
                Console.WriteLine($"y = {y}");
            }
            Console.ReadKey();

            //2 способ:
            Console.WriteLine("Введите значение x: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1;
            y1 = x > 0 ? Math.Pow(Math.Sin(x1), 2) * x1 : 1 - 2 * Math.Sin(Math.Pow(x1, 2));
            Console.WriteLine($"y = {y1}");
            Console.ReadKey();

            //2. Используя двузначное случайное число,
            //вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            Random rnd = new Random();
            int num = rnd.Next(10, 99);
            string number;
            number = num % 2 == 0 ? "четное" : "нечётное";
            Console.WriteLine($"Случайное число {num}: {number}");
            Console.ReadKey();


            //3. Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1;
            //если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.
            Console.Write("Введите положительное число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите положительное число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите положительное число c: ");
            int c = int.Parse(Console.ReadLine());
            if (a <= 0 | b <= 0 | c <= 0)
            {
                Console.Write("error");
            }
            else if (a % 2 != 0 & b % 2 != 0 & c % 2 != 0)
            {
                Console.Write($"a = {a * 2}, b = {b * 2}, c = {c * 2}");
            }
            else if (a % 2 == 0 & b % 2 == 0 & c % 2 == 0)
            {
                Console.Write($"a = {a + 1}, b = {b + 1}, c = {c + 1}");
            }
            else
            {
                Console.Write($"a = {a - 1}, b = {b - 1}, c = {c - 1}");
            }
            Console.ReadKey();



            //4. По введенному номеру месяца выводится название поры года
            //(зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр

            Console.Write("Введите номер месяца чтобы узнать время года: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 2:
                    Console.WriteLine("Зима - 1 семестр");
                    break;
                case 12:
                    Console.WriteLine("Зима - 1 семестр");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна - 2 семестр");
                    break;
                case 6:
                    Console.WriteLine("Лето - 2 семестр");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Лето - каникулы");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень - 1 семестр");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}
