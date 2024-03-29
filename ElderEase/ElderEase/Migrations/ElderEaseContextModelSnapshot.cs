﻿// <auto-generated />
using ElderEase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElderEase.Migrations
{
    [DbContext(typeof(ElderEaseContext))]
    partial class ElderEaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElderEase.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ElderEase.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            city = "Cityville",
                            country = "Countryland",
                            email = "john.doe@example.com",
                            firstName = "John",
                            lastName = "Doe",
                            password = "hashedpassword",
                            phone = "123-456-7890",
                            state = "Stateville",
                            zipCode = "12345"
                        },
                        new
                        {
                            Id = 2,
                            city = "Rapid City",
                            country = "Countryland",
                            email = "khushi.patil@example.com",
                            firstName = "Khushi",
                            lastName = "Patil",
                            password = "hashedpassword",
                            phone = "605-456-7890",
                            state = "SD",
                            zipCode = "45123"
                        });
                });

            modelBuilder.Entity("ElderEase.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("serviceName")
                        .HasColumnType("int");

                    b.Property<int>("serviceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Service");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProviderId = 1,
                            isAvailable = false,
                            serviceName = 0,
                            serviceType = 0
                        },
                        new
                        {
                            Id = 2,
                            ProviderId = 1,
                            isAvailable = true,
                            serviceName = 1,
                            serviceType = 1
                        },
                        new
                        {
                            Id = 3,
                            ProviderId = 2,
                            isAvailable = true,
                            serviceName = 2,
                            serviceType = 0
                        },
                        new
                        {
                            Id = 4,
                            ProviderId = 2,
                            isAvailable = true,
                            serviceName = 4,
                            serviceType = 1
                        });
                });

            modelBuilder.Entity("ElderEase.Models.Service", b =>
                {
                    b.HasOne("ElderEase.Models.Provider", null)
                        .WithMany("services")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElderEase.Models.Provider", b =>
                {
                    b.Navigation("services");
                });
#pragma warning restore 612, 618
        }
    }
}
