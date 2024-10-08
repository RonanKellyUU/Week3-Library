class Book
{
    //properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for book object (must be same name as class)
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;

    }

    void DisplayInfo()
    {

        // output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book.Title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book Length {NoOfPages}");
        Console.WriteLine();

    }

    static void Main(string[] args)
    {
        Book book1 = new Book("C# for Beginners","Bill gates","123456789",200);
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);
        //output book info to the console

        book1.DisplayInfo();
        book2.DisplayInfo();



    }
}