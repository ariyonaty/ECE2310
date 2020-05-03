using System;

namespace ECE2310_HW09_01
{
    public class Bread
    {
        private double _unitPrice = 2.50;
        private uint _quantity = 2;
        public double UnitPrice
        {
            get => _unitPrice;
            set
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] Setting unit price for Bread.");
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
                Console.WriteLine($"[+] Setting quantity for Bread.");
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

        public Bread() { }
        public Bread(double unitPrice, uint quantity)
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
            return ($"Product: Bread\tUnit Price: {UnitPrice:C2}\tQuantity: {Quantity}");
        }
    }
}