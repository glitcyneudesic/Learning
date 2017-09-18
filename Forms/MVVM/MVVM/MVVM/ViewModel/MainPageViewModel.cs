using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Model;

namespace MVVM.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel(Person person )
        {
            FullName = person.FirstName + "   " + person.LastName;
            Email = person.Email;
            Phone = person.Phone;
            Age = ComputeAge(person.Birthday);
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        private int ComputeAge(DateTime Birthday)
        {
            return 21;
        }

        public static Person GetPerson()
        {
            var person = new Person();
            person.FirstName = "Glitcy";
                person.Email = "Glitcy@gmail.com";
            person.LastName = "MAry";
            person.Phone = "0484-2705907";
            person.Id = 123;
            person.Birthday = new DateTime(1985, 7, 30);
            return person;
        }
    }
}
