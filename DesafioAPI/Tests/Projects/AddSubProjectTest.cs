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
    public class AddSubProjectTest : TestBase
    {
        [Test]
        public void AdicionarSubProjetoSucesso()
        {
            //arrange
            string name = "projetotesteaddSUB3";

            int project_id = 9;

            //actions
            AddSubProjectRequest addSubProjectRequest = new AddSubProjectRequest(project_id);
            addSubProjectRequest.SetJsonBody(name);


            IRestResponse<dynamic> response = addSubProjectRequest.ExecuteRequest();

            //JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(response.Content);

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());




        }
    }
}
