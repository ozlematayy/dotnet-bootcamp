﻿// <auto-generated />
using System;
using DotnetBootcamp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetBootcamp.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotnetBootcamp.Core.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9218),
                            TeamName = "Development"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9227),
                            TeamName = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9227),
                            TeamName = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9228),
                            TeamName = "IK"
                        });
                });

            modelBuilder.Entity("DotnetBootcamp.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9495),
                            Email = "ozlematay@gmail.com",
                            Password = "123456",
                            TeamId = 1,
                            UserName = "ozlem"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9497),
                            Email = "aysekurt@gmail.com",
                            Password = "122312",
                            TeamId = 2,
                            UserName = "aysekurt"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9497),
                            Email = "aliakçay@gmail.com",
                            Password = "423785482",
                            TeamId = 3,
                            UserName = "ali"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9498),
                            Email = "ecenaz@gmail.com",
                            Password = "35374125",
                            TeamId = 4,
                            UserName = "ecenaz"
                        });
                });

            modelBuilder.Entity("DotnetBootcamp.Core.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Özlem",
                            LastName = "Atay",
                            NickName = "ozl",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Ayşe",
                            LastName = "Kurt",
                            NickName = "ayse",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Ali",
                            LastName = "Akçay",
                            NickName = "alis",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Ece",
                            LastName = "Naz",
                            NickName = "ece",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("DotnetBootcamp.Core.Models.User", b =>
                {
                    b.HasOne("DotnetBootcamp.Core.Models.Team", "Team")
                        .WithMany("User")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("DotnetBootcamp.Core.Models.UserProfile", b =>
                {
                    b.HasOne("DotnetBootcamp.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DotnetBootcamp.Core.Models.Team", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
