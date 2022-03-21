using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NovacytMapIntegration.Controllers;
using NovacytMapIntegration.Models;
using NovacytMapIntegration.Repositories;
using Xunit;

namespace NovacytMapIntegration.Tests
{
    public class ControllerTests
    {
        [Fact]
        public async Task Index_WhenLocationIsNotNull_ReturnsView()
        {
            // Arrange
            var mockRepo = new Mock<ILocationsRepository>();
            mockRepo.Setup(repo => repo.GetAllLocations()).Returns(GetLocations());
            var controller = new HomeController(mockRepo.Object);

            // Act
            var result = await controller.Index();
            

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        private async Task<LocationCollection> GetLocations()
        {
            return new LocationCollection() {
                Locations = new List<Location>()
                {
                   new Location("Location A", 51.329971, -0.762244),
                }
            };
        }
    }
}
