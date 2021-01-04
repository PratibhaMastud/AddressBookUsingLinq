using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinqAndDataTable
{
    public class AddressBookDataTable
    {
        private readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// Create the Address Book table and add attributes.
        /// </summary>
        public void createAddressBookTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(int));
            dataTable.Columns.Add("Email", typeof(string));
        }
    }
}
