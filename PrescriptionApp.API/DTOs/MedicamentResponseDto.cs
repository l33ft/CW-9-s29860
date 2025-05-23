namespace PrescriptionApp.API.DTOs;

public class MedicamentResponseDto
{
    public int IdMedicament { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Dose { get; set; }
    public string Description { get; set; } = string.Empty;
}