using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests
{
    [TestFixture]
    public class FindProjectTests : TestBase
    {
        [Test]
        public void ConsultarProjetoSucesso()
        {
            //arrange

            //actions
            FindProjectRequest findProjectRequest = new FindProjectRequest();
            IRestResponse<dynamic> response = findProjectRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());


        }
    }
}
