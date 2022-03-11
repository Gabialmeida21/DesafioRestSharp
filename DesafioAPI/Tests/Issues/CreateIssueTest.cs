using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests
{
    [TestFixture]
    public class CreateIssueTests : TestBase

    {

        [Test]
        public void CriarIssueSucesso()
        {
            List<string> idissue = SolicitacaoDBSteps.InserirUmaIssue();

            
            string issue_id = idissue[0];

            //arrange
            string summary = "Teste Issue";
            string description = "Teste Issue API";
            string name = "Teste";

            //actions
            CreateIssueRequest createIssueRequest = new CreateIssueRequest();
            createIssueRequest.SetJsonBody(summary, description, name);

            IRestResponse<dynamic> response = createIssueRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}

