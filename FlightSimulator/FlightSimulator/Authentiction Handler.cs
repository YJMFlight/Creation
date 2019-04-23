using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightSimulator
{
    class Authentiction_Handler
    {
        public List<Users> GetUsers(string path)
        {
            List<Users> users = new List<Users>();
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] list = line.Split(',');
                users.Add(new Users(list[0], list[1]));
                line = reader.ReadLine();
            }
            return users;
        }


        public void WriteUsers(Users users, string path)
        {
            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("{0},{1}",  users.UserName, users.Password);
            writer.Close();
            file.Close();
        }
    }
}

