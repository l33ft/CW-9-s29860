﻿namespace PrescriptionApp.API.DTOs;

public class PrescriptionResponseDto
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public DoctorDto Doctor { get; set; } = null!;
    public List<MedicamentResponseDto> Medicaments { get; set; } = new();
}