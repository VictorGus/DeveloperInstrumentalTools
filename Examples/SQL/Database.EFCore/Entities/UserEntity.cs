using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.EFCore.Entities
{
    [Table("User")]
    public class UserEntity
    {
        public int Id { get; set; }
        
        private string Email { get; set; }
        
        private string Password { get; set; }

    }
}