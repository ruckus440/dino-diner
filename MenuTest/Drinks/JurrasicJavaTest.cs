/* JurrasicJavaTest.cs
 * Author: Mike Ruckert
 */
using DinoDiner.Menu;
//using DinoDiner.Menu.Drinks;
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
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }
        /// <summary>
        /// Tests the Calories of JurrasicJava if Price is unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// Tests whether Ice is false by defualt.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }
        /// <summary>
        /// Tests that Size is Small if unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(Size.Small, java.Size);
        }
        /// <summary>
        /// Tests that RoomForCream is false if unchanged.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
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
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// Tests that Price is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrecPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }
        /// <summary>
        /// Tests that Calories is correct when Size is Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        /// <summary>
        /// Tests that Price is corect when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }
        /// <summary>
        /// Tests that Calories is corect when Size is Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        /// <summary>
        /// Tests that the AddIce method sets Ice to true
        /// </summary>
        [Fact]
        public void AddingIceAddsIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        /// <summary>
        /// Tests that the LeaveRoomForCream method sets RoomForCream true
        /// </summary>
        [Fact]
        public void LeavingSpaceLeavesSpace()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        /// <summary>
        /// Tests that Ingredients is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }
    }
}
