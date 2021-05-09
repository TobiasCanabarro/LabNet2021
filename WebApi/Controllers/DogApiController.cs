using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DogApiController : ApiController
    {
        // GET: api/Dog
        public DogView Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1l WOW64; rv:23.0) Gecjo/20100101 Firefox/23.0";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Proxy = null;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = HttpUtility.HtmlDecode(streamReader.ReadToEnd());

            DogView dogView = JsonConvert.DeserializeObject<DogView>(data);

            return dogView;
        }

        // POST: api/Dog
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dog/5
        public void Delete(int id)
        {
        }
    }
}
