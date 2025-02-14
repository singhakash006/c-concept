using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apitest.Repository;
using Apitest.Services;
using Moq;

namespace xunitUserController.Tests.NewFolder
{

    public class UserServiceTests
    {
        [Fact]
        public async Task GetUsersAsync_CallsRepository()
        {
            var mockRepo = new Mock<IUserRepository>();
            mockRepo.Setup(repo => repo.getApi()).ReturnsAsync("Test Data");
            var service = new UserService(mockRepo.Object);
            var result = await service.Getdata();
            Assert.Equal("Test Data", result);
        }
    }
}
