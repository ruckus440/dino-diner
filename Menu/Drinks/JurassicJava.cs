/* JurrasicJava.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents JurrasiJava menu item.  Inherits from Drink base class.
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Private Size backing variable.
        /// </summary>
        private Size size;

        /// <summary>
        /// Returns the description of this order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Room for Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }

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
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

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
                        NotifyChangeSize();
                        break;
                    case Size.Medium:
                        this.Price = .99;
                        this.Calories = 4;
                        NotifyChangeSize();
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        NotifyChangeSize();
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for adding ice.  Sets Ice to true.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        public void MakeDecaf()
        {
            this.Decaf = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// JurrasicJava constructor.  Sets ingredients list.
        /// </summary>
        public JurassicJava()
        {
            this.Size = Size.Small;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
        }

        /// <summary>
        /// Overrides the default ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString() + " ");
            if (Decaf)
                sb.Append("Decaf ");
            sb.Append("Jurassic Java");
            return sb.ToString();
        }
    }
}
