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
    public class AddAnIssueRelatiobshipTest : TestBase
    {
        [Test]
        public void AdicionarUmaIssoRelacionada()
        {
            string issue_id = "45";

            string name = "related-to";

            AddAnIssueRelatiobshipRequest addAnIssueRelatiobshipRequest = new AddAnIssueRelatiobshipRequest(issue_id);
            addAnIssueRelatiobshipRequest.SetJsonBody(name);

            IRestResponse<dynamic> response = addAnIssueRelatiobshipRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }
    }
}
