﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend_burgueria.Context;

#nullable disable

namespace backendburgueria.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20221122195210_insercaodoproductidnatabelaingrediente")]
    partial class insercaodoproductidnatabelaingrediente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend_burgueria.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdCategory")
                        .HasColumnType("integer");

                    b.Property<int?>("IngredientCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IngredientCategoryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("ingredient");
                });

            modelBuilder.Entity("backend_burgueria.Models.IngredientCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("backend_burgueria.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("order");
                });

            modelBuilder.Entity("backend_burgueria.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");
                });

            modelBuilder.Entity("backend_burgueria.Models.Ingredient", b =>
                {
                    b.HasOne("backend_burgueria.Models.IngredientCategory", "IngredientCategory")
                        .WithMany("Ingredient")
                        .HasForeignKey("IngredientCategoryId");

                    b.HasOne("backend_burgueria.Models.Product", "Product")
                        .WithMany("Ingredient")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend_burgueria.Models.Product", null)
                        .WithMany("IngredientId")
                        .HasForeignKey("ProductId1");

                    b.Navigation("IngredientCategory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("backend_burgueria.Models.IngredientCategory", b =>
                {
                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("backend_burgueria.Models.Product", b =>
                {
                    b.Navigation("Ingredient");

                    b.Navigation("IngredientId");
                });
#pragma warning restore 612, 618
        }
    }
}
