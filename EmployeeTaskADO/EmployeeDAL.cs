using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskADO
{
    internal class EmployeeDAL
    {
        public string connection;
        public EmployeeDAL(IConfiguration Iconfig)
        {
            connection = Iconfig.GetConnectionString("Default");
        }
        
        public void getEmployees()
        {
            using(SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("Select * from EmployeeTB", con);
                con.Open();
                SqlDataReader rdr= cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);
                }

            }
        }

        public EmployeePOCO Search(int id)
        {
           using(SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("Select * from EmployeeTB where Id=@id ", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader rdr= cmd.ExecuteReader();
                while (rdr.Read())
                {
                    return new EmployeePOCO()
                    {
                        Id = Convert.ToInt32(rdr["Id"]),
                        Name = (string)rdr["Name"],
                        Salary = Convert.ToSingle(rdr["Salary"])
                    };
                }
                

            }
            return null;
        }

        public List<EmployeePOCO> Search(string name)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("Select * from EmployeeTB where Name=@name ", con);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                List <EmployeePOCO> lt= new List<EmployeePOCO>();
                while (rdr.Read())
                {
                    lt.Add(new EmployeePOCO()
                    {
                        Id = Convert.ToInt32(rdr["Id"]),
                        Name = (string)rdr["Name"],
                        Salary = Convert.ToSingle(rdr["Salary"])
                    });
                }
                return lt;

            }
            return null;
        }

        public int deleteData(int id)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("Delete from EmployeeTB where Id=@id ", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int record = cmd.ExecuteNonQuery();
                return record;

            }
        }

        public int updateData(int id,Object obj)
        {
            EmployeePOCO emp = obj as EmployeePOCO;

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("update EmployeeTb set Name=@name,Salary=@salary where Id=@id ", con);
                cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
                cmd.Parameters.Add("@salary",SqlDbType.Float).Value=emp.Salary;
                cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value=emp.Name;
                con.Open();
                int record = cmd.ExecuteNonQuery();
                return record;

            }
        }

        public int updateData(int id, EmployeePOCO emp)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("update EmployeeTb set Name=@name,Salary=@salary where Id=@id ", con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@salary", SqlDbType.Float).Value = emp.Salary;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = emp.Name;
                con.Open();
                int record = cmd.ExecuteNonQuery();
                return record;

            }
        }

    }
}
