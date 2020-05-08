using System;

namespace ECE2310_HW11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Magazine magazine = new Magazine();

            book.Title = "Harry Potter and The Battle of Polymorphism";
            book.Author = "JK Rowling";
            book.ISBN = 1357246819281;
            book.OnlineVersion = true;
            book.Genre = "Fantasy Fiction";
            book.Subject = "Magical";
            book.Publisher = "Bloomsbury Publishing";
            book.NumOfPages = 540;
            book.PubDate = new DateTime(2000, 10, 1);

            magazine.Title = "Popular Science";
            magazine.Series = "Robotics";
            magazine.Genre = "Science and Education";
            magazine.IssueNumber = 47;
            magazine.NumOfPages = 59;
            magazine.OnlineVersion = false;
            magazine.PubDate = new DateTime(2017, 5, 2);

            Console.WriteLine(book);
            Console.WriteLine();
            Console.WriteLine(magazine);
        }
    }
}
