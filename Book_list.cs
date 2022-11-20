using System.Runtime.CompilerServices;

internal class Book_List
{
    protected List<Book> books;

    public Book_List()
    {
        this.books = new List<Book>();
    }
    public void addBook()
    {
        Console.WriteLine("Введите название книги");
        string nameB = Console.ReadLine();
        Console.WriteLine("Введите жанр книги");
        string genreB = Console.ReadLine();
        Console.WriteLine("Введите год книги");
        uint ageB = uint.Parse(Console.ReadLine());
        this.books.Add(new Book(nameB, genreB, ageB));
    }
    public void removeBook()
    {
        int ind = int.Parse(Console.ReadLine()) - 1;
        if (ind < this.books.Count)
        {
            this.books.RemoveAt(ind);
        }
    }
    public Book this[int index]
    {
        get
        {
            if (index >= 0 && index < this.books.Count)
                return this.books[index];
            throw new IndexOutOfRangeException();
        }
    }
    public void readBook()
    {
        int ind = int.Parse(Console.ReadLine()) - 1;
        if (ind >= 0 && ind < this.books.Count)
            this.books[ind].Read = true;

    }
    public void showBooks()
    {
        foreach (Book item in books)
        {
            Console.WriteLine(item);
        }
    }
    public override string ToString()
    {
        return $"Список книг состоит из {this.books.Count} книг";
    }
}