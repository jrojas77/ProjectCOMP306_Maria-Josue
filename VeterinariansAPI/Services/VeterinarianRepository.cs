using _301290835_Maria_Josue_3013473439_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace VeterinariansAPI.Services
{
    public class VeterinarianRepository : IVeterinariansRepository
    {
        private Comp306ProjectContext _context;

        public VeterinarianRepository( Comp306ProjectContext context )
        {
            _context = context;
        }
        public async Task<IEnumerable<Veterinarian>> GetAllVeterinarians()
        {
            var result = _context.Veterinarians.OrderBy( v => v.Id );
            return await result.ToListAsync();
        }
    }
}
