using oliver_homework.Enum;

namespace oliver_homework.Models;

public class PaintProduct
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public PaintType Type { get; set; }
}