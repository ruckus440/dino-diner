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
            Order order = new Order();
            Brontowurst brontowurst = new Brontowurst();
            Fryceritops fryceritops = new Fryceritops();
            Sodasaurus sodasaurus = new Sodasaurus();
            order.Add(brontowurst);
            order.Add(fryceritops);
            order.Add(sodasaurus);
            Assert.Equal<Double>(7.85, order.SubtotalCost);
        }
    }
}
