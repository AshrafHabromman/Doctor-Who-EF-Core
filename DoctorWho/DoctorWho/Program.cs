// See https://aka.ms/new-console-template for more information
using DoctorWho;
using DoctorWho.DB;
using DoctorWho.DB.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

//DoctorWhoCoreDBContext context = new DoctorWhoCoreDBContext();




using (var context = new DoctorWhoCoreDBContext())
{
    var allAuthors = context.Authors.ToList();
    foreach (var auth in allAuthors)
    {

        Console.WriteLine(auth.Name);
    }
    //Console.Write(allAuthors);
}
