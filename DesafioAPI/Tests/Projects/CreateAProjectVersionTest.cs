using DesafioAPI.Helpers;
using DesafioAPI.Requests.Projects;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Projects
{
    public class CreateAProjectVersionTest : TestBase
    {
        [Test]
        public void CriarProjetoVersaoSuceso()
        {
            string project_id = "8";

            string name = "v1.0.0";
            string description = "Major new version";
            string timeStamp = "2022-03-02";

            CreateAProjectVersionRequest createAProjectVersionRequest = new CreateAProjectVersionRequest(project_id);
            createAProjectVersionRequest.SetJsonBody(name, description, timeStamp);

            IRestResponse<dynamic> response = createAProjectVersionRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);
        }
    }
}
