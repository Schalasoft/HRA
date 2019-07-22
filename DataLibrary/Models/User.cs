namespace DataLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // CDG Save password hash and salt instead of plaintext password
    }
}