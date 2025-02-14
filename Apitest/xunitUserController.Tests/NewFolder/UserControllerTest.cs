using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apitest.Services;
using Moq;

namespace xunitUserController.Tests.NewFolder
{
    public class UserControllerTest
    {
        [Fact]
        public async Task GetUsers_ReturnsOkResult()
        {
            var mockService = new Mock<IUserService>();
            mockService.Setup(service => service.Getdata()).ReturnsAsync("Test Data");
        }

       
    }
}
