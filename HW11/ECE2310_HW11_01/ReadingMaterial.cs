using System;

namespace ECE2310_HW11_01
{
    public class ReadingMaterial : IPrintable
    {
        public string Title { get; set; } = "Title";
        public string Subject { get; set; } = "Subject";
        public bool OnlineVersion { get; set; } = true;
        public int NumOfPages { get; set; } = 1;
        public string Genre { get; set; } = "Genre";
        public DateTime PubDate { get; set; } = new DateTime();

        public ReadingMaterial() { }

        public DateTime GetPubDate()
        {
            var datetime = PubDate;
            var date = datetime.Date;
            return date;
        }

        public override string ToString()
        {
            return ($"Title:\t\t\t{Title}\nSubject:\t\t{Subject}\nOnline Version:\t\t{OnlineVersion}\nNumber of Pages:\t{NumOfPages}\nPublication Date:\t{GetPubDate().ToShortDateString()}");
        }
    }
}