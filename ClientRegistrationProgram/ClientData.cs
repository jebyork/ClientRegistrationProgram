using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistrationProgram
{
    public enum Products {
        Software,
        Computers,
        Games,
        OfficeTools,
        Accessories
    }

    public class ClientData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Software { get; set; }
        public bool Computers { get; set; }
        public bool Games { get; set; }
        public bool OfficeTools { get; set; }
        public bool Accessories { get; set; }

        public ClientData() { }

        public void SetID(int id) 
        { 
            ID = id;
        }
                
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }

        public void SetPhoneNumber(string phone)
        {
            PhoneNumber = phone;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
