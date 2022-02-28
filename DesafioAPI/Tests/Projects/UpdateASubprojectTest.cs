using DesafioAPI.Helpers;
using DesafioAPI.Requests.Projects;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Projects
{
    public class UpdateASubprojectTest : TestBase
    {
        [Test]
        public void AlterarSubProjeto()
        {
            //arrange

            string name = "$nameProjectSub";

            //actions
            int project_id = 4;

            int subproject_id = 7;

            UpdateASubprojectRequest updateASubprojectRequest = new UpdateASubprojectRequest(project_id, subproject_id);
            updateASubprojectRequest.SetJsonBody(name);

            IRestResponse<dynamic> response = updateASubprojectRequest.ExecuteRequest();
            
            response.PrintResponse();
            
            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
        }
    }
}
