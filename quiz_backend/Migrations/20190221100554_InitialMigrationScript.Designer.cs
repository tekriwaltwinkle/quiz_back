﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using quiz_backend;

namespace quiz_backend.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20190221100554_InitialMigrationScript")]
    partial class InitialMigrationScript
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("quiz_backend.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer1");

                    b.Property<string>("Answer2");

                    b.Property<string>("Answer3");

                    b.Property<string>("CorrectAnswer");

                    b.Property<int>("QuizId");

                    b.Property<string>("Text");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("quiz_backend.Models.Quiz", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Quiz");
                });
#pragma warning restore 612, 618
        }
    }
}
