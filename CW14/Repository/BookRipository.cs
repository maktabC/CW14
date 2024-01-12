using CW14.Models;
using CW14.Database;
namespace CW14.Repository;

public class BookRipository
{
    public void AddBook(Book book)
    {
        TempDatabase.books.Add(book);
    }
    public Book GetBookById(int id)
    {
        return TempDatabase.books.FirstOrDefault(b => b.Id == id);
    }
    public void UpdateBook(UpdateDTO update,int id)
    {
      var targetBook=GetBookById(id);
        if (targetBook != null)
        {
            targetBook.Title = update.Title;
            targetBook.Writer = update.Writer;
            targetBook.AddDate = update.AddDate;
            targetBook.OwenrName = update.OwenrName;
            //return targetBook;
        }
       // return null;
    }
    public void DeleteBook(int id)
    {
        var targetBook=GetBookById(id);
        if (targetBook != null)
        {
            TempDatabase.books.Remove(targetBook);
        }
    }
    public List<Book> GetAllBook()
    {
        return TempDatabase.books;
    }
}
