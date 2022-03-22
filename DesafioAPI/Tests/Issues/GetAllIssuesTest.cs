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
    public class GetAllIssuesTest : TestBase
    {
        [Test]
        public void ConsultarTodasAsIssues()
        {
            string page_size = "10";
            string page = "1";

            GetAllIssuesRequest getAllIssuesRequest = new GetAllIssuesRequest(page_size, page);
            IRestResponse<dynamic> response = getAllIssuesRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
            response.PrintResponse();
        }
    }
}
