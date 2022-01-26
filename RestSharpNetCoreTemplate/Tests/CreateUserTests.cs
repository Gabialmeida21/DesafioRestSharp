using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.PetStore;

namespace RestSharpNetCoreTemplate.Tests
{    
    [TestFixture]
    public class CreateUserTests : TestBase
    {

        PostCreateUserRequest postCreateUserRequest;

        [Test]
        public void ShouldCreateUser()
        {
            string name = "UserXPTO";
            string job = "QA Engineer";
            string expectedStatusCode = "Created";

            postCreateUserRequest = new PostCreateUserRequest();
            postCreateUserRequest.SetJsonBody(name, job);

            IRestResponse<dynamic> response = postCreateUserRequest.ExecuteRequest();

            Assert.AreEqual(expectedStatusCode, response.StatusCode.ToString());

            Assert.Multiple(() =>
            {
            Assert.AreEqual(name, response.Data["name"].ToString());
            Assert.AreEqual(job, response.Data["job"].ToString());
            });

        }
        
    }
}
