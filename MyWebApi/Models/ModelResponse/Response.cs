using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MyWebApi.Models.ModelResponse
{
    public class Response
    {
        public string TypeEx { get; set; }
        public string StackTrace { get; set; }
        public Products entity { get; set; }

        public Response()
        {

        }

        public Response(string TypeEx, string StackTrace)
        {
            this.TypeEx = TypeEx;
            this.StackTrace = StackTrace;
        }
    }

}