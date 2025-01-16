namespace GestAct.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Municipality { get; set; } = string.Empty;
        public string Manager { get; set; } = string.Empty; 
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Admin? Admin { get; set; }

    }
}
