
namespace Hng.Domain.Entities;
public class Product : EntityBase
{
    public Product()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public string[] Category { get; set; }
    public decimal Price { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
