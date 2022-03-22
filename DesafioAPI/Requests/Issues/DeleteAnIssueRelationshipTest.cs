using DesafioAPI.Helpers;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class DeleteAnIssueRelationshipTest : TestBase
    {
        [Test]
        public void DeletarUmaIssueRelacionada()
        {
            string issue_id = "45";
            string relationship_id = "1";

            DeleteAnIssueRelationshipRequest deleteAnIssueRelationshipRequest = new DeleteAnIssueRelationshipRequest(issue_id, relationship_id);
            
            IRestResponse<dynamic> response = deleteAnIssueRelationshipRequest.ExecuteRequest();

            response.PrintResponse();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

        } 
    }
}
