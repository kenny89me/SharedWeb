using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Picture
    {
        public int ID { get; set; }
        public string Alt { get; set; }
        public string Link { get; set; }
    }
    public class PictureDBContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
    }
}