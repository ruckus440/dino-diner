using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class SodaSaurus
    {
        private SodaSaurusFlavor flavor = SodaSaurusFlavor.Cola;
        public SodaSaurusFlavor Flavor
        {

            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        private Size size;

        public override Size Size
        {

        }
        
    }   
}
