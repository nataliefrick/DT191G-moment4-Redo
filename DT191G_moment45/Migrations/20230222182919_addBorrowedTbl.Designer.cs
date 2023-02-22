﻿// <auto-generated />
using System;
using DT191G_moment45.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DT191G_moment45.Migrations
{
    [DbContext(typeof(CollectionContext))]
    [Migration("20230222182919_addBorrowedTbl")]
    partial class addBorrowedTbl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("DT191G_moment45.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Borrowed", b =>
                {
                    b.Property<int>("BorrowedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollectionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("FriendId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BorrowedId");

                    b.HasIndex("CollectionId");

                    b.HasIndex("FriendId");

                    b.ToTable("Borrowed");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlbumTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("SongList")
                        .HasColumnType("TEXT");

                    b.HasKey("CollectionId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Friends", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FriendId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Borrowed", b =>
                {
                    b.HasOne("DT191G_moment45.Models.Collection", "Collection")
                        .WithMany()
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DT191G_moment45.Models.Friends", "Friends")
                        .WithMany("Borrowed")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");

                    b.Navigation("Friends");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Collection", b =>
                {
                    b.HasOne("DT191G_moment45.Models.Artist", "Artist")
                        .WithMany("Collection")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Artist", b =>
                {
                    b.Navigation("Collection");
                });

            modelBuilder.Entity("DT191G_moment45.Models.Friends", b =>
                {
                    b.Navigation("Borrowed");
                });
#pragma warning restore 612, 618
        }
    }
}
