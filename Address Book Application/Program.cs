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
        foreach (Contact contact in AddressBookList)
        {
            Console.WriteLine(contact);
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

        Contact NewContact = new Contact(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        AddressBookList.Add(NewContact);
        Console.WriteLine(NewContact);
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
    string FirstName { get; set; }
    string LastName { get; set; }
    string Address{ get; set; }
}
// Show List Of Address Book