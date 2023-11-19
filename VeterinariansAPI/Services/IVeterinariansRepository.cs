using _301290835_Maria_Josue_3013473439_Project.Models;

namespace VeterinariansAPI.Services
{
    public interface IVeterinariansRepository
    {
        Task<IEnumerable<Veterinarian>> GetAllVeterinarians();
    }
}
