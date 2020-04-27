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
                if (value > 0)
                {
                    _unitPrice = Math.Round(value, 2);
                }
            }
        }
        public uint Quantity
        {
            get => _quantity;
            set
            {
                if (value > 0)
                {
                    _quantity = value;
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