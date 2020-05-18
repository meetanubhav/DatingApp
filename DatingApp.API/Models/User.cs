namespace DatingApp.API.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}