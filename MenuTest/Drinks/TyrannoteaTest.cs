/* TyrannoteaTest.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Test class to test Tyrannotea
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// Tests that Price is correct when Size is unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        /// <summary>
        /// Tests that Ice is true if HoldIce is not called.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        /// <summary>
        /// Tests that Size is small when unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);
        }
        /// <summary>
        /// Tests that Lemon is false when unchanged
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        /// <summary>
        /// Tests that Sweet is false when Sweeten isn't called
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        /// <summary>
        /// Tests that Price is correct when in Size is Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        /// <summary>
        /// Tests that Calories is correcct when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests that the HoldIce method sets Ice to false
        /// </summary>
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        /// <summary>
        /// Tests that the AddLemon method sets Lemon to true
        /// </summary>
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }
        /// <summary>
        /// Tests that Calories have doubled and correct for Size Small
        /// </summary>
        [Fact]
        public void CaloriesRightIfSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }
        /// <summary>
        /// Tests that Calories have double and correct when Size is Medium
        /// </summary>
        [Fact]
        public void CaloriesRightIfSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests that Calories have doubled and correct when Size is Large
        /// </summary>
        [Fact]
        public void CaloriesRightIfSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }
        /// <summary>
        /// Tests that Calories is correct when setting Lemon true then back to false
        /// </summary>
        [Fact]
        public void CaloriesRightIfSweetThenUnsweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests that Ingredients is correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            tea.AddLemon();
            Assert.Contains<string>("Lemon", tea.Ingredients);
            tea.Sweeten();
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }
    }
}
