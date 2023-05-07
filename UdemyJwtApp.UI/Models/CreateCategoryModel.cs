using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.UI.Models
{
    public class CreateCategoryModel
    {
        [Required(ErrorMessage = "Kategori adı gereklidir.")]
        public string Definition { get; set; } = null!;
    }
}
