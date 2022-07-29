using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDatatable
{

    class Student
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }


        public override string ToString()
        {
            return string.Format("Customer Information:\nCustomerID: {0}\nCompanyName: {1}\n,ContactName: {2}\nContactTitle: {3}\nAddress: {4}\nCity: {5}\nRegion: {6}\nPostalCode: {7}\nCountry: {8}\nPhone: {9}\nFax: {10}\n",CustomerID, CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax);
        }
       
    }
}
