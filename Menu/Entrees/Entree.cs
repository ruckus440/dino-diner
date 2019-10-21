/* Entree.cs
 * Author: Mike Ruckert
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that entree menu items inherit from.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Indicates the price of the item.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Indicates the number of calories in the item.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Indicates the list of ingredients.  
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }
     
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
    }
}
