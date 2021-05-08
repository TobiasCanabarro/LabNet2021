using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ErrorView
    {
        public string StackTrace { get; set; }

        public string Message { get; set; }

        public Object Entity {get; set;}

        public ErrorView()
        {

        }

        public ErrorView(string StackTrace, string Message, Object Entity)
        {
            this.StackTrace = StackTrace;
            this.Message = Message;
            this.Entity = Entity;
        }
    }
}