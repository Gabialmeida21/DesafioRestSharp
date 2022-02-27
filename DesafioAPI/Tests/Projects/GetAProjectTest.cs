using DesafioAPI.Helpers;
using DesafioAPI.Requests.Projects;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;

namespace DesafioAPI.Tests.Projects
{
    public class GetAProjectTest : TestBase
    {
        [Test]
        public void ConsultarUmProjetoSucesso()
        {
            //arrange

            //actions
            int project_id = 2;

            GetAProjectRequest getAProjectRequest = new GetAProjectRequest(project_id.ToString());
            IRestResponse<dynamic> response = getAProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
            response.PrintResponse();

        }
    }
}
