using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создание объекта класса Student
            Student student = new Student("Иванов", 3, 5);

            // 3. Вывод на экран данных о студенте
            student.ShowStudentInfo();

            // 4. Расчет и вывод средней оценки студента
            float averageGrade = student.SredOcenka();
            Console.WriteLine($"Средняя оценка: {averageGrade}");
        }
    }
}
