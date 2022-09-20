using Microsoft.EntityFrameworkCore;

namespace myApi.Helper;

using myApi.Entities;

public class SeedDefaultUser
{
    private readonly ModelBuilder modelBuilder;

    public SeedDefaultUser(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                deleted = false,
                deleted_on = null,
                id = 1,
                username = "arthur",
                hashed_password = "@Wordpass123",
                email = "sllash.arthur@gmail.com",
            }
            

        );
    }
}