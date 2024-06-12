namespace UserServiceAPI.Models.Dto
{
    public class UserDto
    {
        public long  Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class UserDetailsDto
    { 
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public IEnumerable<RoleDto> Roles { get; set; }
    }

    public class RoleDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
