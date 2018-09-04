using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedLab.Core.Models
{
    public partial class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int PatientId { get; set; }

        public int TestId { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public decimal PercentDiscount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [StringLength(128)]
        public string CreatedById { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual MedTest Test { get; set; }
    }
}
