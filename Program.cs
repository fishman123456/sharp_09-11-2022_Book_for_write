using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создайте проложение "Список книг для прочтения".
        // Приложение должно позволять добавлять книги в список, удалять книги из списка,
        // проверять прочитанна ли книга, обращаясь к ней по индексу.
        // Используйте механизм свойств, перегрузки операторов (true, false), индексаторов
        // Создать простое меню выбора
        int menu = 0;

        // создаём список книг
        List<Book> books = new List<Book> {
        new Book ("first",false),
        new Book ("Second",false),
        new Book ("fourth",false),
        new Book ("fifth",false),
        new Book ("Sixth",false),
        new Book ("seventh",false),
        new Book ("eighth",false),
        new Book ("ninth",false),
        new Book ("tenth",false),
        new Book ("-",false),
        };
        do
        {
            Console.WriteLine("Список книг для прочтения");
            Console.WriteLine();
            Console.WriteLine("1 добавить элемент");
            Console.WriteLine("2 удалить элемент");
            Console.WriteLine("3 проверка на прочтение");
            Console.WriteLine("4 выыод на консоль");
            Console.WriteLine("5 очистка экрана");
            Console.WriteLine("0 выход");
            Console.WriteLine(DateTime.Now);
            menu = Convert.ToInt32(Console.ReadLine());
            
            switch (menu)
            {
                case 0:

                    break;

                case 1:
                    //Добавим новый элемент списка
                    Console.WriteLine();
                    Console.WriteLine("Добавляем элемент в список по индексу \t");
                    Console.WriteLine("От 0..{0}", books.Count-1);
                    int num_el = Convert.ToInt32(Console.ReadLine());
                  string  book_n =Console.ReadLine();
                    books.Insert(num_el, new Book(book_n, false));

                    break;
                case 2:
                    //Удалим элемент из списка
                    Console.WriteLine();
                    Console.WriteLine("Удаляем элемент из списка");
                    Console.WriteLine("От 0..{0}", books.Count-1);
                    num_el = Convert.ToInt32(Console.ReadLine());
                    
                    books.RemoveAt(num_el);

                    break;
                case 3:
                    //проверка книги на прочтение
                    //Посмотрим на все элементы списка
                   
                    Console.WriteLine("Нужна проверка для второго поля прочитана книга или нет");
                    
                    break;
                case 4:
                    //выводим количество элементов на консоль
                    Console.WriteLine();
                    Console.WriteLine("Количество элементов в books:{0}", books.Count);
                    Console.WriteLine();
                    Console.WriteLine("Имя книги ");
                    books.ForEach(p => Console.WriteLine(p._name));
                   
                    break;
                case 5:
                    // очистка экрана
                    Console.Clear();
                    break;

                //default: throw new ArgumentException("Недопустимый ввод");

            }
        } while (menu != 0);
    }
    // Создаём класс книга с полями имя и прочитанна или нет
    class Book
    {
        public string? _name { get; set; } // сеттеры и геттеры
        public bool? _read { get; set; }
        public Book() { }
        public Book(string name, bool read)
        {
            _name = name; _read = read;
        }
    }
}
//54545454
//аааааааааааа
//апвыапвап
////Можно создать пустой список и добавить в него элементы позже, с помощью метода Add():
//List<int> numsList = new List<int>();
//numsList.Add(1);

////Либо воспользоваться синтаксисом, позволяющем указать набор объектов, который будет храниться в списке:
//List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
//var words = new List<string> { "one", "two", "three" };