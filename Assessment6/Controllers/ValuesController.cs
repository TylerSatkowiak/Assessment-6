using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Assessment6.wwwroot;

namespace Assessment6.Controllers
{
    [Route("Character")]
    [ApiController]
    [Table("Character")]
    public class ValuesController : ControllerBase
    {
        
        public IDbConnection Connection()
        {
            return new SqlConnection("Server=HN78Q13\\SQLEXPRESS;Database=Slack;user id=testuser;password=abc123");
        }

        [HttpGet]
        public List<Character> All()
        {
            List<Character> chars = Connection().GetAll<Character>().ToList();
            return chars;
        }


    }
}
