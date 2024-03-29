﻿
using System.Collections.Generic;

namespace LibraryApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        
        public bool IsActive { get; set; }

        public string ImageUrl { get; set; }

        public List<RoleModel> Roles { get; set; }
    }
}
