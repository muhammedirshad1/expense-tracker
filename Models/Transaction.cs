using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid CategoryId { get; set; }
        public int Amount { get; set; }
        [Column()]
        public string Notes { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Category Category { get; set; }
    }
}