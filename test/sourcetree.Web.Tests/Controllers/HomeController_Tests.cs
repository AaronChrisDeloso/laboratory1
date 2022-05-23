using System.Threading.Tasks;
using sourcetree.Models.TokenAuth;
using sourcetree.Web.Controllers;
using Shouldly;
using Xunit;

namespace sourcetree.Web.Tests.Controllers
{
    public class HomeController_Tests: sourcetreeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}