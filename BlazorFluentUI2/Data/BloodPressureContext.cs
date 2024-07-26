using BlazorFluentUI2.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorFluentUI2.Data
{
    public class BloodPressureContext(DbContextOptions<BloodPressureContext> options)
        :DbContext(options)
    {
        public DbSet<BloodPressure> BloodPressures => Set <BloodPressure>() ;
    }
}
