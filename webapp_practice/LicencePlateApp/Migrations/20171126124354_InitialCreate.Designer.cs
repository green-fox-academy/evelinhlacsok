﻿// <auto-generated />
using LicencePlateApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace LicencePlateApp.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20171126124354_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("LicencePlateApp.Models.Car", b =>
                {
                    b.Property<string>("Plate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Car_brand");

                    b.Property<string>("Car_model");

                    b.Property<string>("Color");

                    b.Property<int>("Year");

                    b.HasKey("Plate");

                    b.ToTable("Licence_Plates");
                });
#pragma warning restore 612, 618
        }
    }
}
