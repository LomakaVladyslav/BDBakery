using System.ComponentModel.DataAnnotations;

namespace Cooking.Models
{
    public class Type
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "поле не повинне бути порожнім")]
        public string? TypeName { get; set; }
        public virtual ICollection<Reciept> Reciept { get; set; } = new List<Reciept>();

    }
}