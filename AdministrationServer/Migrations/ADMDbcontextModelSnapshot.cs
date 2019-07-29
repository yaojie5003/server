﻿// <auto-generated />
using AdministrationServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdministrationServer.Migrations
{
    [DbContext(typeof(ADMDbcontext))]
    partial class ADMDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("AdministrationServer.Core.Models.City", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Abbreviation");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<int>("ProvinceId");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("AdministrationServer.Core.Models.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<int>("CityId");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<int>("ProvinceId");

                    b.HasKey("Id");

                    b.ToTable("County");
                });

            modelBuilder.Entity("AdministrationServer.Core.Models.Province", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Abbreviation");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("AdministrationServer.Core.Models.City", b =>
                {
                    b.HasOne("AdministrationServer.Core.Models.County")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdministrationServer.Core.Models.Province", b =>
                {
                    b.HasOne("AdministrationServer.Core.Models.City")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
