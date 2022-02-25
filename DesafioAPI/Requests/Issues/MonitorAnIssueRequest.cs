using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class MonitorAnIssueRequest : RequestBase
    {
        public MonitorAnIssueRequest(string issue_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/{issue_id}/monitors";

            parameters.Add("issue_id", issue_id);
        }


    }
}
