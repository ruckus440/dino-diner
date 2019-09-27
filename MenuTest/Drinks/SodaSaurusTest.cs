using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {

    //    The ability to set each possible flavor
    //    The correct default price, calories, ice, and size
    //The correct price and calories after changing to small, medium, and large sizes.
    //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Cola;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            SodaSaurus soda = new SodaSaurus();
        }

        [Fact]
        public void ShouldHaveDefualtIce()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.True(soda.Ice);
        }
    }
}
