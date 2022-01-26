using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpNetCoreTemplate.Requests.PetStore
{
    public class PostCreateUserRequest : RequestBase
    {

        public PostCreateUserRequest()
        {
            url = "https://reqres.in";
            requestService = "/api/users";
            method = Method.POST;
        }


        public void SetJsonBody(string name, string job)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/CreateUser.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$name", name);
            jsonBody = jsonBody.Replace("$job", job);
        }
    }
}
