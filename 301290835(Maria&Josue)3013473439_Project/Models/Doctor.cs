using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _301290835_Maria_Josue_3013473439_Project.Models;

public partial class Doctor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? Gender { get; set; }

    public int? VeterinarianId { get; set; }

    public float? Price { get; set; }

    public int? SpecialtyId { get; set; }
}
