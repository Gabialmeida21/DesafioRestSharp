using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Issues
{
    public class CreateAnIssueMinRequest : RequestBase
    {
        public CreateAnIssueMinRequest()
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/issues/";
        }

        public void SetJsonBody(string summary, string description)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Issues/CreateAnIssueMin.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$summary", summary);
            jsonBody = jsonBody.Replace("$description", description);


        }
    }
}
