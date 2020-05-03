using System;

namespace ECE2310_HW09_01
{
    public class Eggs
    {
        private double _unitPrice = 4.00;
        private uint _quantity = 3;
        public double UnitPrice
        {
            get => _unitPrice;
            set
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] Setting unit price for Eggs.");
                Console.ResetColor();
                if (value > 0)
                {
                    _unitPrice = Math.Round(value, 2);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[-] Unit price value was not valid.");
                    Console.ResetColor();
                }
            }
        }
        public uint Quantity
        {
            get => _quantity;
            set
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] Setting quantity for Eggs.");
                Console.ResetColor();
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[-] Quantity value was not valid.");
                    Console.ResetColor();
                }
            }
        }

        public Eggs() { }
        public Eggs(double unitPrice, uint quantity)
        {
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
        }

        public double TotalPrice()
        {
            return (Math.Round(UnitPrice * Quantity, 2));
        }
        public override string ToString()
        {
            return ($"Product: Eggs\tUnit Price: {UnitPrice:C2}\tQuantity: {Quantity}");
        }
    }
}