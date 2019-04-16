using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class Users
    {
        private string userName;
        private string age;
        private string id;
        private string rank;
        private string surname;


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Age { get => age; set => age = value; }
        public string Id { get => id; set => id = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Surname { get => surname; set => surname = value; }

        public Users(string username, string ppassword , string id, string rank ,string surname , string age)
        {
            this.userName = username;
            this.password = ppassword;
            this.age = age;
            this.id = id;
            this.rank = rank;
            this.surname = surname;
        }
    }
}
