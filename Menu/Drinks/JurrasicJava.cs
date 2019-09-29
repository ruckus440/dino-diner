using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Represents JurrasiJava menu item.  Inherits from Drink base class.
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Private Size backing variable.
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets and Sets Ice.  Defaults to false.
        /// </summary>
        public override bool Ice { get; set; } = false;
        /// <summary>
        /// Gets and Sets RoomForCream.  Defaults to false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Gets and Sets Decaf.  Defualts to false.
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// Gets and Sets the Size.  Sets Price and Calories according to Size.
        /// </summary>
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
        /// <summary>
        /// Method for setting RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        /// <summary>
        /// Method for adding ice.  Sets Ice to true.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
        /// <summary>
        /// JurrasicJava constructor.  Sets ingredients list.
        /// </summary>
        public JurrasicJava()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
        }

    }
}
