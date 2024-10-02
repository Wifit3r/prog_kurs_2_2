using System.Collections.ObjectModel;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
namespace Lab2
{
    class Program
    {
        
            public class Bibliothek
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
        }

        public class Reader
        {
            public string LastName { get; set; }
            public int BookId { get; set; }
            public DateTime BorrowDate { get; set; }
            public DateTime? ReturnDate { get; set; }
        }
        public static void Main() {



            List<Bibliothek> books = new List<Bibliothek>
{
    new Bibliothek { BookId = 1, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
    new Bibliothek { BookId = 2, Title = "1984", Author = "George Orwell" },
    new Bibliothek { BookId = 3, Title = "Pride and Prejudice", Author = "Jane Austen" },
    new Bibliothek { BookId = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
    new Bibliothek { BookId = 5, Title = "Moby-Dick", Author = "Herman Melville" },
    new Bibliothek { BookId = 6, Title = "War and Peace", Author = "Leo Tolstoy" },
    new Bibliothek { BookId = 7, Title = "The Catcher in the Rye", Author = "J.D. Salinger" },
    new Bibliothek { BookId = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
    new Bibliothek { BookId = 9, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky" },
    new Bibliothek { BookId = 10, Title = "The Odyssey", Author = "Homer" },
    new Bibliothek { BookId = 11, Title = "Brave New World", Author = "Aldous Huxley" },
    new Bibliothek { BookId = 12, Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky" },
    new Bibliothek { BookId = 13, Title = "Jane Eyre", Author = "Charlotte Brontë" },
    new Bibliothek { BookId = 14, Title = "Wuthering Heights", Author = "Emily Brontë" },
    new Bibliothek { BookId = 15, Title = "The Divine Comedy", Author = "Dante Alighieri" },
    new Bibliothek { BookId = 16, Title = "The Iliad", Author = "Homer" },
    new Bibliothek { BookId = 17, Title = "One Hundred Years of Solitude", Author = "Gabriel Garcia Marquez" },
    new Bibliothek { BookId = 18, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde" },
    new Bibliothek { BookId = 19, Title = "The Grapes of Wrath", Author = "John Steinbeck" },
    new Bibliothek { BookId = 20, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien" }
};


            List<Reader> readers = new List<Reader>
            {
            new Reader { LastName = "Іваненко", BookId = 1, BorrowDate = new DateTime(2024, 1, 15), ReturnDate = new DateTime(2024, 3, 10) },
    new Reader { LastName = "Петренко", BookId = 2, BorrowDate = new DateTime(2024, 2, 22), ReturnDate = new DateTime(2024, 7, 25) },
    new Reader { LastName = "Сидоренко", BookId = 3, BorrowDate = new DateTime(2024, 3, 5), ReturnDate = new DateTime(2024, 8, 15) },
    new Reader { LastName = "Коваленко", BookId = 4, BorrowDate = new DateTime(2024, 4, 10), ReturnDate = new DateTime(2024, 9, 20) },
    new Reader { LastName = "Шевченко", BookId = 5, BorrowDate = new DateTime(2024, 5, 18), ReturnDate = new DateTime(2024, 10, 25) },
    new Reader { LastName = "Мельник", BookId = 6, BorrowDate = new DateTime(2024, 6, 22), ReturnDate = null },
    new Reader { LastName = "Бондаренко", BookId = 7, BorrowDate = new DateTime(2024, 7, 1), ReturnDate = new DateTime(2024, 12, 5) },
    new Reader { LastName = "Ткаченко", BookId = 8, BorrowDate = new DateTime(2024, 8, 15), ReturnDate = new DateTime(2025, 1, 10) },
    new Reader { LastName = "Кравченко", BookId = 9, BorrowDate = new DateTime(2024, 9, 20), ReturnDate = new DateTime(2025, 2, 15) },
    new Reader { LastName = "Олійник", BookId = 10, BorrowDate = new DateTime(2024, 10, 25), ReturnDate = new DateTime(2025, 3, 20) },
    new Reader { LastName = "Лисенко", BookId = 11, BorrowDate = new DateTime(2024, 11, 30), ReturnDate = new DateTime(2025, 4, 25) },
    new Reader { LastName = "Гончаренко", BookId = 12, BorrowDate = new DateTime(2024, 12, 5), ReturnDate = new DateTime(2025, 5, 30) },
    new Reader { LastName = "Романенко", BookId = 13, BorrowDate = new DateTime(2024, 1, 10), ReturnDate = new DateTime(2024, 6, 5) },
    new Reader { LastName = "Дмитренко", BookId = 14, BorrowDate = new DateTime(2024, 2, 15), ReturnDate = new DateTime(2024, 7, 10) },
    new Reader { LastName = "Захарченко", BookId = 15, BorrowDate = new DateTime(2024, 3, 20), ReturnDate = null },
    new Reader { LastName = "Мороз", BookId = 16, BorrowDate = new DateTime(2024, 4, 25), ReturnDate = null },
    new Reader { LastName = "Кузьменко", BookId = 17, BorrowDate = new DateTime(2024, 5, 30), ReturnDate = new DateTime(2024, 10, 25) },
    new Reader { LastName = "Савченко", BookId = 18, BorrowDate = new DateTime(2024, 6, 5), ReturnDate = null },
    new Reader { LastName = "Павленко", BookId = 19, BorrowDate = new DateTime(2024, 7, 10), ReturnDate = new DateTime(2024, 12, 5) },
    new Reader { LastName = "Рябченко", BookId = 20, BorrowDate = new DateTime(2024, 8, 15), ReturnDate = new DateTime(2025, 1, 10) },
    new Reader { LastName = "Бондаренко", BookId = 4, BorrowDate = new DateTime(2024, 7, 1), ReturnDate = new DateTime(2024, 12, 5) },
    new Reader { LastName = "Кузьменко", BookId = 13, BorrowDate = new DateTime(2024, 5, 30), ReturnDate = new DateTime(2024, 10, 25) },
    new Reader { LastName = "Кузьменко", BookId = 8, BorrowDate = new DateTime(2024, 5, 30), ReturnDate = new DateTime(2024, 10, 25) },

};

            TaskD(books,readers);
            
            
            static void TaskA(List<Reader> readers)
            {
                var TYear = DateTime.Now.Year - 1;
                var WhoBorrowed = readers.Where(reader => reader.BorrowDate.Year <= TYear).Select(reader => reader.LastName);
                foreach (var reader in WhoBorrowed)
                {
                    Console.WriteLine(reader);
                }
            }
            
            static void TaskB(List<Bibliothek> books, List<Reader> readers)
            {
                var bookStats = books.GroupJoin(
                    readers,
                    book => book.BookId,
                    reader => reader.BookId,
                    (book, bookR) => new
                    {
                        BookId = book.BookId,
                        Title = book.Title,
                        BorrowCount = bookR.Count(),
                        ReturnCount = bookR.Count(reader => reader.ReturnDate.HasValue)
                    });

                foreach (var info in bookStats)
                {
                    Console.WriteLine($"BookId: {info.BookId}, Title: {info.Title}, Borrowed copyes {info.BorrowCount}, Returned copyes: {info.ReturnCount}");
                }
            }
            
            static void TaskD(List<Bibliothek> books, List<Reader> readers)
            {
                var readerAuthors = readers.GroupBy(reader => reader.LastName)
                    .Select(group => new
                    {
                        LastName = group.Key,
                        AuthorCount = group.Select(reader => books.First(book => book.BookId == reader.BookId).Author).Count()
                    })
                    .OrderByDescending(reader => reader.AuthorCount)
                    .FirstOrDefault();

                if (readerAuthors != null)
                {
                    Console.WriteLine($"Reader: {readerAuthors.LastName}, Authors: {readerAuthors.AuthorCount}");
                }
            }
        }
    };
}
