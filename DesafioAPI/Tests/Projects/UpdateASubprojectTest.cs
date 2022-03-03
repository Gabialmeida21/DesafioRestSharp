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
    [TestFixture]
    public class UpdateASubprojectTest : TestBase
    {
        [Test]
        public void AlterarUmSubrpojeto()
        {
            string name = "Subproject1";

            string project_id = "4";
            string subproject_id = "13";

            UpdateASubprojectRequest updateASubprojectRequest = new UpdateASubprojectRequest(project_id, subproject_id);
            updateASubprojectRequest.SetJsonBody(name);

            IRestResponse<dynamic> response = updateASubprojectRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);

            
        }
    }
}
