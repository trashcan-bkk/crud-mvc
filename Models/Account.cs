using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_mvc.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime JoinedDate { get; set; }

    }
}