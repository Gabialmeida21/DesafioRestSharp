using DesafioAPI.Helpers;
using DesafioAPI.Tests.Issues;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class CreateIssueWithAttachmentsTest : TestBase
    {
        [Test]
        public void CriarUmaIssueComAnexo()
        {
            string summary = "Sample REST issue with attachment";
            string description = "Description for sample REST issue";
            string nameProject = "testeCarnaval4";

            CreateAnIssueWithAttachmentsRequest createAnIssueWithAttachmentsRequest = new CreateAnIssueWithAttachmentsRequest();
            createAnIssueWithAttachmentsRequest.SetJsonBody(summary, description, nameProject);

            IRestResponse<dynamic> response = createAnIssueWithAttachmentsRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }
    }
}
