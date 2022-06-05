﻿// <auto-generated />
using System;
using DataLib.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLib.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220605102546_Alta01")]
    partial class Alta01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataLib.Entities.Admin", b =>
                {
                    b.Property<string>("teacherId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("Subject")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("birthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool?>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("teacherId");

                    b.HasIndex("Position");

                    b.HasIndex("Subject");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.AdminAccount", b =>
                {
                    b.Property<string>("userName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Admin")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool?>("isLogin")
                        .HasColumnType("bit");

                    b.Property<string>("passWord")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("userName");

                    b.HasIndex("Admin")
                        .IsUnique();

                    b.ToTable("AdminAccount", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Class", b =>
                {
                    b.Property<string>("classId")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("classId");

                    b.HasIndex("Grade");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Class_Course", b =>
                {
                    b.Property<int>("classCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classCourseId"), 1L, 1);

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("Course")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("lession")
                        .HasColumnType("date");

                    b.HasKey("classCourseId");

                    b.HasIndex("Class");

                    b.HasIndex("Course");

                    b.ToTable("Class_Course", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Class_Test", b =>
                {
                    b.Property<int>("classTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classTestId"), 1L, 1);

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("Test")
                        .HasColumnType("int");

                    b.Property<int?>("isComplete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime?>("testDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("testDuration")
                        .HasColumnType("int");

                    b.HasKey("classTestId");

                    b.HasIndex("Class");

                    b.HasIndex("Test");

                    b.ToTable("Class_Test", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courseId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("Subject")
                        .HasColumnType("int");

                    b.Property<DateTime?>("endDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("linkOnline")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("startDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.HasKey("courseId");

                    b.HasIndex("Subject");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Document", b =>
                {
                    b.Property<int>("docId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("docId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("Subject")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("docPath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("docId");

                    b.HasIndex("Subject");

                    b.ToTable("Document", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Grade", b =>
                {
                    b.Property<int>("gradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gradeId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("gradeName")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)");

                    b.HasKey("gradeId");

                    b.ToTable("Grade", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.LearningOutcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Semester")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("Student_Test")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Student");

                    b.HasIndex("Student_Test");

                    b.ToTable("LearnintOutcome", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Position", b =>
                {
                    b.Property<int>("positionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("positionId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("positionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("positionId");

                    b.ToTable("Position", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Student", b =>
                {
                    b.Property<string>("studentId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Class")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("birthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool?>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("studentId");

                    b.HasIndex("Class");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Student_Test", b =>
                {
                    b.Property<int>("studentTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentTestId"), 1L, 1);

                    b.Property<int?>("Class_Test")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("documentTest")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double?>("testMath")
                        .HasColumnType("float");

                    b.HasKey("studentTestId");

                    b.HasIndex("Class_Test");

                    b.HasIndex("Student");

                    b.ToTable("Student_Test", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.StudentAccount", b =>
                {
                    b.Property<string>("userName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("isLogin")
                        .HasColumnType("bit");

                    b.Property<string>("passWord")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("userName");

                    b.HasIndex("Student")
                        .IsUnique();

                    b.ToTable("StudentAccount", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Subject", b =>
                {
                    b.Property<int>("subjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subjectId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("subjectId");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Test", b =>
                {
                    b.Property<int>("testId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("testId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("TestCategory")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("testId");

                    b.HasIndex("TestCategory");

                    b.ToTable("Test", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.TestCategory", b =>
                {
                    b.Property<int>("testCateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("testCateId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("testCateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("testCateId");

                    b.ToTable("TestCategory", (string)null);
                });

            modelBuilder.Entity("DataLib.Entities.Admin", b =>
                {
                    b.HasOne("DataLib.Entities.Position", "Position1")
                        .WithMany("Admins")
                        .HasForeignKey("Position");

                    b.HasOne("DataLib.Entities.Subject", "Subject1")
                        .WithMany("Admins")
                        .HasForeignKey("Subject");

                    b.Navigation("Position1");

                    b.Navigation("Subject1");
                });

            modelBuilder.Entity("DataLib.Entities.AdminAccount", b =>
                {
                    b.HasOne("DataLib.Entities.Admin", "Admin1")
                        .WithOne("AdminAccount")
                        .HasForeignKey("DataLib.Entities.AdminAccount", "Admin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin1");
                });

            modelBuilder.Entity("DataLib.Entities.Class", b =>
                {
                    b.HasOne("DataLib.Entities.Grade", "Grade1")
                        .WithMany("Classes")
                        .HasForeignKey("Grade");

                    b.Navigation("Grade1");
                });

            modelBuilder.Entity("DataLib.Entities.Class_Course", b =>
                {
                    b.HasOne("DataLib.Entities.Class", "Class1")
                        .WithMany("Class_Course")
                        .HasForeignKey("Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLib.Entities.Course", "Course1")
                        .WithMany("Class_Course")
                        .HasForeignKey("Course");

                    b.Navigation("Class1");

                    b.Navigation("Course1");
                });

            modelBuilder.Entity("DataLib.Entities.Class_Test", b =>
                {
                    b.HasOne("DataLib.Entities.Class", "Class1")
                        .WithMany("Class_Test")
                        .HasForeignKey("Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLib.Entities.Test", "Test1")
                        .WithMany("Class_Test")
                        .HasForeignKey("Test");

                    b.Navigation("Class1");

                    b.Navigation("Test1");
                });

            modelBuilder.Entity("DataLib.Entities.Course", b =>
                {
                    b.HasOne("DataLib.Entities.Subject", "Subject1")
                        .WithMany("Courses")
                        .HasForeignKey("Subject");

                    b.Navigation("Subject1");
                });

            modelBuilder.Entity("DataLib.Entities.Document", b =>
                {
                    b.HasOne("DataLib.Entities.Subject", "Subject1")
                        .WithMany("Documents")
                        .HasForeignKey("Subject");

                    b.Navigation("Subject1");
                });

            modelBuilder.Entity("DataLib.Entities.LearningOutcome", b =>
                {
                    b.HasOne("DataLib.Entities.Student", "Student1")
                        .WithMany("LearningOutcomes")
                        .HasForeignKey("Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLib.Entities.Student_Test", "Student_Test1")
                        .WithMany("LearningOutcomes")
                        .HasForeignKey("Student_Test");

                    b.Navigation("Student1");

                    b.Navigation("Student_Test1");
                });

            modelBuilder.Entity("DataLib.Entities.Student", b =>
                {
                    b.HasOne("DataLib.Entities.Class", "Class1")
                        .WithMany("Students")
                        .HasForeignKey("Class");

                    b.Navigation("Class1");
                });

            modelBuilder.Entity("DataLib.Entities.Student_Test", b =>
                {
                    b.HasOne("DataLib.Entities.Class_Test", "Class_Test1")
                        .WithMany("Student_Test")
                        .HasForeignKey("Class_Test");

                    b.HasOne("DataLib.Entities.Student", "Student1")
                        .WithMany("Student_Test")
                        .HasForeignKey("Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class_Test1");

                    b.Navigation("Student1");
                });

            modelBuilder.Entity("DataLib.Entities.StudentAccount", b =>
                {
                    b.HasOne("DataLib.Entities.Student", "Student1")
                        .WithOne("StudentAccount")
                        .HasForeignKey("DataLib.Entities.StudentAccount", "Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student1");
                });

            modelBuilder.Entity("DataLib.Entities.Test", b =>
                {
                    b.HasOne("DataLib.Entities.TestCategory", "TestCategory1")
                        .WithMany("Tests")
                        .HasForeignKey("TestCategory");

                    b.Navigation("TestCategory1");
                });

            modelBuilder.Entity("DataLib.Entities.Admin", b =>
                {
                    b.Navigation("AdminAccount")
                        .IsRequired();
                });

            modelBuilder.Entity("DataLib.Entities.Class", b =>
                {
                    b.Navigation("Class_Course");

                    b.Navigation("Class_Test");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("DataLib.Entities.Class_Test", b =>
                {
                    b.Navigation("Student_Test");
                });

            modelBuilder.Entity("DataLib.Entities.Course", b =>
                {
                    b.Navigation("Class_Course");
                });

            modelBuilder.Entity("DataLib.Entities.Grade", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("DataLib.Entities.Position", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("DataLib.Entities.Student", b =>
                {
                    b.Navigation("LearningOutcomes");

                    b.Navigation("StudentAccount")
                        .IsRequired();

                    b.Navigation("Student_Test");
                });

            modelBuilder.Entity("DataLib.Entities.Student_Test", b =>
                {
                    b.Navigation("LearningOutcomes");
                });

            modelBuilder.Entity("DataLib.Entities.Subject", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Courses");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("DataLib.Entities.Test", b =>
                {
                    b.Navigation("Class_Test");
                });

            modelBuilder.Entity("DataLib.Entities.TestCategory", b =>
                {
                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}