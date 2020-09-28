using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blog.Models
{
    public partial class IntelloreDBContext : DbContext
    {
        public IntelloreDBContext()
        {
        }

        public IntelloreDBContext(DbContextOptions<IntelloreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloggerMaster> BloggerMaster { get; set; }
        public virtual DbSet<PostMaster> PostMaster { get; set; }
        public virtual DbSet<TagMaster> TagMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5CDL9CE\\SQLEXPRESS;Initial Catalog=IntelloreDB;Integrated Security=True; ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagMaster>(entity =>
            {
                entity.HasOne(d => d.FbloggerMaster)
                    .WithMany(p => p.TagMaster)
                    .HasForeignKey(d => d.FbloggerMasterId)
                    .HasConstraintName("FK__TagMaster__FBlog__3C69FB99");

                entity.HasOne(d => d.FpostMaster)
                    .WithMany(p => p.TagMaster)
                    .HasForeignKey(d => d.FpostMasterId)
                    .HasConstraintName("FK__TagMaster__Fpost__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
