using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class DeleteAnIssueRelationshipRequest : RequestBase
    {
        public DeleteAnIssueRelationshipRequest(string issue_id, string relationship_id)
        {
            requestService = "/api/rest/issues/{issue_id}/relationships/{relationship_id}";
            method = RestSharp.Method.DELETE;

            parameters.Add("issue_id", issue_id);
            parameters.Add("relationship_id", relationship_id);
        }
    }
}
