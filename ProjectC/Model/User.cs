using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string User_Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.User_Type).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).ValueGeneratedOnAdd(); 
                entity.Property(e => e.Address).ValueGeneratedOnAdd();
                entity.Property(e => e.PhoneNumber).ValueGeneratedOnAdd();
                entity.Property(e => e.Username).ValueGeneratedOnAdd();
                entity.Property(e => e.Password).ValueGeneratedOnAdd();
            });
        }
    }
}
