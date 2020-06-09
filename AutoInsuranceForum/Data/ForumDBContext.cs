using AutoInsuranceForum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceForum.Data
{
    public class ForumDBContext : DbContext
    {
        public DbSet<ThemesViewModel> Themes { get; set; }
        public DbSet<UsersViewModel> Users { get; set; }
        public DbSet<CommentsViewModel> Comments { get; set; }

        public ForumDBContext(DbContextOptions<ForumDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersViewModel>().ToTable("Users");
            modelBuilder.Entity<ThemesViewModel>().HasOne(p => p.User).WithMany(z => z.Themes).HasForeignKey(p => p.Themes_Creator);
            modelBuilder.Entity<CommentsViewModel>().HasOne(p=>p.Theme_Id).WithMany(z=>z.Comments).HasForeignKey(p=>p.Comment_Theme_Id);
            modelBuilder.Entity<CommentsViewModel>().HasOne(p => p.User_Comment).WithMany(z => z.Comments).HasForeignKey(p => p.Comment_Creator);
        }
    }
}
