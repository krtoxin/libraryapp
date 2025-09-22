namespace Domain;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }

    public Author() { }

    public Author(string name, int bookId)
    {
        Name = name;
        BookId = bookId;
    }
}