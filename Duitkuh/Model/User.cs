using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duitkuh.Model
{
    [Table("TB_M_User")]
    public class User
    {
        [Key]
        public int Id_User { get; set; }

        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}

