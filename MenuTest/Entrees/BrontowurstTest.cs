using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Brontowurst brontowurst = new Brontowurst();
            Assert.Empty(brontowurst.Special);
        }

        [Fact]
        public void SpecialsShouldHoldBun()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBun();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                });
        }

        [Fact]
        public void SpecialsShouldHoldBrat()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBrautwurst();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Brautwurst", item);
                });
        }

        [Fact]
        public void SpecialsShouldHoldPeppers()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldPeppers();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                });
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldOnion();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBrautwurst();
            brontowurst.HoldBun();
            brontowurst.HoldOnion();
            brontowurst.HoldPeppers();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Brautwurst", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
                );
        }
    }

}
