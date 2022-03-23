using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class TimeSlotContext : DbContext
    {

        public TimeSlotContext()
        {

        }
        public TimeSlotContext(DbContextOptions<TimeSlotContext> options) : base(options)
        {

        }

        public DbSet<TimeSlot> Slots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { TimeSlotId = 1, Date = "2022-03-23", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 2, Date = "2022-03-23", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 3, Date = "2022-03-23", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 4, Date = "2022-03-23", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 5, Date = "2022-03-23", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 6, Date = "2022-03-23", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 7, Date = "2022-03-23", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 8, Date = "2022-03-23", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 9, Date = "2022-03-23", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 10, Date = "2022-03-23", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 11, Date = "2022-03-23", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 12, Date = "2022-03-23", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 13, Date = "2022-03-23", Time = "8:00 pm" },

                new TimeSlot { TimeSlotId = 14, Date = "2022-03-24", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 15, Date = "2022-03-24", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 16, Date = "2022-03-24", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 17, Date = "2022-03-24", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 18, Date = "2022-03-24", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 19, Date = "2022-03-24", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 20, Date = "2022-03-24", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 21, Date = "2022-03-24", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 22, Date = "2022-03-24", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 23, Date = "2022-03-24", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 24, Date = "2022-03-24", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 25, Date = "2022-03-24", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 26, Date = "2022-03-24", Time = "8:00 pm" },
            
                new TimeSlot { TimeSlotId = 27, Date = "2022-03-25", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 28, Date = "2022-03-25", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 29, Date = "2022-03-25", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 30, Date = "2022-03-25", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 31, Date = "2022-03-25", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 32, Date = "2022-03-25", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 33, Date = "2022-03-25", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 34, Date = "2022-03-25", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 35, Date = "2022-03-25", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 36, Date = "2022-03-25", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 37, Date = "2022-03-25", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 38, Date = "2022-03-25", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 39, Date = "2022-03-25", Time = "8:00 pm" },

                new TimeSlot { TimeSlotId = 40, Date = "2022-03-26", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 41, Date = "2022-03-26", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 42, Date = "2022-03-26", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 43, Date = "2022-03-26", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 44, Date = "2022-03-26", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 45, Date = "2022-03-26", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 46, Date = "2022-03-26", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 47, Date = "2022-03-26", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 48, Date = "2022-03-26", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 49, Date = "2022-03-26", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 50, Date = "2022-03-26", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 51, Date = "2022-03-26", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 52, Date = "2022-03-26", Time = "8:00 pm" },

                new TimeSlot { TimeSlotId = 53, Date = "2022-03-27", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 54, Date = "2022-03-27", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 55, Date = "2022-03-27", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 56, Date = "2022-03-27", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 57, Date = "2022-03-27", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 58, Date = "2022-03-27", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 59, Date = "2022-03-27", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 60, Date = "2022-03-27", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 61, Date = "2022-03-27", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 62, Date = "2022-03-27", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 63, Date = "2022-03-27", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 64, Date = "2022-03-27", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 65, Date = "2022-03-27", Time = "8:00 pm" },

                new TimeSlot { TimeSlotId = 66, Date = "2022-03-28", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 67, Date = "2022-03-28", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 68, Date = "2022-03-28", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 69, Date = "2022-03-28", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 70, Date = "2022-03-28", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 71, Date = "2022-03-28", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 72, Date = "2022-03-28", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 73, Date = "2022-03-28", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 74, Date = "2022-03-28", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 75, Date = "2022-03-28", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 76, Date = "2022-03-28", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 77, Date = "2022-03-28", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 78, Date = "2022-03-28", Time = "8:00 pm" },

                new TimeSlot { TimeSlotId = 79, Date = "2022-03-29", Time = "8:00 am" },
                new TimeSlot { TimeSlotId = 80, Date = "2022-03-29", Time = "9:00 am" },
                new TimeSlot { TimeSlotId = 81, Date = "2022-03-29", Time = "10:00 am" },
                new TimeSlot { TimeSlotId = 82, Date = "2022-03-29", Time = "11:00 am" },
                new TimeSlot { TimeSlotId = 83, Date = "2022-03-29", Time = "12:00 pm" },
                new TimeSlot { TimeSlotId = 84, Date = "2022-03-29", Time = "1:00 pm" },
                new TimeSlot { TimeSlotId = 85, Date = "2022-03-29", Time = "2:00 pm" },
                new TimeSlot { TimeSlotId = 86, Date = "2022-03-29", Time = "3:00 pm" },
                new TimeSlot { TimeSlotId = 87, Date = "2022-03-29", Time = "4:00 pm" },
                new TimeSlot { TimeSlotId = 88, Date = "2022-03-29", Time = "5:00 pm" },
                new TimeSlot { TimeSlotId = 89, Date = "2022-03-29", Time = "6:00 pm" },
                new TimeSlot { TimeSlotId = 90, Date = "2022-03-29", Time = "7:00 pm" },
                new TimeSlot { TimeSlotId = 91, Date = "2022-03-29", Time = "8:00 pm" }
            
                );
        }
    }
}
