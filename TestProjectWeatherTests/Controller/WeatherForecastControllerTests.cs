using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using SALTBA.Controllers;
using SALTBA.Interfaces;
using SALTBA.Models.CountryWeather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWeatherTests.Controller
{
    public class WeatherForecastControllerTests
    {
        private readonly IDataDispay<WeatherPerCountry> _iDataDispay;

        public WeatherForecastControllerTests()
        {
            _iDataDispay = A.Fake <IDataDispay<WeatherPerCountry>>();
        }

        [Fact]
        public async void WeatherForecast_GetPokemons_ReturnOK()
        {
            //CODESC: Arrange
            var controller = new WeatherForecastController(_iDataDispay);

            //CODESC: Act
            var result = await controller.GetCountries();

            //CODESC: Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType(typeof(OkObjectResult));

        }
    }
}
