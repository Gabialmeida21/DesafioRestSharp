using DesafioAPI.Requests.Issues;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.DBSteps;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.Issues
{
    public class MonitorAnIssueTest : TestBase
    {
        [Test]
        public void MonitorarIssueSucesso()
        {
            //arrange

            List<string> idissue = SolicitacaoDBSteps.SelectMonitorAnIssue();
            string issue_id = idissue[0];

            //actions
            MonitorAnIssueRequest monitorAnIssueRequest = new MonitorAnIssueRequest(issue_id);
            IRestResponse<dynamic> response = monitorAnIssueRequest.ExecuteRequest();

            


            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
            //Console.WriteLine(response.Content);

            JObject obs = JObject.Parse(response.Content);
            Console.WriteLine(obs);

            Console.WriteLine(SolicitacaoDBSteps.SelectMonitorAnIssue()[0]);


        }
    }
}
