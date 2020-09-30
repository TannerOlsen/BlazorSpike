using System;
using Xunit;
using Bunit;
using BlazorSpike.Client.Pages;

namespace Tests
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void CountStartsAtZero()
        {
            // Arrange
            var cut = RenderComponent<Counter>();

            // Act
            var paraElmText = cut.Find("p").TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 0");
        }

        [Fact]
        public void IncrementsCountOnClick()
        {
            // Arrange
            var cut = RenderComponent<Counter>();

            // Act
            cut.Find("button").Click();
            var paraElmText = cut.Find("p").TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }
    }
}
