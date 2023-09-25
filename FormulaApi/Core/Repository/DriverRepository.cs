using FormulaApi.Data;
using FormulaApi.Models;
using Microsoft.EntityFrameworkCore;


namespace FormulaApi.Core.Repository
{
    public class DriverRepository : GenericRepository<Driver>, IDriverRepository
    {
        public DriverRepository(ApiDbContext context, ILogger logger) : base(context, logger)
        {
        }
        public override async Task<IEnumerable<Driver>> All()
        {
            try
            {
                return await _context.Drivers.Where(x => x.Id < 100).ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override async Task<Driver?> GetById(int id)
        {
            try
            {
                return await _context.Drivers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Driver?> GetByDriverNb(int driverNb)
        {
            try
            {
                return await _context.Drivers.FirstOrDefaultAsync(x => x.DriverNumber == driverNb);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
