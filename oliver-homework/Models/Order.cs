using oliver_homework.Enum;

namespace oliver_homework.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public int UserId { get; set; }
    public User User { get; set; } = new User();
    public List<PaintProduct> PaintProducts { get; set; }= new List<PaintProduct>();
    public OrderStatus Status { get; set; } 

}