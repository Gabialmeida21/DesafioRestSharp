using DesafioAPI.Helpers;
using DesafioAPI.Requests.Projects;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Projects
{
    [TestFixture]
    public class CreateProjectTest : TestBase
    {
        String project_id;

        [TearDown]
        public void Cleanup()
        {
            DeleteAProjectRequest deleteAProjectRequest = new DeleteAProjectRequest(project_id);
            deleteAProjectRequest.ExecuteRequest();
        }

        public static IEnumerable CreateProject()
        {
            return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "DataDriven\\CreateProject.csv");
        }
        [Test, TestCaseSource("CreateProject")]
        public void CriarProjetoSucesso(ArrayList testData)
        {
            //arrange
            string nameProject = testData[0].ToString();
            string nameStatus = "development";
            string labelStatus = "development";
            string description = "Teste criar novo projeto";
            string filePath = "/tmp/";
            string nameViewState = "public";
            string labelViewState = "public";

            //actions
            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetJsonBody(nameProject ,nameStatus, labelStatus, description, filePath, 
             nameViewState, labelViewState);

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();

            JObject obs = JObject.Parse(response.Content);
            project_id = (obs["project"]["id"]).ToString();
            string nameProjectResponse = (obs["project"]["name"]).ToString();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
            Assert.AreEqual(nameProject, nameProjectResponse);


        }
    }
}
