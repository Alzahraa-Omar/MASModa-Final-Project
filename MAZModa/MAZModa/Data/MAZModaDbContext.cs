using System;
using System.Collections.Generic;
using System.Text;
using MAZModa.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MAZModa.Data
{
    public class MAZModaDbContext : IdentityDbContext
    {
        public MAZModaDbContext()
        {
        }
        public virtual DbSet<Age> Age { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<DressCode> DressCode { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Heights> Heights { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<StyleShop> StyleShop { get; set; }
        public virtual DbSet<Tailor> Tailor { get; set; }
        public virtual DbSet<TailorPhoto> TailorPhoto { get; set; }
        public virtual DbSet<Weights> Weights { get; set; }
    }
}
