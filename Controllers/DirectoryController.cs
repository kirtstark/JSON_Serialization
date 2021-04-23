using Directory.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Web.Http;

namespace Directory.Controllers
{
    public class DirectoryController : ApiController
    {
        // GET: api/Directory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Directory/5
        public string Get(int id)
        {
            Rootobject ro = new Rootobject();

            ro.id = 123456;
            ro.firstName = "David";
            ro.lastName = "Smith";
            ro.age = 26;
            ro.address = new Address();
            ro.address.streetAddress = "1 A Street";
            ro.address.city = "A Town";
            ro.address.state = "WA";
            ro.address.postalCode = "98625";
            ro.phoneNumbers = new Phonenumber[2];
            ro.phoneNumbers[0] = new Phonenumber();
            ro.phoneNumbers[1] = new Phonenumber();
            ro.phoneNumbers[0].number = "111.111.1111";
            ro.phoneNumbers[0].type = "Cell";
            ro.phoneNumbers[1].number = "111.111.1112";
            ro.phoneNumbers[1].type = "Work";

            string jsonString = JsonSerializer.Serialize(ro);
            jsonString = JsonSerializer.Serialize(ro);

            return jsonString;

        }

        // POST: api/Directory
        public string Post([FromBody]Rootobject value)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                System.Web.HttpContextBase context = (System.Web.HttpContextBase)Request.Properties["MS_HttpContext"];
                context.Request.InputStream.Seek(0, SeekOrigin.Begin);
                context.Request.InputStream.CopyTo(stream);
            }
            
            return value.firstName + " " + value.lastName + " " + (value.age != null ? value.age.ToString() : "");
        }

        // PUT: api/Directory/5
        public void Put(int id, [FromBody]Rootobject value)
        {
        }

        // DELETE: api/Directory/5
        public void Delete(int id)
        {
        }
    }
}
