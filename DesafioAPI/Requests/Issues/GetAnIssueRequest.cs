using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class GetAnIssueRequest : RequestBase
    {
        public GetAnIssueRequest(string issue_id)
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/issues/{issue_id}";

            parameters.Add("issue_id", issue_id);
        }
    }
}
