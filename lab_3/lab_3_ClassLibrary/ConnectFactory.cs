using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_3_ClassLibrary
{
    public class ConnectFactory
    {
        private SqlConnection conn;
        private String dataSource = "DataSource=localhost;";
        private String security = "Integrated Security=SSPI;";
        private String initial = "Initial Catalog=lpc";

        public ConnectFactory() {
            conn = new SqlConnection();
            conn.ConnectionString = dataSource + security + initial;
        }

        
    }
}
