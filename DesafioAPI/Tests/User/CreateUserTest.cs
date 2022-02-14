using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RestSharpNetCoreTemplate
{
    [TestFixture]
    public class CreateUserTest : TestBase 
    {
        public static IEnumerable CreateUser()
        {
            return GeneralHelpers.ReturnCSVData(GeneralHelpers.ReturnProjectPath() + "DataDriven\\UsernameEmail.csv");
        }
        [Test, TestCaseSource("CreateUser")]
        public void CreateUserValido(ArrayList testData)
        {
            string username = "Jair_Melo11";
            string password = "p@ssw0rd";
            string real_name = "jair test11";
            string email = testData[0].ToString();
            string namelevel = "updater";

            CreateUserRequest createUserRequest = new CreateUserRequest();
            createUserRequest.SetJasoBody(username, password, real_name, email, namelevel);

            IRestResponse<dynamic> response = createUserRequest.ExecuteRequest();

            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }
    }
}
