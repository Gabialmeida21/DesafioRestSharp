using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate.Tests.Filters
{
    [TestFixture]
    class FindAllFiltersTest : TestBase
    {
        [Test]
        public void ConsultaTodosFiltros()
        {
            //arrange

            //actions
            FindAllFiltersRequest findAllFiltersRequest = new FindAllFiltersRequest();
            IRestResponse<dynamic> response = findAllFiltersRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.AreEqual("1", response.Data["id"].ToString());
        }
    }
}
