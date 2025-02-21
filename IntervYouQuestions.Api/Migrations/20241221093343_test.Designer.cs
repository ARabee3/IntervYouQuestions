﻿// <auto-generated />
using IntervYouQuestions.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntervYouQuestions.Api.Migrations
{
    [DbContext(typeof(InterviewModuleContext))]
    [Migration("20241221093343_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Categori__19093A0BE68A9E3C");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.ModelAnswer", b =>
                {
                    b.Property<int>("ModelAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Model_Answer_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModelAnswerId"));

                    b.Property<string>("KeyPoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Key_Points");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ModelAnswerId")
                        .HasName("PK__Model_An__DFF72A5B619179FE");

                    b.HasIndex("QuestionId");

                    b.ToTable("Model_Answers", (string)null);
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("QuestionId")
                        .HasName("PK__Question__0DC06FACD726E932");

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.QuestionOption", b =>
                {
                    b.Property<int>("OptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Option_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OptionId"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit")
                        .HasColumnName("isCorrect");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OptionId")
                        .HasName("PK__Question__3260907EADE631F9");

                    b.HasIndex("QuestionId");

                    b.ToTable("Question_Options", (string)null);
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TopicId")
                        .HasName("PK__Topics__022E0F5D533AA597");

                    b.HasIndex("CategoryId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.ModelAnswer", b =>
                {
                    b.HasOne("IntervYouQuestions.Api.Entities.Question", "Question")
                        .WithMany("ModelAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Model_Ans__Quest__412EB0B6");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Question", b =>
                {
                    b.HasOne("IntervYouQuestions.Api.Entities.Topic", "Topic")
                        .WithMany("Questions")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Questions__Topic__3E52440B");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.QuestionOption", b =>
                {
                    b.HasOne("IntervYouQuestions.Api.Entities.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Question___Quest__440B1D61");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Topic", b =>
                {
                    b.HasOne("IntervYouQuestions.Api.Entities.Category", "Category")
                        .WithMany("Topics")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Topics__Category__3B75D760");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Category", b =>
                {
                    b.Navigation("Topics");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Question", b =>
                {
                    b.Navigation("ModelAnswers");

                    b.Navigation("QuestionOptions");
                });

            modelBuilder.Entity("IntervYouQuestions.Api.Entities.Topic", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
