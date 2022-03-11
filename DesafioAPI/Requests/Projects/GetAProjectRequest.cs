using Google.Protobuf.WellKnownTypes;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.Projects
{
    public class GetAProjectRequest : RequestBase
    {
        public GetAProjectRequest(string project_id)
        {
            method = RestSharp.Method.GET;
            requestService = "/api/rest/projects/{project_id}";

            parameters.Add("project_id", project_id);
        }




    }
}
