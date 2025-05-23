using System.ComponentModel.DataAnnotations;

namespace PrescriptionApp.Core.Entities;

public class Doctor
{
    public int IdDoctor { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    
    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}