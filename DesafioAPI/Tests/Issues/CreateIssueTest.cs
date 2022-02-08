using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests
{
    [TestFixture]
    public class CreateProjectTests : TestBase

    {

        [Test]
        public void CriarProjectSucesso()
        {
            //arrange
            string summary = "Teste Issue";
            string testeissue = "Teste Issue API";
            string name = "Teste";

            //actions
            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetJsonBody(summary, testeissue, name);

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}

