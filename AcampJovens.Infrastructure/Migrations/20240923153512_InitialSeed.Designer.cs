﻿// <auto-generated />
using System;
using AcampJovens.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AcampJovens.Infrastructure.Migrations
{
    [DbContext(typeof(AcampJovensDbContext))]
    [Migration("20240923153512_InitialSeed")]
    partial class InitialSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AcampJovens.Core.Entities.Audio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AudioBase64")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uuid");

                    b.Property<int>("MessageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MessageId")
                        .IsUnique();

                    b.ToTable("Audios");
                });

            modelBuilder.Entity("AcampJovens.Core.Entities.Camper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Campers");
                });

            modelBuilder.Entity("AcampJovens.Core.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CamperId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CamperId")
                        .IsUnique();

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("AcampJovens.Core.Entities.Audio", b =>
                {
                    b.HasOne("AcampJovens.Core.Entities.Message", "Message")
                        .WithOne("AudioFile")
                        .HasForeignKey("AcampJovens.Core.Entities.Audio", "MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("AcampJovens.Core.Entities.Message", b =>
                {
                    b.HasOne("AcampJovens.Core.Entities.Camper", "Camper")
                        .WithOne("Message")
                        .HasForeignKey("AcampJovens.Core.Entities.Message", "CamperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camper");
                });

            modelBuilder.Entity("AcampJovens.Core.Entities.Camper", b =>
                {
                    b.Navigation("Message");
                });

            modelBuilder.Entity("AcampJovens.Core.Entities.Message", b =>
                {
                    b.Navigation("AudioFile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
