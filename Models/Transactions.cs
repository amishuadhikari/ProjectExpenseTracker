using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExpenseTracker_final
{
    [Table("transaction")]
    public class Transaction
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }
        
        [Column("amount")] // column for transaction amounts
        public decimal Amount { get; set; }

        [Column("type")]
        public string Type { get; set; }
        [Column("date")]
        public DateTime Date { get; set; } // Added date column
        [Column("note")] // Optional note for additional information
        public string Note { get; set; }
        [Column("Tags")] 
        public string Tags { get; set; }
    }
}