using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public enum Type
    {
        Honda,
        Toyota,
        Volvo,
        Audi
    }

    public enum Color
    {
        Black,
        Red,
        Blue
    }

    class Car
    {
        private Type type;
        public Type Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        private Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Car(Type type, Color color)
        {
            this.type = type;
            this.color = color;
        }
    }
}
