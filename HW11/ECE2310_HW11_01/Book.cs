using System;

namespace ECE2310_HW11_01
{
    public class Book : ReadingMaterial
    {
        public long ISBN { get; set; } = 0;
        public string Author { get; set; } = "Author";
        public string Publisher { get; set; } = "Publisher";

        public Book() { }

        public override string ToString()
        {
            return ($"*** Book Information ***\n{base.ToString()}\nAuthor:\t\t\t{Author}\nPublisher:\t\t{Publisher}\nISBN:\t\t\t{ISBN:D13}");
        }
    }
}