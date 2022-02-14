using RazorEngine;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Encoding = System.Text.Encoding;

namespace RestSharpNetCoreTemplate.Requests
{
    public class CreateUserRequest : RequestBase
    {
        public CreateUserRequest()
        {
            method = Method.POST;
            requestService = "/api/rest/users/";
        }
        public void SetJasoBody(string username, string password, string real_name, string email, string namelevel)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/CreateUser.json", Encoding.UTF8);

            jsonBody = jsonBody.Replace("$username", username);
            jsonBody = jsonBody.Replace("$password", password);
            jsonBody = jsonBody.Replace("$real_name", real_name);
            jsonBody = jsonBody.Replace("$email", email);
            jsonBody = jsonBody.Replace("$namelevel", namelevel);
        }
    }
}