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
    public class CreateProjectTest : TestBase
    {
        [Test]
        public void CriarProjetoSucesso()
        {
            //arrange
            string nameStatus = "development";
            string labelStatus = "development";
            string description = "Teste criar novo projeto";
            string filePath = "/tmp/";
            string nameViewState = "public";
            string labelViewState = "public";

            //actions
            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetJsonBody( nameStatus, labelStatus, description, filePath, 
                nameViewState, labelViewState);

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}
