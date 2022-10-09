﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testapp3.Modals.DBAuth;

namespace testapp3.Migrations
{
    [DbContext(typeof(DBAuthContext))]
    partial class DBAuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("testapp3.Modals.Entity.EEmployee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeAge")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("T_EMPLOYEE");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.EInsideUser", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("contactNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("createdDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastUpdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<long?>("userid")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("T_INSIDE_USERS");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.ETeam", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("createdDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastUpdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("T_TEAMS");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.ETeamOwner", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("contactNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("createddate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("lastUpdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<long?>("teamid")
                        .HasColumnType("bigint");

                    b.Property<long?>("userid")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("teamid");

                    b.HasIndex("userid");

                    b.ToTable("T_TEAM_OWNER");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.EUser", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("createdDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastupdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<long?>("typeid")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("typeid");

                    b.ToTable("T_USER");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.EUserTypes", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("createdDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("isDashBoardEnabled")
                        .HasColumnType("int");

                    b.Property<int>("isViewPlayerEnabled")
                        .HasColumnType("int");

                    b.Property<string>("lastUpdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("T_USER_TYPES");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.EInsideUser", b =>
                {
                    b.HasOne("testapp3.Modals.Entity.EUser", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("user");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.ETeamOwner", b =>
                {
                    b.HasOne("testapp3.Modals.Entity.ETeam", "team")
                        .WithMany()
                        .HasForeignKey("teamid");

                    b.HasOne("testapp3.Modals.Entity.EUser", "user")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("team");

                    b.Navigation("user");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.EUser", b =>
                {
                    b.HasOne("testapp3.Modals.Entity.EUserTypes", "type")
                        .WithMany("Users")
                        .HasForeignKey("typeid");

                    b.Navigation("type");
                });

            modelBuilder.Entity("testapp3.Modals.Entity.EUserTypes", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
