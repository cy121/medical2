using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql;

namespace MedicalV2
{
    class CommonFunc
    {
        static public MySqlConnection getConnection()
        {
            return new MySqlConnection("Server=localhost;Database=medical;Uid=root;Pwd=123");
        }

        static public string convertToBinary()
        {
            return "";
        }

        static public int convertToDecimal(string binary)
        {
            return 0;
        }
    }
}
