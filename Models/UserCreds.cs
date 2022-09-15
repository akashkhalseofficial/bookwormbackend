using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace bookwormbackend.Models
{
    public class UserCreds 
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
