using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsPro.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Product Code")]
        public string? ProductCode { get; set; }

        [Required(ErrorMessage = "What is the name anyway?")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter A Price")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "When Is The Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string FormattedReleaseDate
        {
            get { return ReleaseDate.ToString("MM/dd/yyy"); }
        }
        public string Slug => !string.IsNullOrEmpty(Name) ? Name.Replace(' ', '-') : "default-slug";
    }
}
