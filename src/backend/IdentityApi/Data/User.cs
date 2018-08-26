using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityApi.Data
{
    [Table("user")]
    public class User
    {
        [Column("id", TypeName = "char(32)"), Required]
        public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");

        [Column("login", TypeName = "varchar(50)"), Required]
        public string Login { get; set; }

        [Column("password", TypeName = "varchar(100)"), Required]
        public string Password { get; set; }

        [Column("salt", TypeName = "varchar(50)"), Required]
        public string Salt { get; set; }

        [Column("utc_created", TypeName = "datetime"), Required]
        public DateTime UtcCreated { get; set; } = DateTime.UtcNow;

        [Column("utc_updated", TypeName = "datetime "), Required]
        public DateTime UtcUpdated { get; set; }
    }
}
