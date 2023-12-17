using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Academy_Space_Booking_System.Models
{
	public class Space
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int S_id { get; set; }

        [Required]
        public string S_name { get; set; }

        [Required]
        public string availability_Status { get; set; }


        public ICollection<Booking> SpaceBooking { get; set; } = new List<Booking>();

    }
}

