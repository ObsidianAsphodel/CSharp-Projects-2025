using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace AddressBook;

class Program
{
    static List<Contact> AddressBookList = new List<Contact>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Good Evening! Here are your current contacts");
        ViewContacts();
    }

    public static void ViewContacts()
    {
        Console.WriteLine("View Contacts");

       if (AddressBookList.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            for (int i = 0; i < AddressBookList.Count; i++)
            {
                Console.WriteLine("{0}. Name: {1} {2} Address: {3}", i + 1, AddressBookList[i].FirstName, AddressBookList[i].LastName, AddressBookList[i].Address);
            }
        }

        Console.WriteLine("Please choice an option below:");
        Console.WriteLine("1. View Contacts");
        Console.WriteLine("2. Add Contacts");
        Console.WriteLine("3. Edit Contacts");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Exit");

        MenuChoice();
        static void MenuChoice()
        {
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    ViewContacts();
                    break;
                case 2:
                    AddContacts();
                    break;
                case 3:
                    EditContact();
                    break;
                case 4:
                    DeleteContacts();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Try Another Choice");
                    ViewContacts();
                    break;
            }
        }  
    }
    public static void AddContacts()
    {
        Console.WriteLine("Add Contacts");
        Console.WriteLine("Enter a new contact:");

        Console.Write("First Name: ");
        string? first = Console.ReadLine();

        Console.Write("Last Name: ");
        string? last = Console.ReadLine();

        Console.Write("Address: ");
        string? address = Console.ReadLine();

        AddressBookList.Add(new Contact(first, last, address));

        Console.WriteLine("New Contact Entered");

        Console.WriteLine("Please choice an option below:");
        Console.WriteLine("1. View Contacts");
        Console.WriteLine("2. Add Contacts");
        Console.WriteLine("3. Edit Contacts");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Exit");

        MenuChoice();
        static void MenuChoice()
        {
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    ViewContacts();
                    break;
                case 2:
                    AddContacts();
                    break;
                case 3:
                    EditContact();
                    break;
                case 4:
                    DeleteContacts();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Try Another Choice");
                    ViewContacts();
                    break;
            }
        }
    }
    public static void EditContact()
    {
        Console.WriteLine("Edit Contacts");
        if (AddressBookList.Count == 0)
        {
            Console.WriteLine("No Contacts found");

        }
        else
        {
            Console.WriteLine("Please choose a contact: ");
            for (int i = 0; i < AddressBookList.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2} {3}", i + 1, AddressBookList[i].FirstName, AddressBookList[i].LastName, AddressBookList[i].Address);
            }
            int.TryParse(Console.ReadLine(), out int choice);
        }

        Console.WriteLine("Please choice an option below:");
        Console.WriteLine("1. View Contacts");
        Console.WriteLine("2. Add Contacts");
        Console.WriteLine("3. Edit Contacts");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Exit");

        MenuChoice();
        static void MenuChoice()
        {
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    ViewContacts();
                    break;
                case 2:
                    AddContacts();
                    break;
                case 3:
                    EditContact();
                    break;
                case 4:
                    DeleteContacts();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Try Another Choice");
                    ViewContacts();
                    break;
            }
        }
    }
    public static void DeleteContacts()
    {
        Console.WriteLine("Delete Contacts");

        Console.WriteLine("Please choice an option below:");
        Console.WriteLine("1. View Contacts");
        Console.WriteLine("2. Add Contacts");
        Console.WriteLine("3. Edit Contacts");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Exit");

        MenuChoice();
        static void MenuChoice()
        {
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    ViewContacts();
                    break;
                case 2:
                    AddContacts();
                    break;
                case 3:
                    EditContact();
                    break;
                case 4:
                    DeleteContacts();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Try Another Choice");
                    ViewContacts();
                    break;
            }
        }
    }
    public static void Exit()
    {
        Console.WriteLine("Exiting");
        Console.Clear();
    }
}
public class Contact
{
    public Contact(string first, string last, string address)
    {
        FirstName = first;
        LastName = last;
        Address = address;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address{ get; set; }
}
// Show List Of Address Book