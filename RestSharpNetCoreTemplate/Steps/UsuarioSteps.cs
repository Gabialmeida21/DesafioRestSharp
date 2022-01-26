using RestSharp;
using RestSharpNetCoreTemplate.Requests.PetStore;
using System;

namespace RestSharpNetCoreTemplate.Tests
{
    public class UsuarioSteps
    {

        public static string RetornarUsuarioPeloID(string idUsuario)
        {

            GetUserRequest getUserRequest = new GetUserRequest(idUsuario);
            IRestResponse<dynamic> response = getUserRequest.ExecuteRequest();

            if (!response.StatusCode.ToString().Equals("OK")){throw new Exception("Erro ao executar a requisição.");}
            return response.Data.ToString();
        }
        
    }
}
