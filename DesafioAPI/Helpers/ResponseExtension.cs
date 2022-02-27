using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Text;

namespace DesafioAPI.Helpers
{
    public static class ResponseExtension
    {
        public static void PrintResponse(this IRestResponse response)
        {
            var message = new StringBuilder();

            int status = (int)response.StatusCode;
            string description = response.StatusDescription;
            string content = response.Content;

            message.AppendLine("StatusCode: " + status);

            if (!string.IsNullOrEmpty(description))
                message.AppendLine("Descrição: " + description);

            if (!string.IsNullOrEmpty(content))
            {
                JObject obs = JObject.Parse(content);
                message.AppendLine("Retorno:\n" + obs.ToString());
            }
            
            Console.WriteLine(message.ToString());
        }
    }
}
