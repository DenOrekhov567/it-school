/*
 * 
 * Изучаемые вопросы:
 * точка входа программы; 1
 * инструкции; 5
 * регистрозависимость; 6
 * комментарии; 2
 * файл проекта; 3
 * 
 * перменные; 4
 * константы; 7
 * литералы; 8
 * константы. 9
 * 
 */

namespace DPALesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Переменные
            string name;
            name = "Tom";

            // Регистрозависимость
            //Name = "Tom2"; // Не работает

            // Литералы
            string newName = "Jesica";

            // Константы
            const double PI = 3.14;
        }
    }
}