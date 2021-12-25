﻿// <auto-generated />
using System;
using MPlan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MPlan.Migrations
{
    [DbContext(typeof(MPlanContext))]
    partial class MPlanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MPlan.Models.ItemComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemsId");

                    b.HasIndex("OwnerUserId");

                    b.ToTable("DBIComments");
                });

            modelBuilder.Entity("MPlan.Models.ItemPoints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<int?>("VoterUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemsId");

                    b.HasIndex("VoterUserId");

                    b.ToTable("DBIPoints");
                });

            modelBuilder.Entity("MPlan.Models.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BelongsTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersUserId");

                    b.ToTable("DBItem");
                });

            modelBuilder.Entity("MPlan.Models.PlanComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerUserId")
                        .HasColumnType("int");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int?>("PlansId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerUserId");

                    b.HasIndex("PlansId");

                    b.ToTable("DBPComments");
                });

            modelBuilder.Entity("MPlan.Models.PlanPoints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int?>("PlansId")
                        .HasColumnType("int");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<int?>("VoterUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlansId");

                    b.HasIndex("VoterUserId");

                    b.ToTable("DBPPoints");
                });

            modelBuilder.Entity("MPlan.Models.Plans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPercent")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanType")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsageType")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemsId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("DBPlan");
                });

            modelBuilder.Entity("MPlan.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("DBUsers");
                });

            modelBuilder.Entity("MPlan.Models.ItemComments", b =>
                {
                    b.HasOne("MPlan.Models.Items", null)
                        .WithMany("Comment")
                        .HasForeignKey("ItemsId");

                    b.HasOne("MPlan.Models.Users", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerUserId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MPlan.Models.ItemPoints", b =>
                {
                    b.HasOne("MPlan.Models.Items", null)
                        .WithMany("Point")
                        .HasForeignKey("ItemsId");

                    b.HasOne("MPlan.Models.Users", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterUserId");

                    b.Navigation("Voter");
                });

            modelBuilder.Entity("MPlan.Models.Items", b =>
                {
                    b.HasOne("MPlan.Models.Users", null)
                        .WithMany("MyItems")
                        .HasForeignKey("UsersUserId");
                });

            modelBuilder.Entity("MPlan.Models.PlanComments", b =>
                {
                    b.HasOne("MPlan.Models.Users", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerUserId");

                    b.HasOne("MPlan.Models.Plans", null)
                        .WithMany("Comment")
                        .HasForeignKey("PlansId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MPlan.Models.PlanPoints", b =>
                {
                    b.HasOne("MPlan.Models.Plans", null)
                        .WithMany("Point")
                        .HasForeignKey("PlansId");

                    b.HasOne("MPlan.Models.Users", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterUserId");

                    b.Navigation("Voter");
                });

            modelBuilder.Entity("MPlan.Models.Plans", b =>
                {
                    b.HasOne("MPlan.Models.Items", null)
                        .WithMany("Plan")
                        .HasForeignKey("ItemsId");

                    b.HasOne("MPlan.Models.Users", null)
                        .WithMany("MyPlans")
                        .HasForeignKey("UsersUserId");
                });

            modelBuilder.Entity("MPlan.Models.Users", b =>
                {
                    b.HasOne("MPlan.Models.Users", null)
                        .WithMany("MyFriends")
                        .HasForeignKey("UsersUserId");
                });

            modelBuilder.Entity("MPlan.Models.Items", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Plan");

                    b.Navigation("Point");
                });

            modelBuilder.Entity("MPlan.Models.Plans", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Point");
                });

            modelBuilder.Entity("MPlan.Models.Users", b =>
                {
                    b.Navigation("MyFriends");

                    b.Navigation("MyItems");

                    b.Navigation("MyPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
