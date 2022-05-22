using System;
namespace Dnevnik.Data.Models
{
    public class Calendar
    {
        public int id { get; set; }

        public int semesterId { get; set; }

        public int lessonId { get; set; }

        public int weekId { get; set; }

        public DateTime lessonTime { get; set; }

    }
}
