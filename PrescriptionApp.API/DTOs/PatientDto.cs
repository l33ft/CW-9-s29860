using System.ComponentModel.DataAnnotations;

namespace PrescriptionApp.API.DTOs;


public class PatientDto
{
    public int? IdPatient { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
    
    [Required]
    public DateTime Birthdate { get; set; }
}