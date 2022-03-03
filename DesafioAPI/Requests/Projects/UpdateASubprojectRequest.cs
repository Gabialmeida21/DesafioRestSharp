using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class UpdateASubprojectRequest : RequestBase
    {
        public UpdateASubprojectRequest(string project_id, string subproject_id)
        {
            method = RestSharp.Method.PATCH;
            requestService = "/api/rest/projects/{project_id}/subprojects/{subproject_id}";
            parameters.Add("project_id", project_id);
            parameters.Add("subproject_id", subproject_id);

        }

        public void SetJsonBody(string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/Projects/AddSubProject.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("Subproject1", name);


        }
    }
}
