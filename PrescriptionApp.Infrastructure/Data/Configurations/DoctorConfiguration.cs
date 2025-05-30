﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrescriptionApp.Core.Entities;

namespace PrescriptionApp.Infrastructure.Data.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(d => d.IdDoctor);
        builder.Property(d => d.IdDoctor).ValueGeneratedOnAdd();
        
        builder.Property(d => d.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(d => d.LastName).IsRequired().HasMaxLength(100);
        builder.Property(d => d.Email).IsRequired().HasMaxLength(100);

        builder.ToTable("Doctor");
    }
}