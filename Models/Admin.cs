namespace GestAct.Models
{
    public class Admin
    {
        public int Id {  get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty ;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public List<User> users { get; set; } = new List<User>();

    }
}
