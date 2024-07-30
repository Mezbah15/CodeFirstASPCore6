using System.ComponentModel.DataAnnotations;

namespace CodeFirstASPCore6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
