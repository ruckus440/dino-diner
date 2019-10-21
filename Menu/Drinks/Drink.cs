/* Drink.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Drink base class
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredient list
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }
               
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets or sets whether to include ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Sets Ice to false to hold the ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

        /// <summary>
        /// Gets special instructions
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets item description
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The PropertyChanged event handler; 
        /// notifies of changes to the Price, Description, 
        /// and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies of property changed.
        /// </summary>
        /// <param name="propertyName">The changed property</param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NotifyChangeSize()
        {
            NotifyOfPropertyChange("Size");
            NotifyOfPropertyChange("Calories");
            NotifyOfPropertyChange("Price");
        }
    }
}
