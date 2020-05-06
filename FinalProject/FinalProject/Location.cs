using System;

namespace FinalProject
{
    public class Location
    {
        private int _posX;
        private int _posY;

        public int PosX
        {
            get => _posX;
            set => _posX = value;
        }
        public int PosY
        {
            get => _posY;
            set => _posY = value;
        }

        public Location() { }
        public Location(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }

        public (int, int) Position()
        {
            return (PosX, PosY);
        }

        public override string ToString()
        {
            return ($"Location: ({PosX},{PosY})");
        }
    }
}