using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace MovieApp.Models
{
    public class MovieContext:DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Detail> Details { get; set; }
        public  MovieContext(){}
        public MovieContext(DbContextOptions<MovieContext>options):base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder builder1){
            if(!builder1.IsConfigured){
                builder1.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=EntDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
    }
}