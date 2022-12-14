using System.ComponentModel.DataAnnotations;

public class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }

    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}