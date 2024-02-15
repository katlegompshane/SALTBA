using Moq;
using Xunit;


namespace UnitTestWeatherForcast.Service
{
    public class CountryServiceTest
    {

        private Mock<ICountryService> _mockHttpClientFactory;
        [Fact]
        public void GetListOfCountriesTest_OnSuccess()
        {
            // Arrange
            var mockService = new Mock<ICountryService>();
        }
    }
}
