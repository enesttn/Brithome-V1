using Core.Entities;


namespace Entities
{
    public class User:IEntity
    {
        public int UserID { get; set; } 
        public string Username { get; set; } 
        public string Email { get; set; } 
        public string Password { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string PhoneNumber { get; set; } 
        public string ProfilePicture { get; set; } 
    }
}
