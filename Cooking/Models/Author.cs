using System.ComponentModel.DataAnnotations;

namespace Cooking.Models
{
    public class Author
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? adress { get; set; }
        public virtual ICollection<AuthorReciept> AuthorReciept { get; set; } = new List<AuthorReciept>();
    }
}