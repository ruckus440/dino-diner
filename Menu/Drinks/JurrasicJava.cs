using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        private Size size;
        public override bool Ice { get; set; } = false;
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = .59;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        this.Price = .99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        public void AddIce()
        {
            this.Ice = true;
        }
        public JurrasicJava()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
        }

    }
}
