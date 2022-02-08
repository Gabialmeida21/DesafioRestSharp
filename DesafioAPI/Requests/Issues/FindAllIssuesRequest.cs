using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Issues
{
    public class FindAllIssuesRequest : RequestBase
    {
        public FindAllIssuesRequest()
        {
            method = Method.GET;
            requestService = "/api/rest/issues?page_size=10&page=1";
        }
    }
}
