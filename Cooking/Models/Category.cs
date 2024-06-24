using System.ComponentModel.DataAnnotations;

namespace Cooking.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public virtual ICollection<Reciept> Reciept { get; set; } = new List<Reciept>();

    }
}