using System.ComponentModel.DataAnnotations;
public class Supplier
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public String first_name { get; set; }
    [Required]
    [MaxLength(50)]
    public String last_name { get; set; }

    public Product Product { get; set; }
}