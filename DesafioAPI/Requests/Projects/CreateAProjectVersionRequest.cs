using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class CreateAProjectVersionRequest : RequestBase
    {
        public CreateAProjectVersionRequest(string project_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/projects/{project_id}/versions/";
            parameters.Add("project_id", project_id);
        }

        public void SetJsonBody(string name, string description, string timeStamp)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/CreateAProjectVersion.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("nameProjectVersion", name);
            jsonBody = jsonBody.Replace("description", description);
            jsonBody = jsonBody.Replace("timesTamp", timeStamp);
        }
    }
}
