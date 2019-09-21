using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
    {
        public virtual double Price { get; set; }
        public virtual uint Calories { get; set; }
        public virtual List<string> Ingredients { get; protected set; }
    }
}
