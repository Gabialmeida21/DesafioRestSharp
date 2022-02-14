using DesafioAPI.Requests.User;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Tests.User
{
    [TestFixture]
    public class GetMyUserInfoTest : TestBase
    {
        [Test]
        public void ConsultaInformacaoUsuario()
        {
            //arrange

            //actions
            GetMyUserInfoRequest getMyInfoRequest = new GetMyUserInfoRequest();
            IRestResponse<dynamic> response = getMyInfoRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}
