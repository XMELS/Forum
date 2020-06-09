using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceForum.Models
{
    public class UsersViewModel
    {
        [Key]//Primary key
        [Required]//Не null
        public int Users_Id { get; set; }
        [Required]
        [MaxLength(100)]//Максимальный размер строки
        public string Users_Login { get; set; }
        [Required]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string Users_Password { get; set; }
        [Required]
        [MaxLength(100)]
        public string Users_Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Users_Img { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email адрес")]
        public string Users_Email { get; set; }
        [Required]
        public string Users_City { get; set; }
        public List<ThemesViewModel> Themes { get; set; }
        public List<CommentsViewModel> Comments { get; set; }
    }
}
