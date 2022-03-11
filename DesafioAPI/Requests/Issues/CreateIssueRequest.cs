using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests
{
    public class CreateIssueRequest : RequestBase
    {
        public CreateIssueRequest()
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/";
        }

        public void SetJsonBody(string summary, string description, string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/CreateIssue.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$summary", summary);
            jsonBody = jsonBody.Replace("$description", description);
            jsonBody = jsonBody.Replace("$name", name);


        }
    }
}