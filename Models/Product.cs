using System.ComponentModel.DataAnnotations;
public class Product
{

    public int Id { get; set; }
    [MaxLength(50)]
    public String name { get; set; }

    public int SupplierId { get; set; }
    public virtual Supplier Supplier { get; set; }

    [Required]
    public int price { get; set; }
    [MaxLength(50)]
    public String color { get; set; }

    public String image { get; set; }


    [MaxLength(200)]
    public String description { get; set; }

    public int discount_percentage { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }

    public WhislistItem WhislistItem { get; set; }

    public Order order { get; set; }


}