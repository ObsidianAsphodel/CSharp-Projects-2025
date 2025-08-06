using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace AddressBook;

class Program
{
    bool ExitApplication = false;
    List<Contact> AddresBook = new List<Contact>();
    string ownerName = "";

    public static void Main(string[] args)
    {
        Console.WriteLine("Good Evening! Here are your current contacts");
        ViewContacts();
    }

    public static void ViewContacts()
    {

    }
    public static void AddContacts()
    {

    }
    public static void EditContact(Contact contact, int id)
    {
        
    }
    public static void DeleteContacts()
    {

    }
    public static void Exit()
    {
        Console.Clear();
    }
}
class Contact
{
    public static string Name = "";
    public static string Address = ""; 
}
// Show List Of Address Book