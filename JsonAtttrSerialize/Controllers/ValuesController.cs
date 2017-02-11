using JsonAtttrSerialize.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace JsonAtttrSerialize.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var user = new UserModel();
            user.Id = 1;
            user.Name = "DotnetNat";
            user.Age = 39;
            user.Address = new Address();
            user.Address.No = 20;
            return Ok(user);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
