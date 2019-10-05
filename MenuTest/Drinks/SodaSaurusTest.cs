/* SodaSaurusTest.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Test class for SodaSaurus
    /// </summary>
    public class SodaSaurusTest
    {
        /// <summary>
        /// Tests that Flavor can be set to Cherry
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Cherry;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cherry, soda.Flavor);
        }
        /// <summary>
        /// Tests that Flavor can be set to Chocolate
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Chocolate;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Chocolate, soda.Flavor);
        }
        /// <summary>
        /// Tests that Flavor can be set to Cola
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Cola;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cola, soda.Flavor);
        }
        /// <summary>
        /// Tests that Flavor can be set to Lime
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Lime;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Lime, soda.Flavor);
        }
        /// <summary>
        /// Tests that Flavor can be set to Orange
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Orange;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Orange, soda.Flavor);
        }
        /// <summary>
        /// Tests that Flavor can be set to Rootbeer
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.RootBeer;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.RootBeer, soda.Flavor);
        }
        /// <summary>
        /// Tests the Flavor can be set to Vanilla
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Vanilla;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Vanilla, soda.Flavor);
        }
        /// <summary>
        /// Tests that Price is correct when Size is unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        /// <summary>
        /// Tests the Calories is correct when Size is unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        /// <summary>
        /// Tests that Ice is true when unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.True(soda.Ice);
        }
        /// <summary>
        /// Tests that Size is Small when unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal(Size.Small, soda.Size);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when size is Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        /// <summary>
        /// Tests that Ice is true when uncanged
        /// </summary>
        [Fact]
        public void ShouldHaveDefualtIce()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.True(soda.Ice);
        }
        /// <summary>
        /// Tests that calling the HoldIce method sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIceShouldHaveNoIce()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        /// <summary>
        /// Tests that Ingredients is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredient()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
        }
    }
}
