/* JurrasicJavaTest.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Test class for JurrasicJava.
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// Tests the Price of JurrasicJava if Size is unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(.59, java.Price);
        }
        /// <summary>
        /// Tests the Calories of JurrasicJava if Price is unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// Tests whether Ice is false by defualt.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }
        /// <summary>
        /// Tests that Size is Small if unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(Size.Small, java.Size);
        }
        /// <summary>
        /// Tests that RoomForCream is false if unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Small;
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrecPriceForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        /// <summary>
        /// Tests that Price is corect when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }
        /// <summary>
        /// Tests that Calories is corect when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        /// <summary>
        /// Tests that the AddIce method sets Ice to true
        /// </summary>
        [Fact]
        public void AddingIceAddsIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        /// <summary>
        /// Tests that the LeaveRoomForCream method sets RoomForCream true
        /// </summary>
        [Fact]
        public void LeavingSpaceLeavesSpace()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        /// <summary>
        /// Tests that Ingredients is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }
    }
}
