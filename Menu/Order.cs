/* Order.cs
 * Auther: Mike Ruckert
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// Private backing variable.  Sets the tax rate.
        /// </summary>
        private double rate = .085;

        /// <summary>
        /// Private backing variable.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The PropertyChanged event handler, notifies when an order property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        public Order()
        {
            
        }

        /// <summary>
        /// The array of items to display.
        /// </summary>
        public IOrderItem[] Items 
        {
            get
            {
                return items.ToArray();
            }           
        } 

        /// <summary>
        /// Caclulates the Subtotal
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double sum = 0;
                foreach (IOrderItem item in Items)
                {
                    sum += item.Price;
                }
                if (sum >= 0) 
                    return sum;
                else
                    return 0;
            }
        }

        /// <summary>
        /// Gets and sets the tax rate.
        /// </summary>
        public double SalesTaxRate 
        {
            get
            {
                return rate;
            }
            protected set { } 
        }

        /// <summary>
        /// Calculates the Sales tax cost.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        /// <summary>
        /// Calculates the total cost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
                     
        /// <summary>
        /// Adds the item to the order.  Notifies property changed.
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertyChanged();
        }

        /// <summary>
        /// Removes and item from the order.  Notifies property changed.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertyChanged();
            }
            return removed;
        }

        /// <summary>
        /// Notifies all property changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertyChanged();
        }

        /// <summary>
        /// Notifies all properties changed.
        /// </summary>
        protected void NotifyAllPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        
    }
}
