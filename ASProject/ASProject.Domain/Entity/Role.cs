using ASProject.Domain.Interfaces;

namespace ASProject.Domain.Entity;

public class Role : IEntityId<long>
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public List<User> Users { get; set; }
}