namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Index(IsUnique=true)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RealName { get; set; }
        public string Address { get; set; }
        [Required]
        public string Password { get; set; }
        
        public bool IsBlocked { get; set; }
    }
}
