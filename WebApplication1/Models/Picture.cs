using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication1.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; } // название картинки
        public byte[] Image { get; set; }
    }
    public class PictureDBContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
    }
}