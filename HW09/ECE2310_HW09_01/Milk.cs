using System;

namespace ECE2310_HW09_01
{
    public class Milk
    {
        private double _unitPrice = 4.75;
        private uint _quantity = 1;
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

        public Milk() { }
        public Milk(double unitPrice, uint quantity)
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
            return ($"Product: Milk\tUnit Price: {UnitPrice:C2}\tQuantity: {Quantity}");
        }
    }
}