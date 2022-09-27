using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duitkuh.Model
{
    [Table("TB_M_Role")]
    public class Role
    {
        [Key]
        public int Id_Role { get; set; }
        public string Name_Role { get; set; }
    }
}

