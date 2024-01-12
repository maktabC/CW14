using CW14.Models;

namespace CW14.Database;

public static class TempDatabase
{
    public static int Counter = 1;
    public static List<Book> books = new List<Book>()
    {
        new Book()
        {
            Id= Counter++,
            Title="Ashpazi",
            Writer="Reza",
            AddDate=DateTime.Now,  
            OwenrName="sahar"
        },
         new Book()
        {
            Id= Counter++,
            Title="tarikh",
            Writer="hasan",
            AddDate=DateTime.Now,
            OwenrName="asghar"
        },
          new Book()
        {
            Id= Counter++,
            Title="eghtesad",
            Writer="zahra joon",
            AddDate=DateTime.Now,
            OwenrName="hani"
        },
    };
}
