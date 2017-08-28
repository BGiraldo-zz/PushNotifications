using Yuxi.Notifications.Domain.AggregatesModel.TemplateAggregate;
using Yuxi.Notifications.Domain.AggregatesModel.UserAggregate;
using Yuxi.Notifications.Domain.AggregatesModel.ApplicationAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Yuxi.Notifications.Infrastructure
{
    public class NotificationContext : DbContext
    {

        const string DEFAULT_SCHEMA = "yuxi";

        public DbSet<Template> Templates { get; set; }

        public DbSet<UserRegistry> RegisteredUsers{ get; set; }

        public DbSet<Application> Applications { get; set; }


        public NotificationContext(DbContextOptions<NotificationContext> options) : base(options)
        {
            base.Database.EnsureCreated();
            base.SaveChanges();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Template>(ConfigureTemplate);

        }

        private void ConfigureTemplate(EntityTypeBuilder<Template> requestConfiguration)
        {
            requestConfiguration.ToTable("Templates", DEFAULT_SCHEMA);
            
            requestConfiguration.HasKey(template => template.Id);

            requestConfiguration.Property(template => template.Body)
               .IsRequired()
               .HasColumnName("Body");
        }

        private void ConfigureUserRegistry(EntityTypeBuilder<UserRegistry> requestConfiguration)
        {
            requestConfiguration.ToTable("Users", DEFAULT_SCHEMA);

          
            






        }








    }
}
