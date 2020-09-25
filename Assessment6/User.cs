using Assessment6.wwwroot;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment6
{
    [Table("Results")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }

        const string server = "Server=9QP7Q13\\SQLEXPRESS;Database=Slack;user id=sa;password=abc123";


        public static void Create (string username, int chID, Character person)
        {
            IDbConnection db = new SqlConnection(server);
            User user = new User()
            {
                UserName = username,
                CharacterID = person.CharacterID,
                CharacterName = person.CharacterName,
            };
            db.Insert(user);
        }

        public static User Read(int _id)
        {
            IDbConnection db = new SqlConnection(server);
            User Q = db.Get<User>(_id);
            return Q;
        }

        public static List<User> Read()
        {
            IDbConnection db = new SqlConnection(server);
            List<User> Q = db.GetAll<User>().ToList();
            return Q;
        }
    }
}
