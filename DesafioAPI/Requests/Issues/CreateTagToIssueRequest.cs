using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class CreateTagToIssueRequest : RequestBase
    {
        public CreateTagToIssueRequest(string issue_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/{issue_id}/tags";

            parameters.Add("issue_id",issue_id);
        }

        public void SetJsonBody(string nameTag, string nameTag2)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/CreateTagToIssue.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$nameTag", nameTag);
            jsonBody = jsonBody.Replace("$nameTag2", nameTag2);
        }
    }
}
