﻿using Microsoft.EntityFrameworkCore;
using Portfolyom.DAL.Entities;

namespace Portfolyom.DAL.Context
{
    public class MyPortfolioContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-50S07US;initial Catalog=MyPortfolioDb;integrated Security=true;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
