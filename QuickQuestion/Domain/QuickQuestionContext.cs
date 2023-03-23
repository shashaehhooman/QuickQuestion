using Microsoft.EntityFrameworkCore;
using QuickQuestion.Domain.Model;

namespace QuickQuestion.Domain
{
    public class QuickQuestionContext : DbContext
    {
        public QuickQuestionContext(DbContextOptions<QuickQuestionContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Role>().HasIndex(u => u.title).IsUnique();
            builder.Entity<User>().HasIndex(u => u.email).IsUnique();
            builder.Entity<Tag>().HasIndex(u => u.title).IsUnique();

            builder.Entity<Answer>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<Comment>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<CommenTags>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<Blog>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<BlogTags>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<Category>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<Tag>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<AssetBlog>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<AssetCategory>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<AssetComment>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<AssetUser>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<User>().Property(b => b.created).HasDefaultValueSql("getdate()");
            builder.Entity<UserRole>().Property(b => b.created).HasDefaultValueSql("getdate()");

            builder
                .Entity<Category>()
                .HasMany(e => e.assets)
                .WithOne(e => e.category)
                .OnDelete(DeleteBehavior.ClientCascade);


            builder.Entity<Blog>()
                .HasMany(ta => ta.assets)
                .WithOne(u => u.blog)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Blog>()
                .HasMany(ta => ta.blogTags)
                .WithOne(u => u.blog)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.Entity<Blog>()
                .HasMany(ta => ta.comments)
                .WithOne(u => u.blog)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>()
                .HasMany(ta => ta.comments)
                .WithOne(u => u.user)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<User>()
                .HasMany(ta => ta.answers)
                .WithOne(u => u.user)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Comment>()
                  .HasMany(ta => ta.assetComments)
                  .WithOne(u => u.comment)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Comment>()
                  .HasMany(ta => ta.commenTsags)
                  .WithOne(u => u.comment)
                  .OnDelete(DeleteBehavior.Restrict);
        }


        // Content Model 
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<BlogTags> BlogTags { get; set; }
        public DbSet<Tag> Tag { get; set; }


        // Commetn Model 
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<CommenTags> CommenTags { get; set; }


        // Asset Model 
        public DbSet<AssetBlog> AssetBlog { get; set; }
        public DbSet<AssetCategory> AssetCategory { get; set; }
        public DbSet<AssetComment> AssetComment { get; set; }
        public DbSet<AssetUser> AssetUser { get; set; }


        // User Model 
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(false);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
