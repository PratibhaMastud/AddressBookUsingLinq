﻿using System;

namespace AddressBookLinqAndDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To AddressBook Linq And DataTable************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            addressBookDataTable.createAddressBookTable();
        }
    }
}
