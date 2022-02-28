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
    [TestFixture]
    public class DeleteASubprojectTest : TestBase
    {
        private Project projeto;
        private Project subprojeto;

        [SetUp]
        public void Init()
        {
            ProjectHelpers projectHelpers = new ProjectHelpers();
            projeto = projectHelpers.CriarProjetoDefault();
            subprojeto = projectHelpers.CriarProjetoDefault();

            projectHelpers.AssociarSubProjeto(projeto, subprojeto);
        }

        [Test]
        public void DeletarUmSubprojeto()
        {
            
        }
    }
}
