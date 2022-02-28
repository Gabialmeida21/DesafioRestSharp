using DesafioAPI.Helpers;
using DesafioAPI.Helpers.Project;
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
        //Criar um projeto e validar o status code
        [Test]
        public void CriarProjetoRequest()
        {
            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetDefaultJsonBody();

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();
            response.PrintResponse();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

        }

        //Criar um projeto e validar os dados 
        [Test]
        public void ValidarDadosProjetoSucesso()
        {
            ProjectHelpers projectHelpers = new ProjectHelpers();
            Project project = projectHelpers.CriarProjetoDefault();

            Console.WriteLine(project.Id);
            Console.WriteLine(project.Name);
            Console.WriteLine(project.Description);
            Console.WriteLine(project.Enabled);


            Assert.IsTrue(project.Id > 0);
            Assert.IsTrue(project.Name.Contains("Project_"));
            Assert.AreEqual("Teste criar novo projeto", project.Description);
            Assert.IsTrue(project.Enabled);


        }
    }
}
