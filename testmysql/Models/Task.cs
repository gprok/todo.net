using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace testmysql.Models
{
    [Table("tasks")]
    public class Task
    {
        public long id { get; set; }
        public string description { get; set; }

    }
}
