﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PasswordAutoFill.Data;

#nullable disable

namespace PasswordAutoFill.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221110200052_autofill")]
    partial class autofill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CredentialHistory", b =>
                {
                    b.Property<int>("Credentialscredentialid")
                        .HasColumnType("int");

                    b.Property<int>("historyid")
                        .HasColumnType("int");

                    b.HasKey("Credentialscredentialid", "historyid");

                    b.HasIndex("historyid");

                    b.ToTable("CredentialHistory");
                });

            modelBuilder.Entity("CredentialUser", b =>
                {
                    b.Property<int>("credentialid")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("credentialid", "userid");

                    b.HasIndex("userid");

                    b.ToTable("CredentialUser");
                });

            modelBuilder.Entity("CredentialWebsite", b =>
                {
                    b.Property<int>("credentialscredentialid")
                        .HasColumnType("int");

                    b.Property<int>("websiteswebsiteid")
                        .HasColumnType("int");

                    b.HasKey("credentialscredentialid", "websiteswebsiteid");

                    b.HasIndex("websiteswebsiteid");

                    b.ToTable("CredentialWebsite");
                });

            modelBuilder.Entity("HistoryUser", b =>
                {
                    b.Property<int>("historyid")
                        .HasColumnType("int");

                    b.Property<int>("usersuserid")
                        .HasColumnType("int");

                    b.HasKey("historyid", "usersuserid");

                    b.HasIndex("usersuserid");

                    b.ToTable("HistoryUser");
                });

            modelBuilder.Entity("HistoryWebsite", b =>
                {
                    b.Property<int>("historyid")
                        .HasColumnType("int");

                    b.Property<int>("websiteswebsiteid")
                        .HasColumnType("int");

                    b.HasKey("historyid", "websiteswebsiteid");

                    b.HasIndex("websiteswebsiteid");

                    b.ToTable("HistoryWebsite");
                });

            modelBuilder.Entity("PasswordAutoFill.Modules.Credential", b =>
                {
                    b.Property<int>("credentialid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("credentialid"), 1L, 1);

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("websiteid")
                        .HasColumnType("int");

                    b.HasKey("credentialid");

                    b.ToTable("credentials");
                });

            modelBuilder.Entity("PasswordAutoFill.Modules.History", b =>
                {
                    b.Property<int>("historyid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("historyid"), 1L, 1);

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("datetime2");

                    b.Property<int>("credentialid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.Property<int>("websiteid")
                        .HasColumnType("int");

                    b.HasKey("historyid");

                    b.ToTable("histories");
                });

            modelBuilder.Entity("PasswordAutoFill.Modules.User", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userid"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PasswordAutoFill.Modules.Website", b =>
                {
                    b.Property<int>("websiteid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("websiteid"), 1L, 1);

                    b.Property<string>("webAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("websiteid");

                    b.ToTable("websites");
                });

            modelBuilder.Entity("CredentialHistory", b =>
                {
                    b.HasOne("PasswordAutoFill.Modules.Credential", null)
                        .WithMany()
                        .HasForeignKey("Credentialscredentialid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PasswordAutoFill.Modules.History", null)
                        .WithMany()
                        .HasForeignKey("historyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CredentialUser", b =>
                {
                    b.HasOne("PasswordAutoFill.Modules.Credential", null)
                        .WithMany()
                        .HasForeignKey("credentialid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PasswordAutoFill.Modules.User", null)
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CredentialWebsite", b =>
                {
                    b.HasOne("PasswordAutoFill.Modules.Credential", null)
                        .WithMany()
                        .HasForeignKey("credentialscredentialid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PasswordAutoFill.Modules.Website", null)
                        .WithMany()
                        .HasForeignKey("websiteswebsiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoryUser", b =>
                {
                    b.HasOne("PasswordAutoFill.Modules.History", null)
                        .WithMany()
                        .HasForeignKey("historyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PasswordAutoFill.Modules.User", null)
                        .WithMany()
                        .HasForeignKey("usersuserid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoryWebsite", b =>
                {
                    b.HasOne("PasswordAutoFill.Modules.History", null)
                        .WithMany()
                        .HasForeignKey("historyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PasswordAutoFill.Modules.Website", null)
                        .WithMany()
                        .HasForeignKey("websiteswebsiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
