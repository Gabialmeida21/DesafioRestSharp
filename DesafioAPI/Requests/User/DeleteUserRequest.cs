using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Requests.User
{
    public class DeleteUserRequest : RequestBase
    {
        public DeleteUserRequest(string usuario_id)
        {
            requestService = "/api/rest/users/{user_id}";
            method = Method.DELETE;

            parameters.Add("user_id", usuario_id);
        }
    }
}
