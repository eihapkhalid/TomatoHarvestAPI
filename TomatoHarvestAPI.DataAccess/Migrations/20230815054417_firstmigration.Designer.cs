﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TomatoHarvestAPI.DataAccess.Data;

#nullable disable

namespace TomatoHarvestAPI.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230815054417_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TomatoHarvestAPI.Models.TbDh22SensorData", b =>
                {
                    b.Property<int>("Dh22SensorDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dh22SensorDataId"));

                    b.Property<double>("Humidity")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("Dh22SensorDataId");

                    b.ToTable("TbDh22SensorDatas");
                });

            modelBuilder.Entity("TomatoHarvestAPI.Models.TbLdrSensorData", b =>
                {
                    b.Property<int>("LdrSensorDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LdrSensorDataId"));

                    b.Property<int>("LightIntensity")
                        .HasColumnType("int");

                    b.HasKey("LdrSensorDataId");

                    b.ToTable("TbLdrSensorDatas");
                });

            modelBuilder.Entity("TomatoHarvestAPI.Models.TbSoilMoistureSensorData", b =>
                {
                    b.Property<int>("SoilMoistureSensorDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SoilMoistureSensorDataId"));

                    b.Property<int>("SoilMoistureLevel")
                        .HasColumnType("int");

                    b.HasKey("SoilMoistureSensorDataId");

                    b.ToTable("TbSoilMoistureSensorDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
