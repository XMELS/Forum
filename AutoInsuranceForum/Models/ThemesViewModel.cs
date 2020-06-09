using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceForum.Models
{
    public class ThemesViewModel
    {

        //Id темы
        [Key]
        [Required]
        public int Themes_Id { get; set; }
        //Создатель темы
        [Required]
        public int Themes_Creator { get; set; }
        [ForeignKey("Themes_Creator")]
        public UsersViewModel User { get; set; }
        //Дата создания темы
        [Required]
        public DateTime Themes_Date { get; set; }
        //Название темы
        [Required]
        [MaxLength(100)]
        public string Themes_Name { get; set; }
        //Текст темы
        [Required]
        public string Themes_Content { get; set; }
        //Вывод комментариев по определенной теме
        public List<CommentsViewModel> Comments { get; set; }

    }
}
