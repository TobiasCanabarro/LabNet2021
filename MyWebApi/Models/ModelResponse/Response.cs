using Entities;
using System.Net;

namespace MyWebApi.Models.ModelResponse
{
    public class Response
    {
        public HttpStatusCode StatusCode { get; set; }
        public string TypeEx { get; set; }
        public string StackTrace { get; set; }
        public Products entity { get; set; }

        public Response()
        {
            this.StatusCode = HttpStatusCode.OK;
        }

        public Response(string TypeEx, string StackTrace)
        {
            this.TypeEx = TypeEx;
            this.StackTrace = StackTrace;
        }
    }

}