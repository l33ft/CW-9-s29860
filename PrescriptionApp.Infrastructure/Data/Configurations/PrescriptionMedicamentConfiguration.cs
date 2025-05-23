﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Infrastructure.Data.Configurations;

public class PrescriptionMedicamentConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
{
    public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
    {
        builder.HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });

        builder.Property(pm => pm.Dose).IsRequired();
        builder.Property(pm => pm.Details).IsRequired().HasMaxLength(100);

        builder.HasOne(pm => pm.Medicament)
            .WithMany(m => m.PrescriptionMedicaments)
            .HasForeignKey(pm => pm.IdMedicament)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(pm => pm.Prescription)
            .WithMany(p => p.PrescriptionMedicaments)
            .HasForeignKey(pm => pm.IdPrescription)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Prescription_Medicament");
    }
}