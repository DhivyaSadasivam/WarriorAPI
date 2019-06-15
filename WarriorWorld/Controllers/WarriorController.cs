using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WarriorWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarriorController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetBattalion()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> AskWarrior(string Name)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void JoinBattalion([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void ChangeWeapon(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void LeaveBattalion(int id)
        {
        }
    }
}
