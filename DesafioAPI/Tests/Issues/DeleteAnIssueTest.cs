using DesafioAPI.Helpers;
using DesafioAPI.Requests.Issues;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Issues
{
    [TestFixture]
    public class DeleteAnIssueTest : TestBase
    {
        string issue_id;
        string summary = "Teste Issue";
        string description = "Teste Issue API";
        string name = "Teste";
                        
        [Test]
        public void DeletarUmaIssue()
        {
            CriarIssueParaTeste();

            DeleteAnIssueRequest deleteAnIssueRequest = new DeleteAnIssueRequest(issue_id);
            IRestResponse<dynamic> response = deleteAnIssueRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);
        }

        [Test]
        public void ValidarDeleteIssue()
        {
            GetAnIssueRequest getAnIssueRequest = new GetAnIssueRequest(issue_id);
            IRestResponse<dynamic> responseValidarDelete = getAnIssueRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, responseValidarDelete.StatusCode);

            responseValidarDelete.PrintResponse();
        }

        public void CriarIssueParaTeste()
        {
            CreateIssueRequest createIssueRequest = new CreateIssueRequest();
            createIssueRequest.SetJsonBody(summary, description, name);
            IRestResponse<dynamic> responseCreateIssue = createIssueRequest.ExecuteRequest();

            JObject obs = JObject.Parse(responseCreateIssue.Content);
            issue_id = (obs["issue"]["id"]).ToString();
            Console.WriteLine("Issue Criada " + issue_id);
        }
    }
}
