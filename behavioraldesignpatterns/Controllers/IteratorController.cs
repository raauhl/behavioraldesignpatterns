using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using behavioraldesignpatterns.Example1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace behavioraldesignpatterns.Controllers
{
    [Route("api/[controller]")]
    public class IteratorController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            ActualContainer ac = new ActualContainer();
            IIterator it = ac.GetIterator();

            while (it.HasNext())
            {
                Console.WriteLine(it.GetNext());
            }

            return new string[] { "value1", "value2" };
        }
    }
}

