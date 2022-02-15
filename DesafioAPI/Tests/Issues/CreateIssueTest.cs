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
    public class CreateIssueTests : TestBase

    {

        [Test]
        public void CriarIssueSucesso()
        {
            //arrange
            string summary = "Teste Issue";
            string testeissue = "Teste Issue API";
            string name = "Teste";

            //actions
            CreateIssueRequest createIssueRequest = new CreateIssueRequest();
            createIssueRequest.SetJsonBody(summary, testeissue, name);

            IRestResponse<dynamic> response = createIssueRequest.ExecuteRequest();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}

