﻿// <auto-generated />
using FifaCardApi.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FifaCardApi.Repository.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20230524031023_Player_Cards")]
    partial class Player_Cards
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FifaCardApi.Domain.Data.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("Defending")
                        .HasColumnType("smallint");

                    b.Property<short>("Dribbling")
                        .HasColumnType("smallint");

                    b.Property<short>("Pace")
                        .HasColumnType("smallint");

                    b.Property<short>("Passing")
                        .HasColumnType("smallint");

                    b.Property<short>("Physicality")
                        .HasColumnType("smallint");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<short>("Shooting")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("FifaCardApi.Domain.Data.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("Age")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("FifaCardApi.Domain.Data.Card", b =>
                {
                    b.HasOne("FifaCardApi.Domain.Data.Player", "Player")
                        .WithMany("Cards")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("FifaCardApi.Domain.Data.Player", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
