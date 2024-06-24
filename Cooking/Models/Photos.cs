using System.ComponentModel.DataAnnotations;

namespace Cooking.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string? PhotoUrl { get; set; }
        public virtual ICollection<Reciept> Reciept { get; set; } = new List<Reciept>();
    }
}