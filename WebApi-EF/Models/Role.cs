﻿namespace WebApi_EF.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int CreatedBy { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
