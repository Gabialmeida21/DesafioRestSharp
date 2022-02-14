using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.User
{
    public class GetMyUserInfoRequest : RequestBase
    {
        public GetMyUserInfoRequest()
        {
            method = Method.GET;
            requestService = "/api/rest/users/me";
        }

    }
}
