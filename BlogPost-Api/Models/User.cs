﻿using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BlogPost_Api.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        [Phone]
        public string Phone { get; set; }
        public List<BlogPost> BlogPost { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }

        public List<Reaction> Reactions { get; set; }
    }
}
