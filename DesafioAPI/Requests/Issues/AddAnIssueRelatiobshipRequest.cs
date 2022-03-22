using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class AddAnIssueRelatiobshipRequest : RequestBase
    {
        public AddAnIssueRelatiobshipRequest(string issue_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/{issue_id}/relationships";

            parameters.Add("issue_id", issue_id);
        }

        public void SetJsonBody(string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/AddAnIssueRelatiobship.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$name", name);
        }
    }
}
