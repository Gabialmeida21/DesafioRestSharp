using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class DeleteAnIssueRequest : RequestBase
    {
        public DeleteAnIssueRequest(string issue_id)
        {
            requestService = "/api/rest/issues/{issue_id}";
            method = RestSharp.Method.DELETE;

            parameters.Add("issue_id", issue_id);
        }
    }
}
