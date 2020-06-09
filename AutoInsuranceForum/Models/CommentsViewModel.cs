using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceForum.Models
{
    public class CommentsViewModel
    {
        [Key]
        [Required]
        public int Comment_Id { get; set; }
        [Required]
        public int Comment_Theme_Id { get; set; }
        [ForeignKey("Comment_Theme_Id")]
        public ThemesViewModel Theme_Id { get; set; }
        [Required]
        public int Comment_Creator { get; set; }
        [ForeignKey("Comment_Creator")]
        public UsersViewModel User_Comment { get; set; }
        [Required]
        public DateTime Comment_Date { get; set; }
        [Required]
        public string Comment_Content { get;set;}
        [Required]
        public string Comment_Files { get; set; }
    }
}
