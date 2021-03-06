using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class AddSubProjectRequest : RequestBase
    {
        public AddSubProjectRequest(int project_id)
        {
            method = RestSharp.Method.POST;
            requestService = "/api/rest/projects/{project_id}/subprojects";

            parameters.Add("project_id", project_id.ToString());
        }

        public void SetJsonBody(string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/AddSubProject.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("projetotesteaddSUB3", name);


        }
    }
}
