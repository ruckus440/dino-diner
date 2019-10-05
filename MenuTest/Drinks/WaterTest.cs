/* WaterTest.cs
 * Author: Mike Ruckert
 */
//using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Test class for Water.
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Tests the Price of Water if Size is unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Test the Calories of Water if Size is unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }
        /// <summary>
        /// Tests that Ice is true if unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        /// <summary>
        /// Tests that Size is Small if unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }
        /// <summary>
        /// Tests that Lemon is false if unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }
        /// <summary>
        /// Tests that Price is Correct if Size is changed to Medium then back to Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal(.10, water.Price);               
        }
        /// <summary>
        /// Tests that Calories are correct if Size is changed to Medium then back to Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);            
        }
        /// <summary>
        /// Tests that Price is correct for Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Tests that Calories is correct for Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }
        /// <summary>
        /// Tests that Price is correct for Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Tests that Calories is correct for Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0, water.Calories);
        }
        /// <summary>
        /// Tests that the HoldIce method sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        /// <summary>
        /// Tests that the AddLemon method sets Lemon to true
        /// </summary>
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        /// <summary>
        /// Tests that the Ingredients are correct`
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            if (water.Lemon) Assert.Contains<string>("Lemon", water.Ingredients);
        }
    }
}
