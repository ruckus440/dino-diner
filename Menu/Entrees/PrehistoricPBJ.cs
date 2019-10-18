/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Mike Ruckert
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Prehistoric PBJ entree menu item.  Inherits from the Entree class.
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Boolean to indicate whether peanut butter is held.
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Boolean to indicate whether jelly is held.
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// The PropertyChanged event handler; 
        /// notifies of changes to the Price, Description, 
        /// and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        /// <summary>
        /// Overrides the Entree Ingredients property.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Class constructors.  Sets the Price and Calories.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Method to hold the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to hold the jelly.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");

        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Gets and sets the description
        /// </summary>
        /// <returns></returns>
        public string Description
        {
            get { return this.ToString();  }
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (!peanutButter) specials.Add("Hold Peanut Butter");
                if (!jelly) specials.Add("Hold Jelly");
                return specials.ToArray();
            }
        }
    }
}
