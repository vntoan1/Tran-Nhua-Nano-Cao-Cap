using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TranNhua.Models;
[Table("TranTha")]
public class TranTha
{
    [Key]
    public int id { get; set; }

    [Required]
    public string images { get; set; }

    [Required]
    public string name { get; set; }
}