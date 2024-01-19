using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Icon { get; set; }="";
        [Column(TypeName = "varchar(10)")]
        public string Type { get; set; }="Expense";
        
    }
}