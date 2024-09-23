﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoLoginAPI.Data;

#nullable disable

namespace ProjetoLoginAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240923001708_AddLivrosECategorias")]
    partial class AddLivrosECategorias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ProjetoLoginAPI.Models.CategoriaLivro", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("CategoriaLivros");
                });

            modelBuilder.Entity("ProjetoLoginAPI.Models.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AnoPublicacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAquisicao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edicao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroExemplares")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroPaginas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LivroId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("ProjetoLoginAPI.Models.LivroCategoria", b =>
                {
                    b.Property<int>("LivroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LivroId", "CategoriaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("LivroCategorias");
                });

            modelBuilder.Entity("ProjetoLoginAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoLoginAPI.Models.LivroCategoria", b =>
                {
                    b.HasOne("ProjetoLoginAPI.Models.CategoriaLivro", "Categoria")
                        .WithMany("LivroCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoLoginAPI.Models.Livro", "Livro")
                        .WithMany("LivroCategorias")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("ProjetoLoginAPI.Models.CategoriaLivro", b =>
                {
                    b.Navigation("LivroCategorias");
                });

            modelBuilder.Entity("ProjetoLoginAPI.Models.Livro", b =>
                {
                    b.Navigation("LivroCategorias");
                });
#pragma warning restore 612, 618
        }
    }
}
