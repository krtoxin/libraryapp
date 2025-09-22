namespace Domain;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Author> Authors { get; set; }

    public Book()
    {
        Authors = new List<Author>();
    }

    public Book(string title)
    {
        Title = title;
        Authors = new List<Author>();
    }
}