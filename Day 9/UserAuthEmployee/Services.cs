
using System.ComponentModel.Design;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace UserAuthEmployee
{
    public class Services
    {
        private string connection;
        public Services(IConfiguration Iconfig)
        {
            connection = Iconfig.GetConnectionString("Default");
        }

        public int CreateUser(User u)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                //User is a reserved keyword in SQL server so by enclosing it in [] brakets it is treated as identifier rather than a keyword
                SqlCommand cmd = new SqlCommand("Insert  into [User] (Name,Password) values (@name,@password)", con);
                cmd.Parameters.AddWithValue("@name", u.Name);
                cmd.Parameters.AddWithValue("@password", u.Password);
                con.Open();
                int record = cmd.ExecuteNonQuery();
                return record;
            }
        }

        public bool Validate(User u)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                //User is a reserved keyword in SQL server so by enclosing it in [] brakets it is treated as identifier rather than a keyword
                SqlCommand cmd = new SqlCommand("Select * from [User] where Name=@name and Password=@password", con);
                cmd.Parameters.AddWithValue("@name", u.Name);
                cmd.Parameters.AddWithValue("@password", u.Password);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Invalid Credentials");
                }
            }
        }

        public List<Employee> getEmployees()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("Select * from Employee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                var list = new List<Employee>();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        list.Add(new Employee()
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString(),
                            Salary = Convert.ToSingle(rdr["Salary"]),
                            Gender = rdr["Gender"].ToString()
                        });
                    }
                }
                return list;
            }
        }
    }


}
