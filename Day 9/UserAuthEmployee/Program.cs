// Q1.create table user with id name password.
// Create poco class user with column Id, name,Password
// Store id name password in database.
// When you load application print message welcome to crimson
// Enter:
// Name:
// Password:
// Validate the user ie check if user name is there in table or not if yes display employee details.
// For this you need to have employee table having detail id name salary gender.
// Create poco class Employee with id name salary gender.
// Use connected architecture
// Use store procedure.


using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace UserAuthEmployee
{

    class Program
    {
        public static IConfiguration Iconfig;
        static string name;
        static string password;
        public static void buildConfiguration()
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            Iconfig = build;
        }

        static void getEmployeeDetails()
        {
            try
            {
                Services serv = new Services(Iconfig);
                User u = new User(name, password);

                bool isAuth = serv.Validate(u);
                if (isAuth)
                {
                    System.Console.WriteLine("********************Employee Details*************************");
                    var emp = serv.getEmployees();
                    foreach (var item in emp)
                    {
                        System.Console.WriteLine($"Id:{item.Id} Name:{item.Name} Salary:{item.Salary} Gender:{item.Gender}");
                    }
                }
            }
            catch (Exception ex) { System.Console.WriteLine(ex.Message); }
        }
        static void CreateUser()
        {
            User u = new User(name, password);
            try
            {
                Services serv = new Services(Iconfig);
                int res = serv.CreateUser(u);
                System.Console.WriteLine($"Affected Rows {res}");
            }
            catch (Exception ex) { System.Console.WriteLine(ex.Message); }
        }
        static void Main(string[] args)
        {
            buildConfiguration();

            System.Console.WriteLine("1.Signup");
            System.Console.WriteLine("2.Login");
            System.Console.Write("Enter Choice: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    System.Console.Write("Enter Name : ");
                    name = Console.ReadLine();
                    System.Console.Write("Enter Password: ");
                    password = Console.ReadLine();
                    CreateUser();
                    break;
                case 2:
                    System.Console.Write("Enter Name : ");
                    name = Console.ReadLine();
                    System.Console.Write("Enter Password: ");
                    password = Console.ReadLine();
                    
                    getEmployeeDetails();
                    break;
                default:
                    System.Console.WriteLine("Invalid Number");
                    break;
            }
        }
        static Program()
        {
            System.Console.WriteLine("Welcome to Crimson");
        }

        //For Encoding Password
        public static string encodeString(string data)
        {
            string answer = "";
            string publicKey = "ENCR1234";
            string privateKey = "DECR4321";
            byte[] privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] inputByteArray = Encoding.UTF8.GetBytes(data);
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream,
                provider.CreateEncryptor(publicKeyBytes, privateKeyBytes),
                CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                answer = Convert.ToBase64String(memoryStream.ToArray());
            }
            return answer;
        }

    }

}