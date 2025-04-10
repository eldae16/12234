using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        // Закрытые поля для хранения данных о ФИО и оценках
        private string fullName;
        private int grade1;
        private int grade2;

        // Свойства для доступа к закрытым полям
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int Grade1
        {
            get { return grade1; }
            set { grade1 = value; }
        }

        public int Grade2
        {
            get { return grade2; }
            set { grade2 = value; }
        }

        // Конструктор
        public Student(string fullName, int grade1, int grade2)
        {
            this.fullName = fullName;
            this.grade1 = grade1;
            this.grade2 = grade2;
        }

        // Метод для показа данных о студенте
        public void ShowStudentInfo()
        {
            Console.WriteLine($"ФИО: {fullName}");
            Console.WriteLine($"Оценка 1: {grade1}");
            Console.WriteLine($"Оценка 2: {grade2}");
        }

        // Метод для подсчета средней оценки студента
        public float SredOcenka()
        {
            return (grade1 + grade2) / 2.0f; // Возвращаем среднюю оценку в формате float
        }
    }
}
