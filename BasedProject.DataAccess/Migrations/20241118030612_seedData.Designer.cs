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
    [Migration("20241118030612_seedData")]
    partial class seedData
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
                            Id = new Guid("bc91bb55-c0f2-4012-a0a7-8b5a5ed626c9"),
                            CategoryName = "Technology",
                            CategoryUrlSlug = "technology",
                            Description = "All about tech"
                        },
                        new
                        {
                            Id = new Guid("c1a50d85-b239-4281-9de1-4fb911d525cf"),
                            CategoryName = "Lifestyle",
                            CategoryUrlSlug = "lifestyle",
                            Description = "Tips for better living"
                        },
                        new
                        {
                            Id = new Guid("4bc46f19-70f8-47b9-99c8-045ecdc99da2"),
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
                            Id = new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"),
                            CategoryId = new Guid("660d77bf-6ed8-446f-891b-4a486a109214"),
                            PostContent = "ASP.NET is a powerful framework...",
                            PostUrlSlug = "getting-started-aspnet",
                            PostedOn = new DateTime(2024, 11, 18, 10, 6, 12, 97, DateTimeKind.Local).AddTicks(6828),
                            Published = true,
                            ShortDescription = "A guide to ASP.NET for beginners",
                            Title = "Getting Started with ASP.NET"
                        },
                        new
                        {
                            Id = new Guid("f517791a-738e-471c-8f2e-ad18e139038e"),
                            CategoryId = new Guid("ca2d1bda-dc62-4cc7-a5a1-7487c18cb294"),
                            PostContent = "Living a healthy life involves...",
                            PostUrlSlug = "healthy-living-tips",
                            PostedOn = new DateTime(2024, 11, 18, 10, 6, 12, 97, DateTimeKind.Local).AddTicks(6838),
                            Published = true,
                            ShortDescription = "Tips for a healthy lifestyle",
                            Title = "Healthy Living Tips"
                        },
                        new
                        {
                            Id = new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"),
                            CategoryId = new Guid("17f03e82-f859-486b-ac4a-55844517ae9e"),
                            PostContent = "From beaches to mountains, explore...",
                            PostUrlSlug = "top-travel-destinations",
                            PostedOn = new DateTime(2024, 11, 18, 10, 6, 12, 97, DateTimeKind.Local).AddTicks(6840),
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
                            Id = new Guid("3bdd4c93-1081-4c10-a6ad-bd098a30502f"),
                            TagName = "C#",
                            TagUrlSlug = "csharp"
                        },
                        new
                        {
                            Id = new Guid("977736af-ec2c-4841-ac31-34280aa64423"),
                            TagName = "EF Core",
                            TagUrlSlug = "ef-core"
                        },
                        new
                        {
                            Id = new Guid("af23f823-f098-4112-94ef-ff278d3fd217"),
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
