using System.ComponentModel.DataAnnotations;

namespace Cooking.Models
{
    public class Reciept
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "поле не повинне бути порожнім")]
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        [Required(ErrorMessage = "поле не повинне бути порожнім")]
        public virtual Category? Category { get; set; }
        public int? TypeId { get; set; }
        [Required(ErrorMessage = "поле не повинне бути порожнім")]
        public virtual Type? Type { get; set; }
        public int? Price { get; set; }
        public string? Ingridients { get; set; }
        public string? Instruction { get; set; }
        public int? CountryId { get; set; }
        public int? PhotoUrlId { get; set; }
        public virtual Country? Country { get; set; }
        public virtual Photos? Photos { get; set; }

        public virtual ICollection<AuthorReciept> AuthorReciept { get; set; } = new List<AuthorReciept>();
    }
}