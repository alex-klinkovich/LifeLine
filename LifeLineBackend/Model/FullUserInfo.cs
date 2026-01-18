using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FullUserInfo : User
    {
        private string email;
        private string address;
        private string phoneNumber;
        private string gender;
        
        private City city;
        private int cityId;

        public string Email { get =>  email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Gender { get => gender; set => gender = value; }
        
        public City City { get => city; set => city = value; }

        public int CityId { get => cityId; set => cityId = value; }
         
    }
}
