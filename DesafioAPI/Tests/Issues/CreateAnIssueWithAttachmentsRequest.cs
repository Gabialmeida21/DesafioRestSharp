using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Tests.Issues
{
    public class CreateAnIssueWithAttachmentsRequest : RequestBase
    {
        public CreateAnIssueWithAttachmentsRequest()
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues";
        }

        public void SetJsonBody(string summary, string description, string nameProject)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/CreateAnIssueWithAttachments.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$summary", summary);
            jsonBody = jsonBody.Replace("$description", description);
            jsonBody = jsonBody.Replace("$nameProject", nameProject);
        }
    }
}
