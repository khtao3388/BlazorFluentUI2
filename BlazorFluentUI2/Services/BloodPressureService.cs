using Microsoft.EntityFrameworkCore;
using BlazorFluentUI2.Data;
using BlazorFluentUI2.Entities;

namespace BlazorFluentUI2.Services
{
    public class BloodPressureService : IDisposable
    {
        private readonly BloodPressureContext _context;

        public BloodPressureService(BloodPressureContext context)
        {
            _context = context;
        }

        public async Task<List<BloodPressure>> FetchAllBloodPressureAsync()
        {
            return await _context.BloodPressures.ToListAsync();
        }

        // Implement the IDisposable interface to dispose the DbContext properly
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
