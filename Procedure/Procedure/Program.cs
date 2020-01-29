using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
  
        class Program
        {
            static void Main()
            {
                ConnectionSql connections = new ConnectionSql();
                connections.ConnectOperations();
            }
        }
}
    

