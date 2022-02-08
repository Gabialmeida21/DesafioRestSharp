using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;
using RestSharpNetCoreTemplate.Requests.Issues;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Issues
{
    [TestFixture]
    class FindAllIssuesTest : TestBase
    {
        [Test]
        public void ConsultaTodasIssues()
        {
            //arrange

            //actions
            FindAllIssuesRequest findAllIssuesRequest = new FindAllIssuesRequest();
            IRestResponse<dynamic> response = findAllIssuesRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}

