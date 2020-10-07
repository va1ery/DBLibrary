﻿// <auto-generated />
using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBLibrary.Migrations
{
    [DbContext(typeof(DBLibraryContext))]
    partial class DBLibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBLibrary.Models.Book", b =>
                {
                    b.Property<int>("BkId")
                        .HasColumnName("Bk_ID")
                        .HasColumnType("INT");

                    b.Property<int>("BkAuthor")
                        .HasColumnName("Bk_Author")
                        .HasColumnType("INT");

                    b.Property<int>("BkName")
                        .HasColumnName("Bk_Name")
                        .HasColumnType("INT");

                    b.Property<int>("BkRealiseDate")
                        .HasColumnName("Bk_Realise_Date")
                        .HasColumnType("INT");

                    b.Property<int>("GenId")
                        .HasColumnName("Gen_ID")
                        .HasColumnType("INT");

                    b.Property<int>("PubId")
                        .HasColumnName("Pub_ID")
                        .HasColumnType("INT");

                    b.HasKey("BkId");

                    b.HasIndex("GenId");

                    b.HasIndex("PubId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("DBLibrary.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .HasColumnName("Emp_ID")
                        .HasColumnType("INT");

                    b.Property<int>("EmpAddress")
                        .HasColumnName("Emp_Address")
                        .HasColumnType("INT");

                    b.Property<int>("EmpAge")
                        .HasColumnName("Emp_Age")
                        .HasColumnType("INT");

                    b.Property<int>("EmpFullName")
                        .HasColumnName("Emp_Full_Name")
                        .HasColumnType("INT");

                    b.Property<int>("EmpPassportData")
                        .HasColumnName("Emp_Passport_Data")
                        .HasColumnType("INT");

                    b.Property<int>("EmpPhoneNumber")
                        .HasColumnName("Emp_Phone_Number")
                        .HasColumnType("INT");

                    b.Property<int>("EmpSex")
                        .HasColumnName("Emp_Sex")
                        .HasColumnType("INT");

                    b.Property<int>("PosId")
                        .HasColumnName("Pos_ID")
                        .HasColumnType("INT");

                    b.HasKey("EmpId");

                    b.HasIndex("PosId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DBLibrary.Models.Genre", b =>
                {
                    b.Property<int>("GenId")
                        .HasColumnName("Gen_ID")
                        .HasColumnType("INT");

                    b.Property<int>("GenDescription")
                        .HasColumnName("Gen_Description")
                        .HasColumnType("INT");

                    b.Property<int>("GenName")
                        .HasColumnName("Gen_Name")
                        .HasColumnType("INT");

                    b.HasKey("GenId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DBLibrary.Models.Position", b =>
                {
                    b.Property<int>("PosId")
                        .HasColumnName("Pos_ID")
                        .HasColumnType("INT");

                    b.Property<int>("PosDuties")
                        .HasColumnName("Pos_Duties")
                        .HasColumnType("INT");

                    b.Property<int>("PosName")
                        .HasColumnName("Pos_Name")
                        .HasColumnType("INT");

                    b.Property<int>("PosRequirements")
                        .HasColumnName("Pos_Requirements")
                        .HasColumnType("INT");

                    b.Property<int>("PosSalary")
                        .HasColumnName("Pos_Salary")
                        .HasColumnType("INT");

                    b.HasKey("PosId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("DBLibrary.Models.Publisher", b =>
                {
                    b.Property<int>("PubId")
                        .HasColumnName("Pub_ID")
                        .HasColumnType("INT");

                    b.Property<int>("PubAddress")
                        .HasColumnName("Pub_Address")
                        .HasColumnType("INT");

                    b.Property<int>("PubCity")
                        .HasColumnName("Pub_City")
                        .HasColumnType("INT");

                    b.Property<int>("PubName")
                        .HasColumnName("Pub_Name")
                        .HasColumnType("INT");

                    b.HasKey("PubId");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("DBLibrary.Models.Reader", b =>
                {
                    b.Property<int>("RdId")
                        .HasColumnName("Rd_ID")
                        .HasColumnType("INT");

                    b.Property<int>("RdAddress")
                        .HasColumnName("Rd_Address")
                        .HasColumnType("INT");

                    b.Property<int>("RdBdDate")
                        .HasColumnName("Rd_BD_Date")
                        .HasColumnType("INT");

                    b.Property<int>("RdFullName")
                        .HasColumnName("Rd_Full_Name")
                        .HasColumnType("INT");

                    b.Property<int>("RdPassportData")
                        .HasColumnName("Rd_Passport_Data")
                        .HasColumnType("INT");

                    b.Property<int>("RdPhoneNumber")
                        .HasColumnName("Rd_Phone_Number")
                        .HasColumnType("INT");

                    b.Property<int>("RdSex")
                        .HasColumnName("Rd_Sex")
                        .HasColumnType("INT");

                    b.HasKey("RdId");

                    b.ToTable("Reader");
                });

            modelBuilder.Entity("DBLibrary.Models.ReturnedBooks", b =>
                {
                    b.Property<int>("BkId")
                        .HasColumnName("Bk_ID")
                        .HasColumnType("INT");

                    b.Property<int>("EmpId")
                        .HasColumnName("Emp_ID")
                        .HasColumnType("INT");

                    b.Property<int>("RbGiveOutDate")
                        .HasColumnName("Rb_GiveOut_Date")
                        .HasColumnType("INT");

                    b.Property<int>("RbReturnDate")
                        .HasColumnName("Rb_Return_Date")
                        .HasColumnType("INT");

                    b.Property<int>("RbReturnFlag")
                        .HasColumnName("Rb_Return_Flag")
                        .HasColumnType("INT");

                    b.Property<int>("RdId")
                        .HasColumnName("Rd_ID")
                        .HasColumnType("INT");

                    b.HasIndex("BkId");

                    b.HasIndex("EmpId");

                    b.HasIndex("RdId");

                    b.ToTable("Returned_Books");
                });

            modelBuilder.Entity("DBLibrary.Models.Book", b =>
                {
                    b.HasOne("DBLibrary.Models.Genre", "Gen")
                        .WithMany("Book")
                        .HasForeignKey("GenId")
                        .IsRequired();

                    b.HasOne("DBLibrary.Models.Publisher", "Pub")
                        .WithMany("Book")
                        .HasForeignKey("PubId")
                        .IsRequired();
                });

            modelBuilder.Entity("DBLibrary.Models.Employee", b =>
                {
                    b.HasOne("DBLibrary.Models.Position", "Pos")
                        .WithMany("Employee")
                        .HasForeignKey("PosId")
                        .IsRequired();
                });

            modelBuilder.Entity("DBLibrary.Models.ReturnedBooks", b =>
                {
                    b.HasOne("DBLibrary.Models.Book", "Bk")
                        .WithMany()
                        .HasForeignKey("BkId")
                        .IsRequired();

                    b.HasOne("DBLibrary.Models.Employee", "Emp")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .IsRequired();

                    b.HasOne("DBLibrary.Models.Reader", "Rd")
                        .WithMany()
                        .HasForeignKey("RdId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
