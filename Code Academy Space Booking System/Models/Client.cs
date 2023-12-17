using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Academy_Space_Booking_System.Models
{
	public class Client
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int C_id { get; set; }

        [Required]
        public string C_Fname { get; set; }
        public string C_Lname { get; set; }

        [DataType(DataType.EmailAddress)]
        public string C_email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int C_Phone { get; set; }

        [DataType(DataType.Date)]
        public string C_DOB { get; set; }

       
        public ICollection<Booking> ClientBooking { get; set; } = new List<Booking>();
    }
}

