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
    public class DeleteASubprojectTest : TestBase
    {
        [Test]
        public void DeletarUmSubprojetoSucesso()
        {
            string project_id = "7";

            DeleteASubprojectRequest deleteASubprojectRequest = new DeleteASubprojectRequest(project_id);
            
            IRestResponse<dynamic> response = deleteASubprojectRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
