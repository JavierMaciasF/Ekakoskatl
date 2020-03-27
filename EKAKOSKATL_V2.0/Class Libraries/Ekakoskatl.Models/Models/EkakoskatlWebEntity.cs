namespace BusinessEntities.BasicEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EkakoskatlWebEntity : DbContext
    {
        public EkakoskatlWebEntity()
            : base("name=EkakoskatlContext")
        {
        }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<PermissionRole> PermissionRoles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<RecentlySeen> RecentlySeens { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VideoGender> VideoGenders { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .HasMany(e => e.VideoGenders)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.MenuItemFormID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.MenuItems)
                .WithRequired(e => e.Permission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.PermissionRoles)
                .WithRequired(e => e.Permission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.PermissionRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPasswordToken)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RecentlySeens)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Roles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Video>()
                .HasMany(e => e.RecentlySeens)
                .WithRequired(e => e.Video)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Video>()
                .HasMany(e => e.VideoGenders)
                .WithRequired(e => e.Video)
                .WillCascadeOnDelete(false);
        }
    }
}
