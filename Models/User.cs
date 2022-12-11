using System.ComponentModel.DataAnnotations;

public class User
{
    public int UserId { get; set; }

    [MaxLength(50)]
    [Required]
    public string first_name { get; set; }

    [MaxLength(50)]
    [Required]
    public string last_name { get; set; }

    [MaxLength(50)]
    [Required]
    public string email { get; set; }

    [MaxLength(20)]
    [Required]
    public string phone_number { get; set; }

    public Whislist whislist { get; set; }


}