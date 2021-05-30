using Microsoft.Extensions.Logging;
using Moq;
using MyApp.Controllers;
using System.Collections.Generic;
using Xunit;

namespace MyApp.Tests
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Get_ShouldReturn_Array()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            Assert.NotNull(controller.Get());

            
        }
    }
}
