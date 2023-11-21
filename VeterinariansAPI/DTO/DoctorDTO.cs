namespace VeterinariansAPI.DTO
{
    public class DoctorDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Lastname { get; set; }

        public string? Gender { get; set; }

        public int? VeterinarianId { get; set; }

        public float? Price { get; set; }

        public int? SpecialtyId { get; set; }
    }
}
