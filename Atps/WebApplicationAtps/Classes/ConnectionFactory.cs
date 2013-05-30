using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;

namespace ATPS
{
    public class ConnectionFactory
    {
        /*Criando a conexão*/
        private SqlConnection conn;
        private SqlCommand cmd;

        /*Criando a String de Conexão*/
        private string myConnectionString = ConfigurationManager.ConnectionStrings["atps"].ConnectionString;

        /*String de select*/
        private string SQL_SELECT_LOGIN = @"SELECT _login, senha from usuario WHERE _login = @login and senha = @senha;";
        private string SQL_SELECT_DEPARTAMENTOS = @"SELECT codigo, descricao FROM departamento;";
        private string SQL_SELECT_DEPARTAMENTO_ID = @"SELECT codigo, descricao FROM departamento WHERE codigo = @id;";
        private StringBuilder SQL_SELECT_MATERIAL= new StringBuilder("SELECT codigo, codigo_departamento, data, titulo, conteudo FROM material WHERE 1=1 ");

        public ConnectionFactory()
        {
            /*Instanciando a coneção*/
            conn = new SqlConnection(myConnectionString);
        }


        public string ValidarLogin(Login login)
        {
            string retorno = string.Empty;

            try
            {
                cmd = new SqlCommand(SQL_SELECT_LOGIN, conn);

                open();

                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login.Usuario;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = login.Senha;

                SqlDataReader reader = cmd.ExecuteReader();

                // verificar se possui algum retorno e atribui o valor verdadeiro se sim.
                retorno = (reader.Read()) ? "true" : "Usuário/Senha incorretos!: " + login.Usuario;
                reader.Close();
            }
            catch
            {
                retorno = "Falha na autênticação do usuário: " + login.Usuario;
            }
            finally
            {
                close();
            }
            return retorno;
        }

        public List<Departamento> GetDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            try
            {
                cmd = new SqlCommand(SQL_SELECT_DEPARTAMENTOS, conn);
                open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Departamento departamento = new Departamento();
                    departamento.Codigo = reader.GetInt32(reader.GetOrdinal("codigo"));
                    departamento.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    departamentos.Add(departamento);
                }
                reader.Close();
                return departamentos;
            }
            catch (Exception e)
            {
                Console.WriteLine("Aught! {0}", e);
                throw;
            }
            finally
            {
                close();
            }
        }

        public Departamento GetDepartamento(long id)
        {
            Departamento departamento = new Departamento();
            try
            {
                cmd = new SqlCommand(SQL_SELECT_DEPARTAMENTO_ID, conn);
                open();

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    departamento.Codigo = reader.GetInt32(reader.GetOrdinal("codigo"));
                    departamento.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                }

                reader.Close();
                return departamento;
            }
            catch (Exception e)
            {
                Console.WriteLine("Aught! {0}", e);
                throw;
            }
            finally
            {
                close();
            }
        }


        public List<Material> GetMateriais(Material material, DateTime de, DateTime ate)
        {
            montaSqlQueryMaterial(material, de, ate);

            List<Material> materias = new List<Material>();
            try
            {

                cmd = new SqlCommand(SQL_SELECT_MATERIAL.ToString(), conn);
                open();

                cmd = montaSqlParametersMaterial(material, de, ate, cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    material = new Material();

                    material.Codigo = reader.GetInt32(reader.GetOrdinal("codigo"));
                    material.Departamento = new Departamento(reader.GetInt32(reader.GetOrdinal("codigo_departamento"))).GetDepartamento();
                    material.Titulo = reader.GetString(reader.GetOrdinal("titulo"));
                    material.Conteudo = reader.GetString(reader.GetOrdinal("conteudo"));
                    material.Data = reader.GetDateTime(reader.GetOrdinal("data"));

                    materias.Add(material);
                }
                reader.Close();
                return materias;
            }
            catch (Exception e)
            {
                Console.WriteLine("Aught! {0}", e);
                throw;
            }
            finally
            {
                close();
            }
        }

        private SqlCommand montaSqlParametersMaterial(Material material, DateTime de, DateTime ate, SqlCommand cmd)
        {
            DateTime nulo = DateTime.Parse("01/01/0001");

            if (material.Departamento.Codigo != 0)
                cmd.Parameters.Add("@departamento", SqlDbType.Int).Value = material.Departamento.Codigo;
            if (material.Titulo != String.Empty)
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = "%"+ material.Titulo+"%";
            if(de != nulo)
                cmd.Parameters.Add("@de", SqlDbType.DateTime).Value = de;
            if (ate != nulo)
                cmd.Parameters.Add("@ate", SqlDbType.DateTime).Value = ate;
            if (de != nulo && ate != nulo)
            {
                cmd.Parameters.Add("@de", SqlDbType.DateTime).Value = de;
                cmd.Parameters.Add("@ate", SqlDbType.DateTime).Value = ate;
            }

            return cmd;
        }

        private void montaSqlQueryMaterial(Material material, DateTime de, DateTime ate)
        {
            DateTime nulo = DateTime.Parse("01/01/0001");

            if (material.Departamento.Codigo != 0)
                SQL_SELECT_MATERIAL.Append(" AND codigo_departamento = @departamento");
            if (material.Titulo != String.Empty)
                SQL_SELECT_MATERIAL.Append(" AND titulo LIKE @titulo");
            if (de != nulo)
                SQL_SELECT_MATERIAL.Append(" AND data >= @de");
            if (ate != nulo)
                SQL_SELECT_MATERIAL.Append(" AND data <= @ate");
            if (de != nulo && ate != nulo)
                SQL_SELECT_MATERIAL.Append(" AND data BETWEEN @de AND @ate;");
            SQL_SELECT_MATERIAL.Append(";");
        }

        public void open()
        {
            conn.Open();
        }

        public void close()
        {
            if (conn != null)
                conn.Close();
        }

    }
}