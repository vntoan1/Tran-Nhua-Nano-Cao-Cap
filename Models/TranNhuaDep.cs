using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TranNhua.Models;

[Table("TranNhuaDep")]
public class TranNhuaDep
{
    [Key]
    public int id { get; set; }

    [Required]
    public string images { get; set; }

    [Required]
    public string name { get; set; }
}