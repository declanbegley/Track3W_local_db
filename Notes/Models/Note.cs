using System;
using SQLite;

namespace Notes.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string AssetID { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
