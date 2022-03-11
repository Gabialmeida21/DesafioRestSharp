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
    public class GetAnIssueTest : TestBase
    {
        string issue_id;
        string summary = "Teste Issue";
        string description = "Teste Issue API";
        string name = "Teste";

        [SetUp]
        public void Init()
        {
            CreateIssueRequest createIssueRequest = new CreateIssueRequest();
            createIssueRequest.SetJsonBody(summary, description, name);
            IRestResponse<dynamic> responseCreateIssue = createIssueRequest.ExecuteRequest();

            JObject obs = JObject.Parse(responseCreateIssue.Content);
            issue_id = (obs["issue"]["id"]).ToString();
        }

        [TearDown]
        public void Cleanup()
        {
            DeleteAnIssueRequest deleteAnIssueRequest = new DeleteAnIssueRequest(issue_id);
            deleteAnIssueRequest.ExecuteRequest();
        }

        [Test]
        public void ConsultarUmaIssue()
        {
            
            GetAnIssueRequest getAnIssueRequest = new GetAnIssueRequest(issue_id);
            IRestResponse<dynamic> response = getAnIssueRequest.ExecuteRequest();

            JObject obs = JObject.Parse(response.Content);
            string issueRetornoId = (obs["issues"][0]["id"]).ToString();
            //string issueRetornoDescription = (obs["issues"][0]["description"]).ToString();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(issue_id, issueRetornoId);
        }

    }
}
