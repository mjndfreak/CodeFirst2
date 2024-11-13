namespace CodeFirst2.Dataa.Entities;

public class PostEntity : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public UserEntity UserEntity { get; set; }
}