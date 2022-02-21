using DesafioAPI.Requests.Projects;
using DesafioAPI.Requests.User;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Projects
{
    public class DeleteAProjectTest : TestBase
    {
        [Test]
        public void DeletarUmProjeto()
        {
            string project_id = "6";
            DeleteAProjectRequest deleteAProjectRequest = new DeleteAProjectRequest(project_id);
            IRestResponse<dynamic> response = deleteAProjectRequest.ExecuteRequest();
            {
                Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
