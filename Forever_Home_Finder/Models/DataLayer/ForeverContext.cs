using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;


namespace Forever_Home_Finder.Models
{
    public class ForeverContext : IdentityDbContext<User>
    {
        public ForeverContext(DbContextOptions<ForeverContext> options)
            : base(options)
        { }

        public DbSet<User> users { get; set; }

        public DbSet<PetType> petTypes { get; set; }

        public DbSet<Pet> pets { get; set; }
        
        public DbSet<AddInfo> addInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // needs contents
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pet>().HasOne(p => p.PetType)
                .WithMany(pt => pt.Pets)
                .OnDelete(DeleteBehavior.Restrict);

            // seed initial data
            modelBuilder.ApplyConfiguration(new SeedAddInfo());
            modelBuilder.ApplyConfiguration(new SeedPet());
            modelBuilder.ApplyConfiguration(new SeedPetType());
            modelBuilder.ApplyConfiguration(new SeedUser());
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "openSesame";
            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

    }
}
