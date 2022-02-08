using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests
{
    public class FindProjectRequest : RequestBase
    {
        public FindProjectRequest()
        {
            method = Method.GET;
            requestService = "/api/rest/projects/";
        }
    }
}
