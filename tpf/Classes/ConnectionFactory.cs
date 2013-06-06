using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ConnectionFactory
    {
        /*Criando a conexão*/
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private String myConnectionString;

        public ConnectionFactory()
        {
            /*Instanciando a coneção*/
            conn = new SqlConnection(myConnectionString);
        }

        public String cadastrar(Object obj){
            String ret = String.Empty;
            try
            {
                Open();
            }
            catch(Exception e)
            {
                ret = "Falha: " + e.Message;
            }
            finally
            {
                Close();
            }

            return ret;
        }

        public String alterar(Object obj)
        {
            String ret = String.Empty;
            try
            {
                Open();
            }
            catch (Exception e)
            {
                ret = "Falha: " + e.Message;
            }
            finally
            {
                Close();
            }

            return ret;
        }

        public String deletar(Object obj)
        {
            String ret = String.Empty;
            try
            {
                Open();
            }
            catch (Exception e)
            {
                ret = "Falha: " + e.Message;
            }
            finally
            {
                Close();
            }

            return ret;
        }

        public void Open()
        {
            conn.Open();
        }

        public void Close()
        {
            if (conn != null)
                conn.Close();
        }
    }
}
