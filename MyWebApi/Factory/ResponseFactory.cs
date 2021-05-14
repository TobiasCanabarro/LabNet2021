using MyWebApi.Models.ModelResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace MyWebApi.Factory
{
    public class ResponseFactory
    {
        public static Response Create(string TypeEx, string StackTrace)
        {
            return new Response(TypeEx, StackTrace);
        }
    }
}