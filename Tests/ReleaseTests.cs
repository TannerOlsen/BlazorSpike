using BlazorSpike.Client.Pages;
using Bunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using Xunit;
using Moq.Protected;
using System.Threading.Tasks;

namespace Tests
{
    public class ReleaseTests : TestContext
    {
        [Fact]
        public void CallsApiWhenReleaseIsNotProvided()
        {
            // Arrange
            var mock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            mock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{'id':1,'name':'NAME','notes':'NOTES'}")
                })
                .Verifiable();

            // Act
            var cut = RenderComponent<Release>(("Id", 1));

            // Assert
            Mock.Verify();
        }

        [Fact]
        public void DoesNotCallApiWhenReleaseIsProvided()
        {
            // Arrange
            var cut = RenderComponent<Release>(("release", new BlazorSpike.Shared.Release
            {
                Id = 1,
                Name = "Name",
                Notes = "Notes"
            }));

            // Act

            // Assert
        }
    }
}
