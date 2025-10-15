namespace Auth.Models
{
    public class EditRoleViewModel
    {
        public string UserId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? CurrentRole { get; set; }
        public string SelectedRole { get; set; } = string.Empty;
    }
}
