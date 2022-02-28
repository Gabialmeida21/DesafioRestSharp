using DesafioAPI.Helpers.Project;
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
        [Test]
        public void AdicionarSubProjeto()
        {
            // Criar Projeto e SubProjeto para utilizar nos testes
            ProjectHelpers projectHelpers = new ProjectHelpers();
            Project projeto = projectHelpers.CriarProjetoDefault();
            Project subprojeto = projectHelpers.CriarProjetoDefault();

            // Associar o SubProjeto ao Projeto
            projectHelpers.AssociarSubProjeto(projeto, subprojeto);

            // Consultar o projeto criado acima pelo seu próprio Id
            Project project = projectHelpers.ObterProjetoPorId(projeto.Id);

            // Verificar se existe algum subProjeto associado ao projeto consultado
            Assert.IsTrue(project.SubProjects.Count > 0);

            // Obter o primeiro subProjeto do Projeto consultado 
            Project subproj = project.SubProjects[0];

            // Validar se o subProjeto criado é o mesmo subprojeto consultado 
            Assert.AreEqual(subprojeto.Id, subproj.Id);

            Console.WriteLine(project.Name);
            Console.WriteLine(subproj.Name);

        }

    }
}
