using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace testmysql.Models
{
    [Table("accounts")]
    public class Account
    {
        public long id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
