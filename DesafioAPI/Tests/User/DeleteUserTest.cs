using DesafioAPI.Requests.User;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.User
{
    [TestFixture]
    public class DeleteUserTest : TestBase
    {
        [Test]
        

        public void DeletarUsuario()
        {
            string usuario_id = "7";
            DeleteUserRequest deleteUserRequest = new DeleteUserRequest(usuario_id);
            IRestResponse<dynamic> response = deleteUserRequest.ExecuteRequest();
            {
                Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);
            }
        }
    }
}
