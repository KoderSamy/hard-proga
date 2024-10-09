using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Teacher : Person
    {
        public List<string> Disciplines;
        public string Discipline;

        public Teacher(string fullName, int age, List<string> disciplines) : base(fullName, age)
        {
            // Проверяем, что ФИО не пустое, список дисциплин не пустой и не null, и возраст больше 0
            if (string.IsNullOrEmpty(fullName) || disciplines == null || disciplines.Count == 0 || age <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: Некорректные данные преподавателя!");
                Console.ResetColor();
                return;
            }

            Disciplines = disciplines;
        }

        public void ShowInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string title = "Карточка преподавателя";
            string fullNameLine = $"║ ФИО: {FullName}";
            string ageLine = $"║ Возраст: {Age}";
            string disp = "Дисциплины:";
            // string disciplineLine = $"║ Дисциплина: {Discipline}";

            // Находим длину самой длинной строки, включая "║ Дисциплина: "
            int maxDisciplineLength = 0;
            foreach (string discipline in Disciplines)
            {
                if (discipline.Length > maxDisciplineLength)
                {
                    maxDisciplineLength = discipline.Length;
                }
            }
            int maxLength = Math.Max(Math.Max(fullNameLine.Length, ageLine.Length), 
                                "║ Дисциплины: ".Length + maxDisciplineLength);

            // Находим самую длинную строку среди строк карточки преподавателя
            // int maxLength = Math.Max(Math.Max(fullNameLine.Length, ageLine.Length),
            //                     disciplineLine.Length);

            string topBorder = new string('═', maxLength + 1);

            Console.WriteLine($"╔{topBorder}╗");
            Console.WriteLine($"║ {title.PadRight(maxLength - 1)} ║");
            Console.WriteLine($"╚{topBorder}╝");
            Console.WriteLine($"{fullNameLine.PadRight(maxLength + 1)} ║");
            Console.WriteLine($"{ageLine.PadRight(maxLength + 1)} ║");
            // Console.WriteLine($"{disciplineLine.PadRight(maxLength + 1)} ║");

            // Вывод списка дисциплин
            Console.WriteLine($"║ {disp.PadRight(maxLength - 1)} ║");
            foreach (string discipline in Disciplines)
            {
                Console.WriteLine($"║   - {discipline.PadRight(maxLength - 5)} ║");
            }

            Console.WriteLine($"╚{topBorder}╝");
            Console.ResetColor();
        }
    }
}