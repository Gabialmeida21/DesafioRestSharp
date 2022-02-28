using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class DeleteASubprojectRequest : RequestBase
    {
        public DeleteASubprojectRequest(string project_id)
        {
            requestService = "/api/rest/projects/{project_id}";
            method = RestSharp.Method.DELETE;

            parameters.Add("project_id", project_id);
        }
    }
}
