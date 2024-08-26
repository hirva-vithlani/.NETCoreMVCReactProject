using EmployeeManagementSystem;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Routing;

namespace EmployeeManagementXUnitTest
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public UnitTest1()
        {
            var factory = new WebApplicationFactory<Program>();
            _factory = factory;
        }

        [Fact]
        public async Task EmployeeData()
        {
            //Arrange
            HttpClient client = _factory.CreateClient();

            //Act https://localhost:60443/fetchemployee
            var response = await client.GetAsync("/");
            int statusCode = (int)response.StatusCode;

            //Assert
            Assert.Equal(200, statusCode);
        }
    }
}