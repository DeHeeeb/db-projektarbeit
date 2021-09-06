using System;
using System.Linq;
using db_projektarbeit;
using db_projektarbeit.Control;
using db_projektarbeit.Repository;
using db_projektarbeit_Test.integration.setup;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit_Test.integration
{
    public class CityIntegrationTest : IClassFixture<FormsFactory>
    {
        private readonly CityControl _cityControl;

        public CityIntegrationTest(FormsFactory factory)
        {
            var options = factory.Provider.GetRequiredService<DbContextOptions<ProjectContext>>();
            factory.SetupDb(options);
            _cityControl = factory.Provider.GetRequiredService<CityControl>();
        }

        [Fact]
        public void GivenCities_WhenGetAll_ThenCitiesAreReturned()
        {
            var cities = _cityControl.GetAll();
            Assert.Equal(3, cities.Count);
        }

        [Fact]
        public void GivenCities_WhenSearch_ThenCorrectCitiesAreReturned()
        {
            var cities = _cityControl.Search("Laus");
            Assert.Equal(1, cities.Count);
        }
        
        [Fact]
        public void GivenNewCity_WhenSave_ThenIdOnCityIsSet()
        {
            var city = new City()
            {
                Name = "Bettwiesen",
                Zip = 9553
            };
            var id = _cityControl.Save(city);
            Assert.NotEqual(0, id);
        }

        [Fact]
        public void GivenUpdatedCity_WhenSave_ThenCityIsUpdated()
        {
            var city = new City()
            {
                Name = "Bettwiesen",
                Zip = 9553
            };
            var id = _cityControl.Save(city);
            var update = new City()
            {
                Id = id,
                Name = "Bettwiesen TG",
                Zip = 9553
            };
            _cityControl.Save(update);

            var cities = _cityControl.GetAll();
            Assert.Equal(4, cities.Count);
        }

        [Fact]
        public void GivenCities_WhenDeleteWithId_ThenCityIsDeleted()
        {
            var cityToDelete = _cityControl.GetAll().Single(c => c.Id == 1);
            _cityControl.Delete(cityToDelete);
            var cities = _cityControl.GetAll();
            Assert.Equal(2, cities.Count);
        }

    }
}
