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
    public class CreateTagToIssueTest : TestBase
    {
        [Test]
        public void CriarTagParaIssue()
        {
            string issue_id = "38";

            string nameTag = "tag teste 2003";
            string nameTag2 = "tag teste 02";

            CreateTagToIssueRequest createTagToIssueRequest = new CreateTagToIssueRequest(issue_id);
            createTagToIssueRequest.SetJsonBody(nameTag, nameTag2);

            IRestResponse<dynamic> response = createTagToIssueRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }
    }
}
