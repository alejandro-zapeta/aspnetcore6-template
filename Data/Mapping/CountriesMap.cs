using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping {

    public partial class CountriesMap : IEntityTypeConfiguration<Master.Data.Entities.Countries> {
        
        public void Configure(
            Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.Countries> builder) {
            
            // table
            builder.ToTable("countries", "dbo");
            // key
            builder.HasKey(t => t.Code);
            // properties
            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("code")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ContinentName)
                .HasColumnName("continent_name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships

        }

        #region Generated Constants
        public struct Table {
            public const string Schema = "dbo";
            public const string Name = "countries";
        }

        public struct Columns {
            public const string Code = "code";
            public const string Name = "name";
            public const string ContinentName = "continent_name";
        }
        #endregion
    }
}
