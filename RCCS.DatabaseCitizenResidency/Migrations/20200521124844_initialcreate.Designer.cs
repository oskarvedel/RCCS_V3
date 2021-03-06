﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RCCS.DatabaseCitizenResidency.Data;

namespace RCCS.DatabaseCitizenResidency.Migrations
{
    [DbContext(typeof(RCCSContext))]
    [Migration("20200521124844_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RCCS.Database.Model.Citizen", b =>
                {
                    b.Property<long>("CPR")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CPR");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("RCCS.Database.Model.CitizenOverview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CareNeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CitizenCPR")
                        .HasColumnType("bigint");

                    b.Property<int>("NumberOfReevaluations")
                        .HasColumnType("int");

                    b.Property<string>("PurposeOfStay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitizenCPR")
                        .IsUnique();

                    b.ToTable("CitizenOverviews");
                });

            modelBuilder.Entity("RCCS.Database.Model.ProgressReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CitizenCPR")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Report")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsibleCaretaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitizenCPR");

                    b.ToTable("ProgressReports");
                });

            modelBuilder.Entity("RCCS.Database.Model.Relative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CitizenCPR")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Relation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitizenCPR");

                    b.ToTable("Relatives");
                });

            modelBuilder.Entity("RCCS.Database.Model.ResidenceInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CitizenCPR")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PlannedDischargeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProspectiveSituationStatusForCitizen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReevaluationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CitizenCPR")
                        .IsUnique();

                    b.ToTable("ResidenceInformations");
                });

            modelBuilder.Entity("RCCS.Database.Model.RespiteCareHome", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvailableRespiteCareRooms")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("RespiteCareRoomsTotal")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("RespiteCareHomes");
                });

            modelBuilder.Entity("RCCS.Database.Model.RespiteCareRoom", b =>
                {
                    b.Property<int>("RespiteCareRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CitizenCPR")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("RespiteCareHomeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RespiteCareRoomId");

                    b.HasIndex("CitizenCPR")
                        .IsUnique()
                        .HasFilter("[CitizenCPR] IS NOT NULL");

                    b.HasIndex("RespiteCareHomeName");

                    b.ToTable("RespiteCareRooms");
                });

            modelBuilder.Entity("RCCS.Database.Model.CitizenOverview", b =>
                {
                    b.HasOne("RCCS.Database.Model.Citizen", "Citizen")
                        .WithOne("CitizenOverview")
                        .HasForeignKey("RCCS.Database.Model.CitizenOverview", "CitizenCPR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RCCS.Database.Model.ProgressReport", b =>
                {
                    b.HasOne("RCCS.Database.Model.Citizen", "Citizen")
                        .WithMany("ProgressReports")
                        .HasForeignKey("CitizenCPR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RCCS.Database.Model.Relative", b =>
                {
                    b.HasOne("RCCS.Database.Model.Citizen", "Citizen")
                        .WithMany("Relatives")
                        .HasForeignKey("CitizenCPR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RCCS.Database.Model.ResidenceInformation", b =>
                {
                    b.HasOne("RCCS.Database.Model.Citizen", "Citizen")
                        .WithOne("ResidenceInformation")
                        .HasForeignKey("RCCS.Database.Model.ResidenceInformation", "CitizenCPR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RCCS.Database.Model.RespiteCareRoom", b =>
                {
                    b.HasOne("RCCS.Database.Model.Citizen", "Citizen")
                        .WithOne("RespiteCareRoom")
                        .HasForeignKey("RCCS.Database.Model.RespiteCareRoom", "CitizenCPR");

                    b.HasOne("RCCS.Database.Model.RespiteCareHome", "RespiteCareHome")
                        .WithMany("RespiteCareRooms")
                        .HasForeignKey("RespiteCareHomeName");
                });
#pragma warning restore 612, 618
        }
    }
}
