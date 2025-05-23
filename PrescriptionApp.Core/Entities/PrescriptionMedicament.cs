using System.ComponentModel.DataAnnotations;

namespace PrescriptionApp.Core.Entities;

public class PrescriptionMedicament
{
    [Required]
    public int IdMedicament { get; set; }
    
    [Required]
    public int IdPrescription { get; set; }
    
    [Required]
    public int Dose { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Details { get; set; } = string.Empty;
    
    public virtual Medicament Medicament { get; set; } = null!;
    public virtual Prescription Prescription { get; set; } = null!;
}