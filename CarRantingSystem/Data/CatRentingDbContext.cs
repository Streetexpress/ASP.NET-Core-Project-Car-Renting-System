namespace CarRantingSystem.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class CatRentingDbContext : IdentityDbContext
    {
        public CatRentingDbContext(DbContextOptions<CatRentingDbContext> options)
            : base(options)
        {
        }
    }
}
