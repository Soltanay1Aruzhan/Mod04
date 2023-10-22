using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using Task3;

namespace Mod04prac
{
    //TASK1
    struct Student
    {
        public string Name;
        public string GroupNumber;
        public int[] Grades;

        //Рассчет средней оценки
        public double GetAverageGrade()
        {
            int sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Создание массивов со студентами
            Student[] students = new Student[10];
            students[0] = new Student { Name = "Valentin", GroupNumber = "G1", Grades = new int[] { 4, 5, 5, 4, 4 } };
            students[1] = new Student { Name = "Amir", GroupNumber = "G2", Grades = new int[] { 5, 5, 5, 5, 5 } };
            students[2] = new Student { Name = "Diana", GroupNumber = "G1", Grades = new int[] { 3, 4, 4, 5, 3 } };
            students[3] = new Student { Name = "Vladislav", GroupNumber = "G1", Grades = new int[] { 4, 5, 5, 4, 4 } };
            students[4] = new Student { Name = "Muhammedali", GroupNumber = "G2", Grades = new int[] { 3, 4, 3, 4, 4 } };
            students[5] = new Student { Name = "Alisher", GroupNumber = "G1", Grades = new int[] { 5, 5, 5, 5, 5 } };
            students[6] = new Student { Name = "Dias", GroupNumber = "G1", Grades = new int[] { 4, 5, 5, 4, 4 } };
            students[7] = new Student { Name = "Viacheslav", GroupNumber = "G2", Grades = new int[] { 5, 5, 5, 5, 5 } };
            students[8] = new Student { Name = "Tamerlan", GroupNumber = "G1", Grades = new int[] { 3, 4, 4, 5, 3 } };
            students[9] = new Student { Name = "Dimon", GroupNumber = "G1", Grades = new int[] { 3, 4, 4, 5, 3 } };
            // Сортировка
            Array.Sort(students, (s1, s2) => s1.GetAverageGrade().CompareTo(s2.GetAverageGrade()));
            Console.WriteLine("Студенты с оценками 4 или 5:");
            foreach (var student in students)
            {
                double avgGrade = student.GetAverageGrade();
                if (avgGrade >= 4 && avgGrade <= 5)
                {
                    Console.WriteLine($"Name: {student.Name}, Group: {student.GroupNumber}, Average Grade: {avgGrade}");
                }
            }



            //TASK2
            Создание списка животных
            List<Animal> animals = new List<Animal> {
            new Carnivore { Id = 1, Name = "Lion" },
            new Carnivore { Id = 2, Name = "Tiger" },
            new Omnivore { Id = 3, Name = "Bear" },
            new Herbivore { Id = 4, Name = "Elephant" },
            new Carnivore { Id = 5, Name = "Pantera" },
            new Omnivore { Id = 6, Name = "Pig" },
            new Herbivore { Id = 7, Name = "Cow" },
            };
            //Расчет пищи для каждого животного
            foreach (var animal in animals)
            {
                animal.CalculateFood();
            }
            //Упорядочиваем животных
            animals.Sort();
            Console.WriteLine("Упорядоченный список животных по убыванию количества пищи и имени:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"ID: {animal.Id}, Name: {animal.Name}, Type: {animal.GetType().Name}, Food Amount: {animal.FoodAmount}, Food Type: {animal.FoodType}");
            }
            //Выводим первые 5 имен животных
            Console.WriteLine("\nПервые 5 имен животных:");
            foreach (var animal in animals.Take(5))
            {
                Console.WriteLine(animal.Name);
            }
            //Выводим последние 3 идентификатора животных
            Console.WriteLine("\nПоследние 3 идентификатора животных:");
            foreach (var animal in animals.Skip(Math.Max(0, animals.Count - 3)))
            {
                Console.WriteLine($"ID: {animal.Id}");
            }
            //Записываем данные в файл
            WriteAnimalsToFile(animals, "C:\\Users\\Alisher\\Desktop\\PAPKI\\Univer\\С5\\Intership\\Mod04prac\\Mod04prac\\animals.txt");



            //TASK3
            Library library = new Library();
            //Добавление книг в библиотеку
            library.AddBook(new Book { Title = "Book1", Author = "Author1", Year = 2000 });
            library.AddBook(new Book { Title = "Book2", Author = "Author2", Year = 1999 });
            library.AddBook(new Book { Title = "Book3", Author = "Author1", Year = 2010 });
            library.AddBook(new Book { Title = "Book4", Author = "Author1", Year = 2010 });
            library.AddBook(new Book { Title = "Book5", Author = "Author2", Year = 2000 });
            Console.WriteLine("Все книги:");
            library.DisplayBooks();
            Console.WriteLine("\nКниги от Author1:");
            List<Book> booksByAuthor1 = library.SearchByAuthor("Author1");
            foreach (var book in booksByAuthor1)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\nКниги из 2000:");
            List<Book> booksFrom2000 = library.SearchByYear(2000);
            foreach (var book in booksFrom2000)
            {
                Console.WriteLine(book);
            }
            library.SortByTitle();
            Console.WriteLine("\nКниги по названию:");
            library.DisplayBooks();

            library.RemoveBook("Book2");
            Console.WriteLine("\nБиблиотка  после удаления Book2:");
            library.DisplayBooks();

        }

        //TASK4
        static void WriteAnimalsToFile(List<Animal> animals, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"{animal.Id},{animal.Name},{animal.GetType().Name},{animal.FoodAmount},{animal.FoodType}");
                }
            }
            Console.WriteLine($"\nДанные записаны в файл: {filePath}");
        }

    }
}
