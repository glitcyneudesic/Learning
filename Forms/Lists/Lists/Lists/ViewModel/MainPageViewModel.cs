using Lists.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.ViewModel
{
    public class MainPageViewModel
    {
        public string FullName { get; set; }
        public string Company { get; set; }
        public List<Person> Employees
        {
            get
            {
                return new List<Person>()
                {
                new Person(){ FirstName="Gi",Company="C1"},
                new Person() { FirstName = "Gi", Company = "C1" },
                new Person() { FirstName = "Gi", Company = "C1" },
                new Person() { FirstName = "Gi", Company = "C1" },
                new Person() { FirstName = "Gi", Company = "C1" },
                new Person() { FirstName = "Gi", Company = "C1" }
                 };


            }
        }
    }
}
