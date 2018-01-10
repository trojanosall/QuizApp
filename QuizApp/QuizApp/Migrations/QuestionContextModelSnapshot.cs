using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QuizApp.Entities;

namespace QuizApp.Migrations
{
    [DbContext(typeof(QuestionContext))]
    partial class QuestionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuizApp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer1");

                    b.Property<string>("Answer2");

                    b.Property<string>("Answer3");

                    b.Property<string>("Answer4");

                    b.Property<string>("TheQuestion");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });
        }
    }
}
