using Net.Application.Shop.Core;
using Net.Framework.Entity.Repository;
using Net.General.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Net.Application.Shop.Controllers
{
    public class UserController : ApiController
    {
        IRepository<User> userRepository = IocManager.Resolve<IRepository<User>>();

        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    var userRepository = IocManager.Resolve<IRepository<User>>();
        //    int c = userRepository.Query.Count();

        //    return new string[] { "value1", "value2", c.ToString() };
        //}

        // GET api/<controller>/5
        public User Get(int id)
        {
            return userRepository.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}