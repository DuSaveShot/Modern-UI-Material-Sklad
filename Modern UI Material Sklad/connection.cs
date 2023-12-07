using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_UI_Material_Sklad
{
    internal class connection
    {
        //SqlConnection sqlConnection = new SqlConnection(@"Server=192.168.1.103,3305;Initial Catalog=Kurs_3_Material_Sklad;Uid=sa;Pwd=1");
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=U12;Initial Catalog=Kurs_3_Material_Sklad;Integrated Security=True");

        public SqlConnection getConnection()
        {
            return sqlConnection; 
        }
    }
}
