using System.Security.Cryptography;
using Code_Academy_Space_Booking_System.Models;
using Code_Academy_Space_Booking_System.MyDbContext;

namespace Code_Academy_Space_Booking_System;
class Program
{
    static void Main(string[] args)
    {
        using ApplicationDbContext db = new ApplicationDbContext();
        ////Add Spaces to the DB 
        //Space space1 = new Space() { S_name = "Creativity room", availability_Status = "Available" };
        //db.Spaces.Add(space1);
        //db.SaveChanges();
        //Space space2 = new Space() { S_name = "artistry room", availability_Status = "Available" };
        //db.Spaces.Add(space2);
        //db.SaveChanges();

        //------------------------------------------------------------------------------
       
        Console.WriteLine("Welcome to Code Academy Space Booking System!!");

        //add Client to the DB
        Console.WriteLine("Enter your first name ");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter your lasr name ");
        string lname = Console.ReadLine();
        Console.WriteLine("Enter your email ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter your phone number");
        int phoneNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your date og birth");
        string dob = Console.ReadLine();
        Client client = new Client() { C_Fname = fname, C_Lname = lname, C_email = email, C_Phone = phoneNo, C_DOB =dob };
        db.Clients.Add(client);
        db.SaveChanges();
        Console.WriteLine("Thankd you for registrating!!");




        //View avialable Spaces from DB
        String status = "Available";
        Console.WriteLine("Here are all the Available Spaces that Code Academy has :");
        using ApplicationDbContext _db = new ApplicationDbContext();
        var sp = (from S in _db.Spaces
                  where S.availability_Status == status
                  select S).ToList();
        foreach (var item in sp)
        {
            Console.Write((item?.S_id ?? 0) + "  || ");
            Console.Write(item?.S_name + "  ||  " ?? "NA  ||  ");
            Console.WriteLine(item?.availability_Status ?? "NA");
            Console.WriteLine();
        }



        
        //Add new booking to the DB
        Console.WriteLine("Please Enter the Spase Id that you would like to book ");
        int sid = int.Parse(Console.ReadLine());
        Console.WriteLine("What date would you like to book the space ");
        DateTime bdate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("At what time would you like you booking start");
        DateTime bStartTime = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("At what time would you like you booking ends");
        DateTime bEndTime = DateTime.Parse(Console.ReadLine());
        Booking book = new Booking() { B_date = bdate, StartTime = bStartTime, FinishTime = bEndTime, SId = sid};
        db.Bookings.Add(book);
        db.SaveChanges();


        // update the Space status to booked 
        var spa = (from S in _db.Spaces
                  where S.availability_Status == status
                  select S).ToList();
        spa[0].availability_Status = "Booked";
        db.Spaces.Update(spa[0]);
        db.SaveChanges();
        Console.WriteLine("Thank you for booking a space in code academy. Excited to see you.");



        Console.WriteLine("Would you like to see all the booking list ? Yes/No");
        string choose = Console.ReadLine().ToLower();
        if (choose == "yes")
        {
            //View Booking from DB
            using ApplicationDbContext _db2 = new ApplicationDbContext();
            var booking = (from B in _db2.Bookings
                           select B).ToList();
            foreach (var item in booking)
            {
                Console.Write((item?.BookingNo ?? 0) + "  || ");
                Console.Write(item?.B_date + "  ||  " ?? "NA  ||  ");
                Console.Write(item?.StartTime + "  ||  " ?? "NA  ||  ");
                Console.Write(item?.FinishTime + "  ||  " ?? "NA  ||  ");
                Console.Write((item?.SId ?? 0) + "  || ");
                Console.Write((item?.CId ?? 0) + "  || ");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Thank you for using Code Academy Space Booking System.");
           // Break;
        }

    }
}

