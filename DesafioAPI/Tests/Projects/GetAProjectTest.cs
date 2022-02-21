using DesafioAPI.Requests.Projects;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

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
            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);


        }
    }
}
