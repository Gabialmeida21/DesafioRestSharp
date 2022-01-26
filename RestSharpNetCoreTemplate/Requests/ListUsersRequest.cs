using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.PetStore
{
    public class ListUsersRequest : RequestBase
    {

        public ListUsersRequest()
        {
            url = "https://reqres.in";
            requestService = "/api/users?page=2";
            method = Method.GET;
        }
    }
}
