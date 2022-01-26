using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.PetStore
{
    public class GetUserRequest : RequestBase
    {

        public GetUserRequest(string idUsuario)
        {
            url = "https://reqres.in";
            requestService = "/api/users/"+ idUsuario;
            method = Method.GET;
        }
    }
}
