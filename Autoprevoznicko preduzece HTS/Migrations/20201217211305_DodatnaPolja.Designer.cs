﻿// <auto-generated />
using System;
using Autoprevoznicko_preduzece_HTS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Autoprevoznicko_preduzece_HTS.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20201217211305_DodatnaPolja")]
    partial class DodatnaPolja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Autobus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojSjedila")
                        .HasColumnType("int");

                    b.Property<int>("GodisteAutobusa")
                        .HasColumnType("int");

                    b.Property<int>("RedniBrojAutobusa")
                        .HasColumnType("int");

                    b.Property<string>("informacije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("autobus");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.AutobusVozac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("autobusID")
                        .HasColumnType("int");

                    b.Property<DateTime>("kraj")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("pocetak")
                        .HasColumnType("datetime2");

                    b.Property<int>("smjena")
                        .HasColumnType("int");

                    b.Property<int>("vozacID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("autobusID");

                    b.HasIndex("vozacID");

                    b.ToTable("autobusVozac");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.AutorizacijskiToken", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoginID")
                        .HasColumnType("int");

                    b.Property<string>("Vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("LoginID");

                    b.ToTable("AutorizacijskiToken");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Cjenovnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("cijena")
                        .HasColumnType("real");

                    b.Property<int>("tipkarteID")
                        .HasColumnType("int");

                    b.Property<int>("vrstaKarteID")
                        .HasColumnType("int");

                    b.Property<int>("zonaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("tipkarteID");

                    b.HasIndex("vrstaKarteID");

                    b.HasIndex("zonaID");

                    b.ToTable("cjenovnik");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.Property<string>("nazivGrada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("grad");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.GradskeLinije", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojAutobusaID")
                        .HasColumnType("int");

                    b.Property<int>("StanicaDolaskaID")
                        .HasColumnType("int");

                    b.Property<int>("StanicaPolaskaID")
                        .HasColumnType("int");

                    b.Property<int>("zonaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BrojAutobusaID");

                    b.HasIndex("StanicaDolaskaID");

                    b.HasIndex("StanicaPolaskaID");

                    b.HasIndex("zonaID");

                    b.ToTable("gradskeLinije");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Karta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVadjenjaKarte")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVazenjaKarte")
                        .HasColumnType("datetime2");

                    b.Property<int>("gradskaLinijaID")
                        .HasColumnType("int");

                    b.Property<int>("kupacID")
                        .HasColumnType("int");

                    b.Property<int>("tipKarteID")
                        .HasColumnType("int");

                    b.Property<int>("vrstaKarteID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("gradskaLinijaID");

                    b.HasIndex("kupacID");

                    b.HasIndex("tipKarteID");

                    b.HasIndex("vrstaKarteID");

                    b.ToTable("karta");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Kupac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradID")
                        .HasColumnType("int");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("gradID");

                    b.ToTable("kupac");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Login", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ZapamtiSifru")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("login");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Obavijesti", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("upravaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("upravaID");

                    b.ToTable("obavijesti");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Opstina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivOpstine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("gradID");

                    b.ToTable("opstina");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.RedVoznje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("VrijemePolaska")
                        .HasColumnType("datetime2");

                    b.Property<int>("gradskaLinijaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("gradskaLinijaID");

                    b.ToTable("redVoznje");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.RegistracioniPodaci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PolisaOsiguranja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("autobusID")
                        .HasColumnType("int");

                    b.Property<int>("registracijskibroj")
                        .HasColumnType("int");

                    b.Property<string>("tehnickipregled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("upravaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("autobusID");

                    b.HasIndex("upravaID");

                    b.ToTable("registracioniPodaci");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Stanica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazivLokacijeStanice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("stanica");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.TipKarte", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Informacije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("tipKarte");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Uprava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("loginID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("loginID");

                    b.ToTable("uprava");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Vozac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VozackaKategorija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("loginID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("loginID");

                    b.ToTable("vozac");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.VrstaKarte", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Informacije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("vrstaKarte");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Zona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojZone")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("zona");
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.AutobusVozac", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Autobus", "autobus")
                        .WithMany()
                        .HasForeignKey("autobusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Vozac", "vozac")
                        .WithMany()
                        .HasForeignKey("vozacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.AutorizacijskiToken", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Cjenovnik", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.TipKarte", "tipkarte")
                        .WithMany()
                        .HasForeignKey("tipkarteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.VrstaKarte", "vrstaKarte")
                        .WithMany()
                        .HasForeignKey("vrstaKarteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Zona", "zona")
                        .WithMany()
                        .HasForeignKey("zonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.GradskeLinije", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Autobus", "BrojAutobusa")
                        .WithMany()
                        .HasForeignKey("BrojAutobusaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Stanica", "StanicaDolaska")
                        .WithMany()
                        .HasForeignKey("StanicaDolaskaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Stanica", "StanicaPolaska")
                        .WithMany()
                        .HasForeignKey("StanicaPolaskaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Zona", "zona")
                        .WithMany()
                        .HasForeignKey("zonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Karta", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.GradskeLinije", "gradskaLinija")
                        .WithMany()
                        .HasForeignKey("gradskaLinijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Kupac", "kupac")
                        .WithMany()
                        .HasForeignKey("kupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.TipKarte", "tipKarte")
                        .WithMany()
                        .HasForeignKey("tipKarteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.VrstaKarte", "vrstaKarte")
                        .WithMany()
                        .HasForeignKey("vrstaKarteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Kupac", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("gradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Obavijesti", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Uprava", "uprava")
                        .WithMany()
                        .HasForeignKey("upravaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Opstina", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("gradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.RedVoznje", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.GradskeLinije", "gradskaLinija")
                        .WithMany()
                        .HasForeignKey("gradskaLinijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.RegistracioniPodaci", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Autobus", "autobus")
                        .WithMany()
                        .HasForeignKey("autobusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Uprava", "uprava")
                        .WithMany()
                        .HasForeignKey("upravaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Uprava", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Login", "login")
                        .WithMany()
                        .HasForeignKey("loginID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Autoprevoznicko_preduzece_HTS.Model.Vozac", b =>
                {
                    b.HasOne("Autoprevoznicko_preduzece_HTS.Model.Login", "login")
                        .WithMany()
                        .HasForeignKey("loginID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
