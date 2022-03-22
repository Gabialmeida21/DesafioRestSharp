using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class CreateAnIssueNoteRequest : RequestBase
    {
        public CreateAnIssueNoteRequest(string issue_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/{issue_id}/notes";

            parameters.Add("issue_id", issue_id);
        }

        public void SetJsonBody(string test_note)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/CreateAnIssueNote.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("test_note", test_note);
        }
    }
}
