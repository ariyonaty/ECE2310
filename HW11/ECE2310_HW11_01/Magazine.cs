namespace ECE2310_HW11_01
{
    public class Magazine : ReadingMaterial
    {
        public string Series { get; set; } = "Series";
        public int IssueNumber { get; set; } = 1;

        public Magazine() { }

        public override string ToString()
        {
            return ($"*** Magazine Information ***\n{base.ToString()}\nSeries:\t\t\t{Series}\nIssue Number:\t\t{IssueNumber}");
        }
    }
}