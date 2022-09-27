using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duitkuh.Model
{
    [Table("TB_M_UserRole")]
    public class UserRole
    {
        [Key]
        [ForeignKey("User")]
        public int Id_User { get; set; }
        public User User { get; set; }

        [ForeignKey("Role")]
        public int Id_Role { get; set; }
        public Role Role { get; set; }
    }
}

