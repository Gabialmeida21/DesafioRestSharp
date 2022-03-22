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
    public class CreateAnIssueTimeTrackingTest : TestBase
    {
        [Test]
        public void CriarUmaNotaComTempo()
        {
            string issue_id = "38";

            string text = "test note";
            string name = "public";
            string duration = "00:15";

            CreateAnIssueTimeTrackingRequest createAnIssueTimeTrackingRequest = new CreateAnIssueTimeTrackingRequest(issue_id);
            createAnIssueTimeTrackingRequest.SetJsonBody(text, name, duration);

            IRestResponse<dynamic> response = createAnIssueTimeTrackingRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }
    }
}
