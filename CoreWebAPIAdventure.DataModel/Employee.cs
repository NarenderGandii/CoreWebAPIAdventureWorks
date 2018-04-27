using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebAPIAdventure.DataModel {
    public class Employee {
        public int BusinessEntityID { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public string OrganizationNode { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime HireDate { get; set; }
    }
}
