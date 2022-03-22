using DesafioAPI.Helpers;
using DesafioAPI.Requests.Issues;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Issues
{
    public class CreateAnIssueMinTest : TestBase
    {
        [Test]
        public void CriarUmaIssueMinimaSucesso()
        {
            string summary = "This is a test issue";
            string description = "This is a test description";
            

            CreateAnIssueMinRequest createAnIssueMinRequest = new CreateAnIssueMinRequest();
            createAnIssueMinRequest.SetJsonBody(summary, description);

            IRestResponse<dynamic> response = createAnIssueMinRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);

        }
    }
}
