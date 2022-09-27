﻿// <auto-generated />
using Duitkuh.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Duitkuh.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220926073132_Duitkuh01")]
    partial class Duitkuh01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Duitkuh.Model.Role", b =>
                {
                    b.Property<int>("Id_Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name_Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Role");

                    b.ToTable("TB_M_Role");
                });

            modelBuilder.Entity("Duitkuh.Model.User", b =>
                {
                    b.Property<int>("Id_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_User");

                    b.ToTable("TB_M_User");
                });

            modelBuilder.Entity("Duitkuh.Model.UserRole", b =>
                {
                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<int>("Id_Role")
                        .HasColumnType("int");

                    b.HasKey("Id_User");

                    b.HasIndex("Id_Role");

                    b.ToTable("TB_M_UserRole");
                });

            modelBuilder.Entity("Duitkuh.Model.UserRole", b =>
                {
                    b.HasOne("Duitkuh.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Id_Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Duitkuh.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}