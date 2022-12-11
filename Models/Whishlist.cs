using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Whislist
{
    public int WhislistId { get; set; }
    [Required]
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public List<WhislistItem> WhislistItem { get; set; }
}