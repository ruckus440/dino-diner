/* CretaceousCombo.cs
 * Author: Nathan Bean
 * Modified by: Mike Ruckert
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Gathers entree, drink and side for combo
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        // Backing Variables
        private Size size;
        private Entree entree;

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }


        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        /// <summary>
        /// Overrides the default ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Entree} Combo";
        }

        /// <summary>
        /// Gets the description of the item.
        /// </summary>
        public string Description
        {
            get { return this.ToString();}
        }

        /// <summary>
        /// Gets the special instruction for the items
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }

        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NotifyChangeSize()
        {
            NotifyOfPropertyChange("Size");
            NotifyOfPropertyChange("Calories");
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
        }
    }
}
