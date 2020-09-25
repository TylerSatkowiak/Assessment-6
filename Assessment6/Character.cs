using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using System.Data;
using Dapper;


namespace Assessment6.wwwroot
{
    [Table("Character")]
    public class Character
    {
        [Key]
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
        public string House { get; set; }
        public string Allegiance { get; set; }
        public string Book { get; set; }


        const string server = "Server=9QP7Q13\\SQLEXPRESS;Database=Slack;user id=sa;password=abc123";

        public static Character Read(int _id)
        {
            IDbConnection db = new SqlConnection(server);
            Character Q = db.Get<Character>(_id);
            return Q;
        }

        public static List<Character> Read()
        {
            IDbConnection db = new SqlConnection(server);
            List<Character> Q = db.GetAll<Character>().ToList();
            return Q;
        }

        
    }
}
