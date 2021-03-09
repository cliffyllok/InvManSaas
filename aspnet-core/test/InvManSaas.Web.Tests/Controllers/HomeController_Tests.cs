using System.Threading.Tasks;
using InvManSaas.Models.TokenAuth;
using InvManSaas.Web.Controllers;
using Shouldly;
using Xunit;

namespace InvManSaas.Web.Tests.Controllers
{
    public class HomeController_Tests: InvManSaasWebTestBase
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