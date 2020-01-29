using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Procedure
{
        class ConnectionSql
        {
            public void ConnectOperations()
            {
                Programmer programmer = new Programmer();
                string connectionString = "Data source = DESKTOP-ONM3RTQ\\SQLEXPRESS; Database = DataCollection; Integrated Security = SSPI";
                SqlConnection Connection = new SqlConnection(connectionString);
                try
                {
                    Connection.Open();
                    byte choose;
                    do
                    {
                        Console.WriteLine("Ente the choice:");
                        Console.WriteLine("1)Add programmer details\n2)Update programmer details\n3)Delete programmer details\n4)Display programmer details\n");
                        byte choice = Byte.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                programmer.AddProgrammer(Connection);
                                break;
                            case 2:
                                Console.WriteLine("Enter the name  you to Update");
                                string name = Console.ReadLine();
                                programmer.UpdateTrainInfo(name, Connection);
                                break;
                            case 3:
                                programmer.DeleteProgrammer(Connection);
                                break;
                            case 4:
                                programmer.DisplayProgrammer(Connection);
                                break;
                            default:
                                Console.WriteLine("invalid");
                                break;
                        }
                        Console.WriteLine("do you want to continue:(1/2)\n1.continue\n2.exit");
                        choose = Byte.Parse(Console.ReadLine());
                    } while (choose == 1);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }
    }




