using System.ComponentModel.DataAnnotations;

namespace ColaComNois.Entidades
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}