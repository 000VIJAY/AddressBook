﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressInformation;

namespace AddressInformation
{
    public class PersonAddress
    {

        public List<Contact> persons = new List<Contact>();

        public void Book(Contact con)
        {

            persons.Add(new Contact() { FirstName = "Vijay", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 8000001, PhoneNumber = 87654321287, Email = "vijya87348@gmail.com", });
            persons.Add(new Contact() { FirstName = "Nitish", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 800005, PhoneNumber = 654321287, Email = "vijya87348@gmail.com", });
            persons.Add(new Contact() { FirstName = "Rahul ", LastName = "Yadav", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 43523254234, Email = "rahul@gmail.com" });
            persons.Add(new Contact() { FirstName = "Rohal ", LastName = "Goyal", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 76523254234, Email = "rohan@gmail.com" });
        }
        public void Show()
        {
            Console.WriteLine("Enter Firstname");
            string? FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string? LastName = Console.ReadLine();
            Console.WriteLine("Enter City");
            string? City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string? State = Console.ReadLine();
            Console.WriteLine("Enter zip Number");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            string? Email = Console.ReadLine();
            persons.Add(new Contact()
            {
                FirstName = FirstName,
                LastName = LastName,
                City = City,
                State = State,
                Zip = Zip,
                PhoneNumber = PhoneNumber,
                Email = Email,
            });
            foreach (var Contact in persons)
            {
                Console.WriteLine("Your name is :{0} ", Contact.FirstName + " " + Contact.LastName);
                Console.WriteLine("Your City: {0}", Contact.City);
                Console.WriteLine("Your State: {0}", Contact.State);
                Console.WriteLine("Your Zip:{0}", Contact.Zip);
                Console.WriteLine("Your PhoneNumber: {0}", Contact.PhoneNumber);
                Console.WriteLine("Email: {0}", Contact.Email);
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("total count of List ,it will start with zero: {0} ", persons.Count);       //for reference of user if want to delete then here total count will provided
            Console.WriteLine("enter the first name whose details want to delete");
            int i = Convert.ToInt32(Console.ReadLine());
            persons.Remove(persons[i]);
            foreach (var Contact in persons)
            {
                Console.WriteLine("Your name is :{0} ", Contact.FirstName + " " + Contact.LastName);
                Console.WriteLine("Your City: {0}", Contact.City);
                Console.WriteLine("Your State: {0}", Contact.State);
                Console.WriteLine("Your Zip:{0}", Contact.Zip);
                Console.WriteLine("Your PhoneNumber: {0}", Contact.PhoneNumber);
                Console.WriteLine("Email: {0}", Contact.Email);
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}