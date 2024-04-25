

using System.Security.Cryptography;
using System.Text;

namespace UserAuthEmployee
{
    public class User
    {
        string password;
        int id;
        public int Id
        {
            get { return id; }
        }
        public string Name { get; set; }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 5)
                {
                    throw new Exception("Password length must be greater than 5");
                }
                else
                {
                    password = Program.encodeString(value);
                }
            }
        }





        public User(string name, string password)
        {

            Name = name;
            Password = password;
        }
    }
}
