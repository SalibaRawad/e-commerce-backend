using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public String name { get; set; }


    [MaxLength(200)]
    public String description { get; set; }


    public String image { get; set; }

    public Product Product { get; set; }

}