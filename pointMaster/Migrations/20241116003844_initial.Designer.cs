﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pointMaster.Data;

#nullable disable

namespace pointMaster.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241116003844_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pointMaster.Models.Patrulje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patruljer");
                });

            modelBuilder.Entity("pointMaster.Models.PatruljeMedlem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PatruljeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatruljeId");

                    b.ToTable("PatruljeMedlemmer");
                });

            modelBuilder.Entity("pointMaster.Models.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PatruljeId")
                        .HasColumnType("integer");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<int>("PosterId")
                        .HasColumnType("integer");

                    b.Property<int>("Turnout")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatruljeId");

                    b.HasIndex("PosterId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("pointMaster.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Poster");
                });

            modelBuilder.Entity("pointMaster.Models.PatruljeMedlem", b =>
                {
                    b.HasOne("pointMaster.Models.Patrulje", "Patrulje")
                        .WithMany("PatruljeMedlems")
                        .HasForeignKey("PatruljeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patrulje");
                });

            modelBuilder.Entity("pointMaster.Models.Point", b =>
                {
                    b.HasOne("pointMaster.Models.Patrulje", "Patrulje")
                        .WithMany("Points")
                        .HasForeignKey("PatruljeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pointMaster.Models.Post", "Poster")
                        .WithMany()
                        .HasForeignKey("PosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patrulje");

                    b.Navigation("Poster");
                });

            modelBuilder.Entity("pointMaster.Models.Patrulje", b =>
                {
                    b.Navigation("PatruljeMedlems");

                    b.Navigation("Points");
                });
#pragma warning restore 612, 618
        }
    }
}
