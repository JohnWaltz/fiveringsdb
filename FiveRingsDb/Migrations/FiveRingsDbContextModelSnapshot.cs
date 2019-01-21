﻿// <auto-generated />
using System;
using System.Collections.Generic;
using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FiveRingsDb.Migrations
{
    [DbContext(typeof(FiveRingsDbContext))]
    partial class FiveRingsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FiveRingsDb.Models.Card", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Clan");

                    b.Property<int>("DeckLimit");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsRestricted");

                    b.Property<bool>("IsUnique");

                    b.Property<string>("Name");

                    b.Property<string>("NameCanonical");

                    b.Property<int?>("RoleRestriction");

                    b.Property<int>("Side");

                    b.Property<string>("Text");

                    b.Property<string>("TextCanonical");

                    b.Property<List<Trait>>("Traits");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Card");
                });

            modelBuilder.Entity("FiveRingsDb.Models.PrintedCard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardId");

                    b.Property<string>("Illustrator");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("Pack");

                    b.Property<string>("Position");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("PrintedCards");
                });

            modelBuilder.Entity("FiveRingsDb.Models.AttachmentCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int>("Cost");

                    b.Property<int?>("InfluenceCost");

                    b.Property<string>("MilitaryBonus");

                    b.Property<string>("PoliticalBonus");

                    b.ToTable("AttachmentCard");

                    b.HasDiscriminator().HasValue("AttachmentCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.CharacterCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int>("Cost")
                        .HasColumnName("CharacterCard_Cost");

                    b.Property<int>("Glory");

                    b.Property<int?>("InfluenceCost")
                        .HasColumnName("CharacterCard_InfluenceCost");

                    b.Property<string>("Military");

                    b.Property<string>("Political");

                    b.ToTable("CharacterCard");

                    b.HasDiscriminator().HasValue("CharacterCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.EventCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int>("Cost")
                        .HasColumnName("EventCard_Cost");

                    b.Property<int?>("InfluenceCost")
                        .HasColumnName("EventCard_InfluenceCost");

                    b.ToTable("EventCard");

                    b.HasDiscriminator().HasValue("EventCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.HoldingCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<string>("StrengthBonus");

                    b.ToTable("HoldingCard");

                    b.HasDiscriminator().HasValue("HoldingCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.ProvinceCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int>("Element");

                    b.Property<string>("Strength");

                    b.ToTable("ProvinceCard");

                    b.HasDiscriminator().HasValue("ProvinceCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.RoleCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");


                    b.ToTable("RoleCard");

                    b.HasDiscriminator().HasValue("RoleCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.StrongholdCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int>("Fate");

                    b.Property<int>("Honor");

                    b.Property<int>("InfluencePool");

                    b.Property<string>("StrengthBonus")
                        .HasColumnName("StrongholdCard_StrengthBonus");

                    b.ToTable("StrongholdCard");

                    b.HasDiscriminator().HasValue("StrongholdCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.PrintedCard", b =>
                {
                    b.HasOne("FiveRingsDb.Models.Card")
                        .WithMany("PackCards")
                        .HasForeignKey("CardId");
                });
#pragma warning restore 612, 618
        }
    }
}
