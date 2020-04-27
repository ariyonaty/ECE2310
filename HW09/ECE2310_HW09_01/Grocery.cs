namespace ECE2310_HW09_01
{
    public class Grocery
    {
        Eggs eggs;
        Bread bread;
        Milk milk;

        public Eggs MyEggs
        {
            get => eggs;
            set => eggs = value;
        }
        public Bread MyBread
        {
            get => bread;
            set => bread = value;
        }
        public Milk MyMilk
        {
            get => milk;
            set => milk = value;
        }

        public Grocery()
        {
            eggs = new Eggs();
            bread = new Bread();
            milk = new Milk();
        }
        public Grocery(Eggs eggs, Milk milk, Bread bread)
        {
            MyEggs = eggs;
            MyMilk = milk;
            MyBread = bread;
        }

        public double Expense()
        {
            double expense = MyBread.TotalPrice() + MyEggs.TotalPrice() + MyMilk.TotalPrice();
            return expense;
        }
        public override string ToString()
        {
            return ($"\t\t*** My Groceries ***\n{MyEggs.ToString()}\n{MyBread.ToString()}\n{MyMilk.ToString()}\n[+] Expense:\t{Expense():C2}");
        }
    }
}