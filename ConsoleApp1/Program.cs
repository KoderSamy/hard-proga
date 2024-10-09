using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Иванов Иван Иванович", 20, "ПР-21", "123456789012345678901");
        Student student2 = new Student("Петрова Анна Сергеевна", 0, "ИС-22", "98765432109876543210");
        Student student3 = new Student("Сидоров Петр Алексеевич", 21, "КТ-20", "11112222333344445555");
        // Teacher teacher1 = new Teacher("Кузнецов Андрей Владимирович", 45, "Программирование");
        // Teacher teacher2 = new Teacher("Смирнова Елена Ивановна", 38, "Математика");

        List<string> teacherDisciplines = new List<string>() { "Программирование", "Математика", "Физика" };
        Teacher teacher1 = new Teacher("Кузнецов Андрей Владимирович", 45, teacherDisciplines);

        List<string> teacherDisciplines2 = new List<string>() { "1-C", "Философия", "Строительство" };
        Teacher teacher2 = new Teacher("Фёдоров Иван Сергеевич", 67, teacherDisciplines2);

        student1.ShowInformation();
        Console.WriteLine();
        student2.ShowInformation();
        Console.WriteLine();
        student3.ShowInformation();
        Console.WriteLine();
        teacher1.ShowInformation();
        Console.WriteLine();
        teacher2.ShowInformation();
    }
}