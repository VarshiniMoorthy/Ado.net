using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Procedure
{
    
        class Programmer
        {
            public void AddProgrammer(SqlConnection connection)
            {

                Console.WriteLine("Enter programmer name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your prof1 :");
                string prof1 = Console.ReadLine();
                Console.WriteLine("Enter your prof2: ");
                string prof2 = Console.ReadLine();
                Console.WriteLine("Enter your salary :");
                float salary = float.Parse(Console.ReadLine());


                SqlCommand Command = new SqlCommand("sp_GetProgammerDetail", connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@prof1", prof1);
                Command.Parameters.AddWithValue("@prof2", prof2);
                Command.Parameters.AddWithValue("@salary", salary);

                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                {
                    Console.WriteLine("Record inserted Successfully !!!");

                }
                else
                {
                    Console.WriteLine("Some error occured");
                }

            }
            public void DisplayProgrammer(SqlConnection connection)
            {
                SqlCommand sqlCommand = new SqlCommand("sp_DisplayProgrammerDetail", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader Datareader = sqlCommand.ExecuteReader();
                if (Datareader.HasRows)
                {
                    Console.WriteLine("\nname\tprof1\tprof2\tsalary");

                    while (Datareader.Read())
                    {
                        Console.WriteLine(Datareader.GetString(0) + "\t" + Datareader.GetString(1) + "\t" + Datareader.GetString(2) + "\t" + Datareader.GetString(3));
                    }
                }
                else
                {
                    Console.WriteLine("doesnot contain rows");
                }
                Datareader.Close();
            }

            public void DeleteProgrammer(SqlConnection connection)
            {
                Console.WriteLine("Enter the name to delete : ");
                string name = Console.ReadLine();
                SqlCommand command = new SqlCommand("sp_DeleteProgrammerDetail", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.VarChar);
                command.Parameters["@name"].Value = name;
                int Result = command.ExecuteNonQuery();
                if (Result > 0)
                {
                    Console.WriteLine("Record Deleted Successfully !!!");
                }
                else
                {
                    Console.WriteLine("Some error occured");
                }
            }
            public void UpdateTrainInfo(string name, SqlConnection connection)
            {
                Console.WriteLine("Enter  Name to Update:");
                string prof1 = Console.ReadLine();
                SqlCommand commandforName = new SqlCommand("sp_UpdateProf1", connection);
                commandforName.CommandType = CommandType.StoredProcedure;
                commandforName.Parameters.AddWithValue("@prof1", prof1);
                commandforName.Parameters.AddWithValue("@name", name);
                int Result = commandforName.ExecuteNonQuery();
                if (Result > 0)
                {
                    Console.WriteLine("Updated Successfully");

                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }
    }





