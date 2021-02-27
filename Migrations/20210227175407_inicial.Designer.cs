﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro_con_detalle.DAL;

namespace Registro_con_detalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210227175407_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Registro_con_detalle.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Permiso")
                        .HasColumnType("TEXT");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoId = 1,
                            Permiso = "Descuenta"
                        },
                        new
                        {
                            PermisoId = 2,
                            Permiso = "Vende"
                        },
                        new
                        {
                            PermisoId = 3,
                            Permiso = "Cobra"
                        });
                });

            modelBuilder.Entity("Registro_con_detalle.Entidades.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("esActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Registro_con_detalle.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("esAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("Registro_con_detalle.Entidades.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConfirmarClave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Registro_con_detalle.Entidades.Permisos", b =>
                {
                    b.HasOne("Registro_con_detalle.Entidades.Permisos", "permiso")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permiso");
                });

            modelBuilder.Entity("Registro_con_detalle.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("Registro_con_detalle.Entidades.Roles", null)
                        .WithMany("Detalle")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Registro_con_detalle.Entidades.Roles", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
