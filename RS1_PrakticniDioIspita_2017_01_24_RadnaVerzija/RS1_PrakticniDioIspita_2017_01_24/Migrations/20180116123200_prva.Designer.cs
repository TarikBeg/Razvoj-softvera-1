﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RS1_PrakticniDioIspita_2017_01_24.EF;
using System;

namespace RS1_PrakticniDioIspita_2017_01_24.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20180116123200_prva")]
    partial class prva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Angazovan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("NastavnikId");

                    b.Property<int?>("OdjeljenjeId");

                    b.Property<int?>("PredmetId");

                    b.HasKey("Id");

                    b.HasIndex("NastavnikId");

                    b.HasIndex("OdjeljenjeId");

                    b.HasIndex("PredmetId");

                    b.ToTable("Angazovan");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Nastavnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Odjeljenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("NastavnikId");

                    b.Property<string>("Oznaka");

                    b.Property<int>("Razred");

                    b.HasKey("Id");

                    b.HasIndex("NastavnikId");

                    b.ToTable("Odjeljenje");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.OdrzaniCas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AngazovanId");

                    b.Property<DateTime>("datum");

                    b.HasKey("Id");

                    b.HasIndex("AngazovanId");

                    b.ToTable("OdrzaniCas");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.OdrzaniCasDetalji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Ocjena");

                    b.Property<int>("OdrzaniCasId");

                    b.Property<bool>("Odsutan");

                    b.Property<bool?>("OpravdanoOdsutan");

                    b.Property<int>("UpisUOdjeljenjeId");

                    b.HasKey("Id");

                    b.HasIndex("OdrzaniCasId");

                    b.HasIndex("UpisUOdjeljenjeId");

                    b.ToTable("OdrzaniCasDetalji");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Ucenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.HasKey("Id");

                    b.ToTable("Ucenik");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.UpisUOdjeljenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojUDnevniku");

                    b.Property<int>("OdjeljenjeId");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("OdjeljenjeId");

                    b.HasIndex("UcenikId");

                    b.ToTable("UpisUOdjeljenje");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Angazovan", b =>
                {
                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("NastavnikId");

                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeId");

                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.Odjeljenje", b =>
                {
                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("NastavnikId");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.OdrzaniCas", b =>
                {
                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Angazovan", "Angazovan")
                        .WithMany()
                        .HasForeignKey("AngazovanId");
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.OdrzaniCasDetalji", b =>
                {
                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.OdrzaniCas", "OdrzaniCas")
                        .WithMany()
                        .HasForeignKey("OdrzaniCasId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.UpisUOdjeljenje", "UpisUOdjeljenje")
                        .WithMany()
                        .HasForeignKey("UpisUOdjeljenjeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RS1_PrakticniDioIspita_2017_01_24.Models.UpisUOdjeljenje", b =>
                {
                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RS1_PrakticniDioIspita_2017_01_24.Models.Ucenik", "Ucenik")
                        .WithMany()
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
