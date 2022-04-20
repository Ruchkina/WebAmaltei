﻿// <auto-generated />
using System;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppAmalt.Migrations
{
    [DbContext(typeof(DatabaseContexts))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AppAmalt.Model.Age", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Between20_30Age")
                        .HasColumnType("double precision");

                    b.Property<double>("Between30_40Age")
                        .HasColumnType("double precision");

                    b.Property<double>("Between40_60Age")
                        .HasColumnType("double precision");

                    b.Property<double>("Less20Age")
                        .HasColumnType("double precision");

                    b.Property<double>("Over60")
                        .HasColumnType("double precision");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Age");
                });

            modelBuilder.Entity("AppAmalt.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AppAmalt.Model.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<int>("School")
                        .HasColumnType("integer");

                    b.Property<int>("University")
                        .HasColumnType("integer");

                    b.Property<int>("Work")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("AppAmalt.Model.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("MenFollower")
                        .HasColumnType("double precision");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<double>("WomenFollower")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("AppAmalt.Model.LifeMain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CareerMoney")
                        .HasColumnType("double precision");

                    b.Property<double>("Entertainment")
                        .HasColumnType("double precision");

                    b.Property<double>("FamePower")
                        .HasColumnType("double precision");

                    b.Property<double>("Family")
                        .HasColumnType("double precision");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<double>("Science")
                        .HasColumnType("double precision");

                    b.Property<double>("SelfDevelopment")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("LifeMains");
                });

            modelBuilder.Entity("AppAmalt.Model.Party", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Fractions");
                });

            modelBuilder.Entity("AppAmalt.Model.Political", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Communists")
                        .HasColumnType("double precision");

                    b.Property<double>("Conservatives")
                        .HasColumnType("double precision");

                    b.Property<double>("Indifferents")
                        .HasColumnType("double precision");

                    b.Property<double>("Liberals")
                        .HasColumnType("double precision");

                    b.Property<double>("Moderate")
                        .HasColumnType("double precision");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<double>("Socialists")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Politicals");
                });

            modelBuilder.Entity("AppAmalt.Model.Portrait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("LifeMain")
                        .HasColumnType("text");

                    b.Property<string>("Occupation")
                        .HasColumnType("text");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<string>("Political")
                        .HasColumnType("text");

                    b.Property<string>("Relation")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("PartyId")
                        .IsUnique();

                    b.ToTable("Portraits");
                });

            modelBuilder.Entity("AppAmalt.Model.Relation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ActiveResearch")
                        .HasColumnType("integer");

                    b.Property<int>("CivilMerriage")
                        .HasColumnType("integer");

                    b.Property<int>("Engagement")
                        .HasColumnType("integer");

                    b.Property<int>("HaveFriend")
                        .HasColumnType("integer");

                    b.Property<int>("Married")
                        .HasColumnType("integer");

                    b.Property<int>("NotMarried")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("AppAmalt.Model.ValueCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("PartyId")
                        .HasColumnType("integer");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("PartyId");

                    b.ToTable("ValueCitis");
                });

            modelBuilder.Entity("AppAmalt.Model.Age", b =>
                {
                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithOne("Age")
                        .HasForeignKey("AppAmalt.Model.Age", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.Education", b =>
                {
                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.Gender", b =>
                {
                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithOne("Gender")
                        .HasForeignKey("AppAmalt.Model.Gender", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.LifeMain", b =>
                {
                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithOne("LifeMain")
                        .HasForeignKey("AppAmalt.Model.LifeMain", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.Party", b =>
                {
                    b.HasOne("AppAmalt.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("AppAmalt.Model.Political", b =>
                {
                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithOne("Political")
                        .HasForeignKey("AppAmalt.Model.Political", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.Portrait", b =>
                {
                    b.HasOne("AppAmalt.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithOne("Portrait")
                        .HasForeignKey("AppAmalt.Model.Portrait", "PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.Relation", b =>
                {
                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAmalt.Model.ValueCity", b =>
                {
                    b.HasOne("AppAmalt.Model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppAmalt.Model.Party", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
