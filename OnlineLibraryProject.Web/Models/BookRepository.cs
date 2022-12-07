namespace OnlineLibraryProject.Web.Models
{
    public class BookRepository
    {
        private static List<Book> _books = new List<Book>()
        {
            new (){Id=1,Name="Ömerin Suçu NE",Stock=100,Year=2012,PageNumber=44},
            new (){Id=2,Name="Sql hate You *:(",Stock=200,Year=2009,PageNumber=44},
            new (){Id=1,Name="Ömerin çilesi",Stock=999,Year=2022,PageNumber=44}

        };
        public List<Book> GetAll() => _books;

        public void Add(Book newBook)=> _books.Add(newBook);

        public void Remove(int id)
        {
            var hasBook=_books.FirstOrDefault(x => x.Id == id);
            if (hasBook == null)
            {
                throw new Exception($"Bu id({id})'ye sahip kitap bulunmamaktadir.");
            }
            _books.Remove(hasBook);
        }
        public void Update(Book updateBook)
        {
            var hasBook=_books.FirstOrDefault(x=>x.Id== updateBook.Id);
            if (hasBook == null)
            {
                throw new Exception($"Bu id({updateBook.Id})'ye sahip kitap bulunmamaktadir.");
            }
            hasBook.Name = updateBook.Name;
            hasBook.Stock=updateBook.Stock;
            hasBook.Year=updateBook.Year;

            var index=_books.FindIndex(x=> x.Id==updateBook.Id);

            _books[index] = hasBook;
        }
    }
}
