using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    static class DBConnection
    {
        public static SqlConnection GetConnection()
        {

            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\xxbar\OneDrive\Studia\semestr 4\Programowanie w środowisku Windows - lab\Lab5\Modul08\Zadanie1\Zbiory.mdf";Integrated Security=True
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;";
            //connStr += @"AttachDbFilename=""C:\Users\xxbar\OneDrive\Studia\semestr 4\Programowanie w środowisku Windows - lab\Lab5\Modul08\Zadanie1\Zbiory.mdf"";";
            connStr += @"AttachDbFilename=""|DataDirectory|\Zbiory.mdf"";";
            connStr += @"Integrated Security=True";

            SqlConnection connection = new SqlConnection(connStr);
            return connection;

        }
    }
}
