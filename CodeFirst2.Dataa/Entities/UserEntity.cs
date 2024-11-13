namespace CodeFirst2.Dataa.Entities;

public class UserEntity : BaseEntity
{ 
        public string Username { get; set; }
        public string Email { get; set; }
        public ICollection<PostEntity> Posts { get; set; }
}