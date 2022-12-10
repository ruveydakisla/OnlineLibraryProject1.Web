using EntityLayer.Concrete;


namespace OnlineLibraryProject.Web.Models
{
    public class BookRepository
    {
        private static List<Book> _books = new List<Book>()
        {
            //new (){Id=1,Name="Ömerin Suçu NE",Stock=100,Year=2012},
            //new (){Id=2,Name="Sql hate You *:(",Stock=200,Year=2009},
            //new (){Id=1,Name="Ömerin çilesi",Stock=999,Year=2022}

        };
        public List<Book> GetAll() => _books;

        public void Add(Book newBook)=> _books.Add(newBook);

        public void Remove(int id)
        {
            var hasBook=_books.FirstOrDefault(x => x.BookID == id);
            if (hasBook == null)
            {
                throw new Exception($"Bu id({id})'ye sahip kitap bulunmamaktadir.");
            }
            _books.Remove(hasBook);
        }
        public void Update(Book updateBook)
        {
            var hasBook=_books.FirstOrDefault(x=>x.BookID == updateBook.BookID);
            if (hasBook == null)
            {
                throw new Exception($"Bu id({updateBook.BookID})'ye sahip kitap bulunmamaktadir.");
            }
            hasBook.Name = updateBook.Name;
            hasBook.Stock=updateBook.Stock;
            hasBook.Year=updateBook.Year;

            var index=_books.FindIndex(x=> x.BookID ==updateBook.BookID);

            _books[index] = hasBook;
        }
    }
}
