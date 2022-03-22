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
    public class CreateAnIssueNoteTest : TestBase
    {
        [Test]
        public void CriarUmaNotaIssue()
        {
            string issue_id = "38";

            string test_note = "Teste Issue";

            CreateAnIssueNoteRequest createAnIssueNoteRequest = new CreateAnIssueNoteRequest(issue_id);
            createAnIssueNoteRequest.SetJsonBody(test_note);

            IRestResponse<dynamic> response = createAnIssueNoteRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }
    }
}
