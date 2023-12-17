using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Academy_Space_Booking_System.Models
{
	public class Booking
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime B_date { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FinishTime { get; set; }

        [ForeignKey("Spaces")]
        public int? SId { get; set; }
        public Space Spaces { get; set; }

        [ForeignKey("Clients")]
        public int? CId { get; set; }
        public Client Clients { get; set; }



    }
}

