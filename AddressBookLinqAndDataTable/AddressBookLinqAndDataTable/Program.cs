using System;
using System.Data;

namespace AddressBookLinqAndDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To AddressBook Linq And DataTable************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.createAddressBookTable();
            /* Contact contact = new Contact();
             Console.WriteLine("Enter First Name For editing :");
             string firstname = Console.ReadLine();
             Console.WriteLine("Enter the first name = ");
             contact.FirstName = Console.ReadLine();
             Console.WriteLine("Enter the last name = ");
             contact.LastName = Console.ReadLine();
             Console.WriteLine("Enter the address = ");
             contact.Address = Console.ReadLine();
             Console.WriteLine("Enter the city = ");
             contact.City = Console.ReadLine();
             Console.WriteLine("Enter the state = ");
             contact.State = Console.ReadLine();
             Console.WriteLine("Enter the zip code = ");
             contact.ZipCode = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the phone number = ");
             contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
             Console.WriteLine("Enter the email = ");
             contact.Email = Console.ReadLine();*/
            //addressBookDataTable.displayAddressBook();

            //addressBookDataTable.editContact(table);

            /* Contact contact = new Contact();

             Console.WriteLine("Enter the first name = ");
             contact.FirstName = Console.ReadLine();
             addressBookDataTable.deleteParticularContact(contact);*/

            /*Contact contact = new Contact();
            Console.WriteLine("Enter the City  ");
            contact.City = Console.ReadLine();
            addressBookDataTable.retrieveContactByCity(contact);
*/
            /* Console.WriteLine("Enter the State ");
             contact.State = Console.ReadLine();
             addressBookDataTable.retrieveContactByState(contact);*/

            /*Contact contact = new Contact();
            Console.WriteLine("Enter the City ");
            contact.City = Console.ReadLine();*/
            //addressBookDataTable.sortContactByGivenCity(contact);

            addressBookDataTable.getCountByAddressBookType();
        }
    }
}
