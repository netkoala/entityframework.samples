using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkSamples.Models
{
    class SerialNumber
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int SomethingCount { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
