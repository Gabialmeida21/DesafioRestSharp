using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class CreateAnIssueTimeTrackingRequest : RequestBase
    {
        public CreateAnIssueTimeTrackingRequest(string issue_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/{issue_id}/notes";

            parameters.Add("issue_id", issue_id);
        }
        public void SetJsonBody(string text, string name, string duration)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/CreateAnIssueNoteWithTimeTrackin.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$text", text);
            jsonBody = jsonBody.Replace("$name", name);
            jsonBody = jsonBody.Replace("$duration", duration);
        }
    }
}
