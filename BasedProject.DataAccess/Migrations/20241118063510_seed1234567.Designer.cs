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
    [Migration("20241118063510_seed1234567")]
    partial class seed1234567
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
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a8d1fde8-83df-45bd-9307-b60e59926fbe"),
                            CategoryName = "Technology",
                            CategoryUrlSlug = "technology",
                            Description = "All about tech"
                        },
                        new
                        {
                            Id = new Guid("00c44580-e3ac-4352-95c8-51a968ee79b3"),
                            CategoryName = "Lifestyle",
                            CategoryUrlSlug = "lifestyle",
                            Description = "Tips for better living"
                        },
                        new
                        {
                            Id = new Guid("99433e73-8c2b-4380-98cb-a217e7fc8cae"),
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
                        .IsRequired()
                        .HasMaxLength(102400)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostUrlSlug")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
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
                            Id = new Guid("b3172df0-a087-4ed8-a131-9f5a5f24f1f5"),
                            CategoryId = new Guid("a8d1fde8-83df-45bd-9307-b60e59926fbe"),
                            PostContent = "ASP.NET is a powerful framework...",
                            PostUrlSlug = "getting-started-aspnet",
                            PostedOn = new DateTime(2024, 11, 18, 13, 35, 10, 274, DateTimeKind.Local).AddTicks(4021),
                            Published = true,
                            ShortDescription = "A guide to ASP.NET for beginners",
                            Title = "Getting Started with ASP.NET"
                        },
                        new
                        {
                            Id = new Guid("5753b3bb-fe6b-4b19-8458-97af0bfe2c44"),
                            CategoryId = new Guid("00c44580-e3ac-4352-95c8-51a968ee79b3"),
                            PostContent = "Living a healthy life involves...",
                            PostUrlSlug = "healthy-living-tips",
                            PostedOn = new DateTime(2024, 11, 18, 13, 35, 10, 274, DateTimeKind.Local).AddTicks(4034),
                            Published = true,
                            ShortDescription = "Tips for a healthy lifestyle",
                            Title = "Healthy Living Tips"
                        },
                        new
                        {
                            Id = new Guid("d3d5a837-464c-4fe5-989a-f326aa4e2080"),
                            CategoryId = new Guid("99433e73-8c2b-4380-98cb-a217e7fc8cae"),
                            PostContent = "From beaches to mountains, explore...",
                            PostUrlSlug = "top-travel-destinations",
                            PostedOn = new DateTime(2024, 11, 18, 13, 35, 10, 274, DateTimeKind.Local).AddTicks(4035),
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
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3a41f8b4-d326-4c8e-9930-e31ff8d2bbbd"),
                            TagName = "C#",
                            TagUrlSlug = "csharp"
                        },
                        new
                        {
                            Id = new Guid("cfd89877-064c-4235-9b1d-a7b229196901"),
                            TagName = "EF Core",
                            TagUrlSlug = "ef-core"
                        },
                        new
                        {
                            Id = new Guid("9f58345a-9cdf-416f-bf76-77cd531d9d5b"),
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