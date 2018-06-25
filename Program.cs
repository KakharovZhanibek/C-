using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            //Console.Write("Введите имя: ");
            //string str = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Привет, " + str);
            task2();
        }
        static void task1()
        {

            /*1.Написать программу, которая считывает символы с клавиатуры, 
             * пока не будет введена точка. Программа должна сосчитать 
             * количество введенных пользователем пробелов. */
            string str = "";
            int i = 0;

            do
            {
                str += Console.ReadLine();//str = str + CR();
                i++;
            } while (!str.Contains('.'));

            int countspace = str.Count(w => w == ' ');

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if(str[k]==' ')
                {
                    b++;
                }
            }
            Console.WriteLine("Количество символов: " + i);
            Console.WriteLine("Количество пробелов: " + countspace);
            Console.WriteLine("Количество пробелов: " + b);
        }
        static void task2()
        {
            /*2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) 
             * и проверить является ли данный билет счастливым (если на билете
             *  напечатано шестизначное число, и сумма первых трёх цифр равна 
             *  сумме последних трёх, то этот билет считается счастливым). */

            string ticket = Console.ReadLine();
            if(ticket.Length==6)
            {
                //сумма первых трёх цифр
                int sum1 = ticket[0] + ticket[1] + ticket[2];
                // сумме последних трёх
                int sum2= ticket[3] + ticket[4] + ticket[5];

                if(sum1==sum2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Счастливый билет!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("БИлет не счастливый");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длинна билета формата не соответствует формату!");
            }
        }



        static void task4()
        {
            /*4.Даны целые положительные числа A и B (A < B). 
             * Вывести все целые числа от A до B включительно; 
             * каждое число должно выводиться на новой строке; 
             * при этом каждое число должно выводиться количество раз,
             *  равное его значению. Например: если А = 3, а В = 7, 
             *  то программа должна сформировать в консоли следующий вывод: */
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
        static void task5()
        {
            /*5.Дано целое число N (> 0), найти число, 
             * полученное при прочтении числа N справа налево.
             *  Например, если было введено число 345, то программа
             *   должна вывести число 543.*/
            string a = Console.ReadLine();
            if (Int32.Parse(a) > 0)
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
            }
        }
        static void task6()
        {
            /*6.	Составить программу вывода на экран в одну 
             * строку трех любых чисел с двумя пробелами между ними.*/
            string str;

            Random rnd = new Random();
            str = rnd.Next(1, 30) + "  " + rnd.Next(2, 20) + "  " + rnd.Next(3, 40);
            Console.WriteLine(str);
        }
        static void task8()
        {
            /*8.	Дано расстояние в сантиметрах. 
             * Найти число полных метров в нем.*/
            double a;
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a / 100 + " m");
        }
        static void task11()
        {
            /*11.	Вычислить значение логического выражения при 
             * следующих значениях логических величин А, В и С:
             *  А = Истина, В = Ложь, С = Ложь:
              
              *  a.	А или В; 
              *  b.	А и В; 
              *  c.	В или С.*/
            bool a, b, c;
            a = bool.Parse(Console.ReadLine());
            b = bool.Parse(Console.ReadLine());
            c = bool.Parse(Console.ReadLine());
            if (a || b)
            {
                Console.WriteLine("true");
            }
            if (b || c)
            {
                Console.WriteLine("false");
            }
        }
        static void task15()
        {
            /*15.	 Напечатать "столбиком": 
            a.	все целые числа от 20 до 35;
b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
*/
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine("------");
            int b;
            b = Int32.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i, 2));
            }
            Console.WriteLine();
            Console.WriteLine("------");

            int a;
            a = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i, 3));
            }
            Console.WriteLine();
        }
        static void task16()
        {
            /*16.вычисления значения функции y = 7x^2-3x+6 при любом значении x;*/

            int x;
            x = Int32.Parse(Console.ReadLine());
            int y = 7 * x * x - 3 * x + 6;
            Console.WriteLine(y);
        }
        static void task31()
        {
            /*31.	Известны два расстояния: одно в километрах,
             *  другое — в футах ( 1 фут 0,305 м ). 
             *  Какое из расстояний меньше?*/
            double a, b;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            b = (b * 0.305) / 1000;
            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else
            {
                Console.WriteLine("b > a");
            }
        }
        static void task34()
        {
            /*34.	. Составить программу, которая в зависимости 
             * от порядкового номера дня недели (1, 2, ..., 7) 
             * выводит на экран его название (понедельник, 
             * вторник, ..., воскресенье).*/

            int a;
            a = Int32.Parse(Console.ReadLine());
            DayOfWeek dow = (DayOfWeek)a;
            Console.WriteLine(dow);
            // var t = DateTime.Now.DayOfWeek
        }
        static void task37()
        {
            /*37.	Составить программу, которая в зависимости от 
             * порядкового номера месяца (1, 2, ..., 12) выводит на 
             * экран количество дней в этом месяце. Рассмотреть два случая: 
a.	год не является високосным (см. задачу 4.65); 
b.	год может быть високосным (информация об этом вводится с клавиатуры).
             */
            int a;
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.DaysInMonth(2018, a));
        }
    }
}
