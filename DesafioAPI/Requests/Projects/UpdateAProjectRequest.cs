using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class UpdateAProjectRequest : RequestBase
    {

        public UpdateAProjectRequest(string project_id)
        {
            method = RestSharp.Method.PATCH;
            requestService = "/api/rest/projects/{project_id}";

            parameters.Add("project_id", project_id.ToString());
        }

        public void SetJsonBody(string name)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/UpdateAProject.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$nameproject6", name);


        }
    }
}
