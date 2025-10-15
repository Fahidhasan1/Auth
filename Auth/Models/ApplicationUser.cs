using Microsoft.AspNetCore.Identity;

namespace Auth.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}
