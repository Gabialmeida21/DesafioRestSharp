using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.PetStore;

namespace RestSharpNetCoreTemplate.Tests
{    
    [TestFixture]
    public class FileTests : TestBase
    {

        FileRequest fileRequest;

        [Test]
        public void ShouldDownloadTheFile()
        {
            string statusCodeEsperado = "OK";
            fileRequest = new FileRequest();
            //Exemplo de chamada do método para executar query
            //Lembrar de chamar o método correspondente ao tipo de banco utilizado (SQL, PostGreSQL e Oracle)
            DBHelpers.ExecuteQuery("select * from data_table");

            IRestResponse<dynamic> response = fileRequest.ExecuteFileRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }

        
        
    }
}
