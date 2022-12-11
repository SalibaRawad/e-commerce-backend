using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class WhislistItem
{
    public int Id { get; set; }
    [Required]
    public int WhislistId { get; set; }
    public virtual Whislist Whislist { get; set; }

    [Required]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    public int number_of_products { get; set; }

    public int price { get; set; }

}