﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManagement.Models;

namespace ProjectManagement.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManagement.Models.Grading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<int?>("CriteriaId");

                    b.Property<float>("Grade");

                    b.Property<int?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("CriteriaId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Gradings");
                });

            modelBuilder.Entity("ProjectManagement.Models.GradingCriteria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Points");

                    b.HasKey("Id");

                    b.ToTable("GradingCriterias");
                });

            modelBuilder.Entity("ProjectManagement.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfSubmission");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectManagement.Models.Proposal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Approved");

                    b.Property<string>("Description");

                    b.Property<int?>("ProjectId");

                    b.Property<DateTime>("RejectedDate");

                    b.Property<string>("RejectedReason");

                    b.Property<DateTime>("SubmissionDate");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Proposals");
                });

            modelBuilder.Entity("ProjectManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ProjectManagement.Models.Grading", b =>
                {
                    b.HasOne("ProjectManagement.Models.GradingCriteria", "Criteria")
                        .WithMany("Gradings")
                        .HasForeignKey("CriteriaId");

                    b.HasOne("ProjectManagement.Models.Project", "Project")
                        .WithMany("Gradings")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ProjectManagement.Models.Proposal", b =>
                {
                    b.HasOne("ProjectManagement.Models.Project", "Project")
                        .WithMany("Proposals")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ProjectManagement.Models.Student", b =>
                {
                    b.HasOne("ProjectManagement.Models.Project", "Project")
                        .WithMany("Students")
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
