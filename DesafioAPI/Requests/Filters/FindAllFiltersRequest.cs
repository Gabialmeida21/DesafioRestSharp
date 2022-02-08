using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.Filters
{
    class FindAllFiltersRequest : RequestBase
    {
        
        public FindAllFiltersRequest()
        {
            method = Method.GET;
            requestService = "api/rest/filters";
        }
    }
}

