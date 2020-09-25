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
    public class Character
    {
        [Key]
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public string House { get; set; }
        public string Allegiance { get; set; }
        public string Book { get; set; }
        

    }
}
