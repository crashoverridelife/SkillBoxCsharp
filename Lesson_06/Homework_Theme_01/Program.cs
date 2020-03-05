using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Homework_Theme_01
{
    class Program
    {
        /// <summary>
        /// Код который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Особенности запуска</param>
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            // ПОГНАЛИ


            // Параметры
            string name = "Илья Мохноножкин";
            byte age = 16;
            ushort height = 208;
            double history = 3.4;
            double mathematics = 4.7;
            double russian = 2;
            double mean = (history + mathematics + russian) / 3;

            // Обычный вывод данных в консоль
            WriteLine("Имя " + name + " " + "Возраст " + age + " " + "Рост " + height + " " + "История " + history + " " + "Математика " + mathematics + " " + "Русский " + russian);
            WriteLine($"Средний балл: {mean.ToString("#.##")}");

            // Вывод новых данных по нажатию Enter
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Для отображения интерполяции строк нажмите Enter");
            ResetColor();
            while (ReadKey().Key != ConsoleKey.Enter) { }

            // Форматированный вывод данных в консоль
            string pattern = "Имя: {0} \nВозраст: {1} \nРост: {2} \nИстория: {3} \nМатематика: {4} \nРусский: {5}";
            WriteLine(pattern,
                        name,
                        age,
                        height,
                        history,
                        mathematics,
                        russian);

            WriteLine($"Средний балл: {mean.ToString("#.##")}");

            // Вывод новых данных по нажатию Enter
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Для отображения интерполяции строк нажмите Enter");
            ResetColor();
            while (ReadKey().Key != ConsoleKey.Enter) { }

            // Интерполированный вывод данных в консоль
            WriteLine($"Имя: {name} \nВозраст: {age} \nРост: {height} \nИстория: {history} \nМатематика: {mathematics} \nРусский: {russian}");

            WriteLine($"Средний балл: {mean.ToString("#.##")}");

            // Вывод новых данных по нажатию Enter
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Для отображения интерполяции строк нажмите Enter");
            ResetColor();
            while (ReadKey().Key != ConsoleKey.Enter) { }

            string[] str = { "Имя: Илья Мохноножкин", "Возраст: 16", "Рост: 208", "История: 3.4", "Математика: 4.7", "Русский: 2", "Средний балл: 3.37" };
            
            Print();
            void Print()
            {
                Console.Clear();
                int top = WindowHeight / 2 - str.Length / 2;
                for (int i = 0; i < str.Length; i++, top++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str[i].Length / 2, top);
                    Console.Write(str[i]); 
                }
            }

            ReadKey();
























        }


    }
}
