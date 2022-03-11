using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class CreateProjectRequest : RequestBase
    {
        public CreateProjectRequest()
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/projects/";
        }

        public void SetJsonBody(string nameProject,string nameStatus, string labelStatus, string description, string filePath, 
            string nameViewState, string labelViewState)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/CreateProject.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$nameProject", nameProject);
            jsonBody = jsonBody.Replace("$nameStatus", nameStatus);
            jsonBody = jsonBody.Replace("$labelStatus", labelStatus);
            jsonBody = jsonBody.Replace("$description", description);
            jsonBody = jsonBody.Replace("$filePath", filePath);
            jsonBody = jsonBody.Replace("$nameViewState", nameViewState);
            jsonBody = jsonBody.Replace("$labelViewState", labelViewState);


        }
    }
}
