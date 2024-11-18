﻿// <auto-generated />
using System;
using BasedProject.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    [DbContext(typeof(BasedProjectDbContext))]
    [Migration("20241118033050_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BasedProject.Models.BaseEntities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CategoryUrlSlug")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("960aac15-f0dd-4482-bf99-63d77f5273df"),
                            CategoryName = "Technology",
                            CategoryUrlSlug = "technology",
                            Description = "All about tech"
                        },
                        new
                        {
                            Id = new Guid("9336ea9b-b5a2-4025-90fc-3abb4c8735ad"),
                            CategoryName = "Lifestyle",
                            CategoryUrlSlug = "lifestyle",
                            Description = "Tips for better living"
                        },
                        new
                        {
                            Id = new Guid("8bf130cf-1fe2-4d82-bd35-6e45d4fa272e"),
                            CategoryName = "Travel",
                            CategoryUrlSlug = "travel",
                            Description = "Explore the world"
                        });
                });

            modelBuilder.Entity("BasedProject.Models.BaseEntities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostContent")
                        .HasMaxLength(102400)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostUrlSlug")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3ddca58-58b5-42cd-81ac-cdd8fc3442c6"),
                            CategoryId = new Guid("960aac15-f0dd-4482-bf99-63d77f5273df"),
                            PostContent = "ASP.NET is a powerful framework...",
                            PostUrlSlug = "getting-started-aspnet",
                            PostedOn = new DateTime(2024, 11, 18, 10, 30, 50, 584, DateTimeKind.Local).AddTicks(3695),
                            Published = true,
                            ShortDescription = "A guide to ASP.NET for beginners",
                            Title = "Getting Started with ASP.NET"
                        },
                        new
                        {
                            Id = new Guid("a45fe141-70e2-4e4f-8856-490a3e885502"),
                            CategoryId = new Guid("9336ea9b-b5a2-4025-90fc-3abb4c8735ad"),
                            PostContent = "Living a healthy life involves...",
                            PostUrlSlug = "healthy-living-tips",
                            PostedOn = new DateTime(2024, 11, 18, 10, 30, 50, 584, DateTimeKind.Local).AddTicks(3704),
                            Published = true,
                            ShortDescription = "Tips for a healthy lifestyle",
                            Title = "Healthy Living Tips"
                        },
                        new
                        {
                            Id = new Guid("6b17d64b-8042-478f-aef1-859aae94b9f2"),
                            CategoryId = new Guid("8bf130cf-1fe2-4d82-bd35-6e45d4fa272e"),
                            PostContent = "From beaches to mountains, explore...",
                            PostUrlSlug = "top-travel-destinations",
                            PostedOn = new DateTime(2024, 11, 18, 10, 30, 50, 584, DateTimeKind.Local).AddTicks(3705),
                            Published = true,
                            ShortDescription = "The best places to visit this year",
                            Title = "Top 10 Travel Destinations"
                        });
                });

            modelBuilder.Entity("BasedProject.Models.BaseEntities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TagUrlSlug")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("836422c7-7106-4bc3-959c-f5606aba1705"),
                            TagName = "C#",
                            TagUrlSlug = "csharp"
                        },
                        new
                        {
                            Id = new Guid("57916fcb-ff02-433d-8dfb-402ac65d3cd6"),
                            TagName = "EF Core",
                            TagUrlSlug = "ef-core"
                        },
                        new
                        {
                            Id = new Guid("8cbad87d-5124-44af-bf79-9d601457d08e"),
                            TagName = "ASP.NET",
                            TagUrlSlug = "aspnet"
                        });
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<Guid>("PostsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTags", (string)null);
                });

            modelBuilder.Entity("BasedProject.Models.BaseEntities.Post", b =>
                {
                    b.HasOne("BasedProject.Models.BaseEntities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("BasedProject.Models.BaseEntities.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BasedProject.Models.BaseEntities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BasedProject.Models.BaseEntities.Category", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}