using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActivite { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Intoduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string city { get; set; }
        public ICollection<Photos> Photos { get; set; }
        public int GetAge()
        {
            return DateOfBirth.CalculateAge();
        }
    }
}