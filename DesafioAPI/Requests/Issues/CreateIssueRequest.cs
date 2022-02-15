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

        public void SetJsonBody(string summary, string testeissue, string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/CreateIssue.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$summary", summary);
            jsonBody = jsonBody.Replace("$testeissue", testeissue);


        }
    }
}