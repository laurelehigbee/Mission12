﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission12.Models;

namespace Mission12.Migrations.TimeSlot
{
    [DbContext(typeof(TimeSlotContext))]
    [Migration("20220322195133_TimeSlot")]
    partial class TimeSlot
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("Mission12.Models.TimeSlot", b =>
                {
                    b.Property<int>("TimeSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeSlotId");

                    b.ToTable("Slots");

                    b.HasData(
                        new
                        {
                            TimeSlotId = 1,
                            Date = "2022-03-23",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 2,
                            Date = "2022-03-23",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 3,
                            Date = "2022-03-23",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 4,
                            Date = "2022-03-23",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 5,
                            Date = "2022-03-23",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 6,
                            Date = "2022-03-23",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 7,
                            Date = "2022-03-23",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 8,
                            Date = "2022-03-23",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 9,
                            Date = "2022-03-23",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 10,
                            Date = "2022-03-23",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 11,
                            Date = "2022-03-23",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 12,
                            Date = "2022-03-23",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 13,
                            Date = "2022-03-23",
                            Time = "8:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 14,
                            Date = "2022-03-24",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 15,
                            Date = "2022-03-24",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 16,
                            Date = "2022-03-24",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 17,
                            Date = "2022-03-24",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 18,
                            Date = "2022-03-24",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 19,
                            Date = "2022-03-24",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 20,
                            Date = "2022-03-24",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 21,
                            Date = "2022-03-24",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 22,
                            Date = "2022-03-24",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 23,
                            Date = "2022-03-24",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 24,
                            Date = "2022-03-24",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 25,
                            Date = "2022-03-24",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 26,
                            Date = "2022-03-24",
                            Time = "8:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 27,
                            Date = "2022-03-25",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 28,
                            Date = "2022-03-25",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 29,
                            Date = "2022-03-25",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 30,
                            Date = "2022-03-25",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 31,
                            Date = "2022-03-25",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 32,
                            Date = "2022-03-25",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 33,
                            Date = "2022-03-25",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 34,
                            Date = "2022-03-25",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 35,
                            Date = "2022-03-25",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 36,
                            Date = "2022-03-25",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 37,
                            Date = "2022-03-25",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 38,
                            Date = "2022-03-25",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 39,
                            Date = "2022-03-25",
                            Time = "8:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 40,
                            Date = "2022-03-26",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 41,
                            Date = "2022-03-26",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 42,
                            Date = "2022-03-26",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 43,
                            Date = "2022-03-26",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 44,
                            Date = "2022-03-26",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 45,
                            Date = "2022-03-26",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 46,
                            Date = "2022-03-26",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 47,
                            Date = "2022-03-26",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 48,
                            Date = "2022-03-26",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 49,
                            Date = "2022-03-26",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 50,
                            Date = "2022-03-26",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 51,
                            Date = "2022-03-26",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 52,
                            Date = "2022-03-26",
                            Time = "8:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 53,
                            Date = "2022-03-27",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 54,
                            Date = "2022-03-27",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 55,
                            Date = "2022-03-27",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 56,
                            Date = "2022-03-27",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 57,
                            Date = "2022-03-27",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 58,
                            Date = "2022-03-27",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 59,
                            Date = "2022-03-27",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 60,
                            Date = "2022-03-27",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 61,
                            Date = "2022-03-27",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 62,
                            Date = "2022-03-27",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 63,
                            Date = "2022-03-27",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 64,
                            Date = "2022-03-27",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 65,
                            Date = "2022-03-27",
                            Time = "8:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 66,
                            Date = "2022-03-28",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 67,
                            Date = "2022-03-28",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 68,
                            Date = "2022-03-28",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 69,
                            Date = "2022-03-28",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 70,
                            Date = "2022-03-28",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 71,
                            Date = "2022-03-28",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 72,
                            Date = "2022-03-28",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 73,
                            Date = "2022-03-28",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 74,
                            Date = "2022-03-28",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 75,
                            Date = "2022-03-28",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 76,
                            Date = "2022-03-28",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 77,
                            Date = "2022-03-28",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 78,
                            Date = "2022-03-28",
                            Time = "8:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 79,
                            Date = "2022-03-29",
                            Time = "8:00 am"
                        },
                        new
                        {
                            TimeSlotId = 80,
                            Date = "2022-03-29",
                            Time = "9:00 am"
                        },
                        new
                        {
                            TimeSlotId = 81,
                            Date = "2022-03-29",
                            Time = "10:00 am"
                        },
                        new
                        {
                            TimeSlotId = 82,
                            Date = "2022-03-29",
                            Time = "11:00 am"
                        },
                        new
                        {
                            TimeSlotId = 83,
                            Date = "2022-03-29",
                            Time = "12:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 84,
                            Date = "2022-03-29",
                            Time = "1:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 85,
                            Date = "2022-03-29",
                            Time = "2:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 86,
                            Date = "2022-03-29",
                            Time = "3:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 87,
                            Date = "2022-03-29",
                            Time = "4:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 88,
                            Date = "2022-03-29",
                            Time = "5:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 89,
                            Date = "2022-03-29",
                            Time = "6:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 90,
                            Date = "2022-03-29",
                            Time = "7:00 pm"
                        },
                        new
                        {
                            TimeSlotId = 91,
                            Date = "2022-03-29",
                            Time = "8:00 pm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
