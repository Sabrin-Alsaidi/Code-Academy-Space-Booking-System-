using Code_Academy_Space_Booking_System.Models;
using Code_Academy_Space_Booking_System.MyDbContext;

namespace Code_Academy_Space_Booking_System;
class Program
{
    static void Main(string[] args)
    {
        //Add Client to the DB 
        using ApplicationDbContext db = new ApplicationDbContext();
        Client Client1 = new Client() { C_Fname="Sabrin" , C_Lname="Al-Saidi" , C_email="sss@gmail.com"  , C_Phone=99999999 , C_DOB="13/10/1995"};
        db.Clients.Add(Client1);
        db.SaveChanges();
        Client Client2 = new Client() { C_Fname = "Salma", C_Lname = "Al-Saidi", C_email = "aaa@gmail.com", C_Phone = 99123456, C_DOB = "13/10/1995" };
        db.Clients.Add(Client2);
        db.SaveChanges();
        Client Client3 = new Client() { C_Fname = "Saba", C_Lname = "Al-Saidi", C_email = "bbbbb@gmail.com", C_Phone = 99888888, C_DOB = "13/10/1995" };
        db.Clients.Add(Client3);
        db.SaveChanges();
        //Add Spaces to the DB 
        Space space1 = new Space() { S_name = "Creativity room", availability_Status = "Available" };
        db.Spaces.Add(space1);
        db.SaveChanges();
        Space space2 = new Space() { S_name = "artistry room", availability_Status = "Available" };
        db.Spaces.Add(space2);
        db.SaveChanges();

        //View Spaces from DB
        //    using ApplicationDbContext _db = new ApplicationDbContext();
        //    var sp = (from S in _db.Spaces
        //              select S).ToList();
        //    Console.WriteLine(sp);

        //View Booking from DB
        //    using ApplicationDbContext _db2 = new ApplicationDbContext();
        //    var booking = (from B in _db2.Bookings
        //              select B).ToList();
        //    Console.WriteLine(booking);

    }
}

