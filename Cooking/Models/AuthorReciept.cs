using System.ComponentModel.DataAnnotations;

namespace Cooking.Models
{
    public class AuthorReciept
    {
        public int Id { get; set; }
        public int? RecieptId { get; set; }
        public int? AuthorId { get; set; }
        public virtual Author? Author { get; set; }
        public virtual Reciept? Reciept { get; set; }
    }
}