﻿// <auto-generated />
using CQRSExample.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CQRSExample.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20201124194708_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("CQRSExample.Dto.CommentDto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<long>("PostId");

                    b.HasKey("Id");

                    b.ToTable("CommentDto");
                });
#pragma warning restore 612, 618
        }
    }
}
