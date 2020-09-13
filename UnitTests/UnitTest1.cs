using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TestAPI;
using TestAPI.Controllers;

namespace UnitTests
{

    //Checks if there is atleast a forecast.
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfWeatherForecastsExist()
        {
            //Arrange
            IEnumerable<WeatherForecast> forecasts;

            //Act
            forecasts = WeatherForecastController.Get();

            //Assert
            bool forecastsExist = forecasts != null && forecasts.Count() > 0;
            Assert.IsTrue(forecastsExist, "Weatherforecasts does not exist.");
        }
    }
}
