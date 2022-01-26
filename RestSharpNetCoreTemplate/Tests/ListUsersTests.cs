

using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.PetStore;

namespace RestSharpNetCoreTemplate.Tests
{    
    [TestFixture]
    public class ListUsersTests : TestBase
    {

        ListUsersRequest listUsersPetRequest;
        GetUserRequest getUserRequest;

        [Test]
        public void ShouldSearchUsers()
        {
            string expectedStatusCode = "OK";

            listUsersPetRequest = new ListUsersRequest();

            IRestResponse<dynamic> response = listUsersPetRequest.ExecuteRequest();

            Assert.AreEqual(expectedStatusCode, response.StatusCode.ToString());
        }
        
    }
}
