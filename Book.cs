internal class Book
{
    protected string? name;
    protected string? genre;
    protected uint year;
    protected bool read = false;
    public Book() { }
    public Book(string nameP, string genreP, uint yearP)
    {
        this.name = nameP;
        this.genre = genreP;
        this.year = yearP;
    }
    public string? Name
    {
        get { return name; }
        set { this.name = value; }
    }
    public string? Genre
    {
        get { return this.genre; }
        set { this.genre = value; }
    }
    public uint Year
    {
        get { return this.year; }
        set { this.year = value; }
    }
    public bool Read
    {
        set { this.read = value; }
    }
    public static bool operator true(Book obj)
    {
        return obj.read;
    }
    public static bool operator false(Book obj)
    {
        return obj.read;
    }
    public override string ToString()
    {
        return $"\"{this.name}\" ({this.genre}) : {this.year} г."
            + (this.read == false ? "Не прочитана" : "Прочитана");
    }
}