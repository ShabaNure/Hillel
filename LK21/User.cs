using System.ComponentModel.DataAnnotations;

namespace LK20
{
    public class User : IUser
    {
        [Required(ErrorMessage ="Id is empty")]
        [Range(1,10)]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Name is empty")]
        [StringLength(15)]
        [MinLength(2)]
        public string Name { get; set; }
        [Range(12,100)]
        [Required(ErrorMessage = "age is empty")]
        public int Age { get; set; }
    }
}
