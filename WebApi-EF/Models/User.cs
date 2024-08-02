using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace WebApi_EF.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNum { get; set; }

        //DeptId
        //ManagerId
        public string Password { get; set; }

        // to add a foreign key
        public int RoleId { get; set; }
        public Role? Role { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
     
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsActive { get; set; } = true;

        

        }
    }
