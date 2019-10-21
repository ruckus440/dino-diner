using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void CorrectSubtotalCost()
        {
            Order order = new Order(0);
            Brontowurst brontowurst = new Brontowurst();
            Fryceritops fryceritops = new Fryceritops();
            Sodasaurus sodasaurus = new Sodasaurus();
            order.Items.Add(brontowurst);
            order.Items.Add(fryceritops);
            order.Items.Add(sodasaurus);
            Assert.Equal<Double>(7.85, order.SubtotalCost);
        }
    }
}
