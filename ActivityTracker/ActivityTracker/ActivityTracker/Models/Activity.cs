using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ActivityTracker.Models
{
    [Table("Activity")]
    public class Activity
    {
        [PrimaryKey,AutoIncrement]
        public int ActivityID { get; set; }
        [MaxLength(50),Unique]
        public string ActivityName { get; set; }
        public string ActivityDesc { get; set; }
        public bool ActivityStatus = false;
        public DateTime ActivityDateAdded = DateTime.Now;
        public DateTime ActivityDateCompleted { get; set; }
        
        
    }
}
