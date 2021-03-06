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
    [TestFixture]
    public class UpdateAProjectTest : TestBase
    {
        [Test]
        public void AlterarProjetoSucesso()
        {
            //arrange
            string name = "$nameProject6";

            //actions
            int project_id = 6;

            UpdateAProjectRequest updateAProjectRequest = new UpdateAProjectRequest(project_id);
            updateAProjectRequest.SetJsonBody(name);

            IRestResponse<dynamic> response = updateAProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);


        }
    }
}

