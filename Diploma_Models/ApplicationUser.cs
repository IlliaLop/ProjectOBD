using Microsoft.AspNetCore.Identity;

namespace Diploma_Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string Level { get; set; }
        public ApplicationUser()
        {
        }
        public ApplicationUser(string fullName, string specialization, string level)
        {
            FullName = fullName;
            Specialization = specialization;
            Level = level;
        }
    }
}
