using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        public string GroupNumber;
        public string RecordBookNumber;

        public Student(string fullName, int age, string groupNumber, string recordBookNumber) : base(fullName, age)
        {
             // Проверяем, что ФИО, номер группы, номер зачетки не пустые, и возраст больше 0
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(groupNumber) || string.IsNullOrEmpty(recordBookNumber) || age <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: Некорректные данные студента!");
                Console.ResetColor();
                return;
            }

            GroupNumber = groupNumber;
            RecordBookNumber = recordBookNumber.Substring(0, Math.Min(recordBookNumber.Length, 20)); // Присваиваем свойству RecordBookNumber подстроку переданного номера зачетки, обрезанную до 20 символов
        }

        public void ShowInformation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            string title = "Карточка студента";
            string fullNameLine = $"║ ФИО: {FullName}";
            string ageLine = $"║ Возраст: {Age}";
            string groupLine = $"║ Группа: {GroupNumber}";
            string recordBookLine = $"║ № зачетки: {RecordBookNumber}";

            // Находим самую длинную строку среди строк карточки студента
            int maxLength = Math.Max(Math.Max(fullNameLine.Length, ageLine.Length),
                                Math.Max(groupLine.Length, recordBookLine.Length));

            string topBorder = new string('═', maxLength + 1); // Формируем строку для верхней и нижней границ карточки, повторяя символ '═' нужное количество раз

            Console.WriteLine($"╔{topBorder}╗");
            Console.WriteLine($"║ {title.PadRight(maxLength - 1)} ║");
            Console.WriteLine($"╚{topBorder}╝");
            Console.WriteLine($"{fullNameLine.PadRight(maxLength + 1)} ║");
            Console.WriteLine($"{ageLine.PadRight(maxLength + 1)} ║");
            Console.WriteLine($"{groupLine.PadRight(maxLength + 1)} ║");
            Console.WriteLine($"{recordBookLine.PadRight(maxLength + 1)} ║");
            Console.WriteLine($"╚{topBorder}╝");
            Console.ResetColor();
        }
    }
}