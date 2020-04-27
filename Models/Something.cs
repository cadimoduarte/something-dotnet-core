using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomethingWebApi.Models
{
    [Table("something")]
    public class Something
    {   
        [Key]
        [Column("id")]
        public int? Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }
    }
}