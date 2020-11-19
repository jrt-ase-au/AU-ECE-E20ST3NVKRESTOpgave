﻿// <auto-generated />
using System;
using HL7FHIRClient.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HL7FHIRClient.Migrations
{
    [DbContext(typeof(LocalCacheDBContext))]
    partial class LocalCacheDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HL7FHIRClient.Model.BPMCompleteSequence", b =>
                {
                    b.Property<long>("BPMCompleteSequenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BPMCounts")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DurationInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameOfObject")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("BPMCompleteSequenceId");

                    b.ToTable("BPMCompleteSequences");
                });

            modelBuilder.Entity("HL7FHIRClient.Model.BPMLocalSampleSequence", b =>
                {
                    b.Property<long>("BPMLocalSampleSequenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("BPMCompleteSequenceId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("BPMSamples")
                        .HasColumnType("BLOB");

                    b.Property<long>("NoBPMValues")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SequenceNo")
                        .HasColumnType("INTEGER");

                    b.HasKey("BPMLocalSampleSequenceId");

                    b.HasIndex("BPMCompleteSequenceId");

                    b.ToTable("BPMLocalSampleSequences");
                });

            modelBuilder.Entity("HL7FHIRClient.Model.BPMLocalSampleSequence", b =>
                {
                    b.HasOne("HL7FHIRClient.Model.BPMCompleteSequence", null)
                        .WithMany("SequenceOfBPMSamples")
                        .HasForeignKey("BPMCompleteSequenceId");
                });

            modelBuilder.Entity("HL7FHIRClient.Model.BPMCompleteSequence", b =>
                {
                    b.Navigation("SequenceOfBPMSamples");
                });
#pragma warning restore 612, 618
        }
    }
}