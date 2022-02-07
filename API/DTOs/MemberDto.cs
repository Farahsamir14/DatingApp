using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActivite { get; set; }
        public string Gender { get; set; }
        public string Intoduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string city { get; set; }
        public ICollection<PhotosDto> Photos { get; set; }
    }
}