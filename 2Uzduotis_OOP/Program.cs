namespace _2Uzduotis_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> allBooks = new List<Book>();

            Book book1 = new Book("Harry Potter", "J.K.Rowling", 2007, "UK");
            allBooks.Add(book1);

            Book book2 = new Book("knyga", "Laura", 2005, "UK");
            allBooks.Add(book2);

            Book book3 = new Book("Harry Potter2", "J.K.Rowling", 2004, "UK");
            allBooks.Add(book3);




            List<Book> filterBooks = FindAuthorBooks(allBooks, "J.K.Rowling");

            foreach (Book book in filterBooks)
            {
                Console.WriteLine($"{book.Name} {book.Author} {book.Years} {book.Country}");
            }


        }
        public static List<Book> FindAuthorBooks(List<Book> books, string author)
        {
            List<Book> newBooks = new List<Book>();

            foreach (Book book in books)
            {
                if (book.Author == author)
                {
                    newBooks.Add(book);
                }
            }
            return newBooks;
        }
    }
}