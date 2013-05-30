using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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
        private string SQL_SELECT_MATERIAL = @"SELECT codigo, codigo_departamento, data, titulo, conteudo 
	                                            FROM material 
	                                            WHERE	codigo_departamento = @departamento 
			                                            AND titulo LIKE '%@titulo%' 
			                                            AND data BETWEEN @de AND @ate;";

        public ConnectionFactory()
        {
            /*Instanciando a coneção*/
            conn = new SqlConnection(myConnectionString);
        }


        public string validar(Login login)
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

        public List<Departamento> getDepartamentos()
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
            catch(Exception e)
            {
                Console.WriteLine("Aught! {0}", e);
                throw;
            }
            finally
            {
                close();
            }
        }

        public Departamento getDepartamento(int id)
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

        public List<Material> getMateriais(Material material, DateTime de, DateTime ate)
        {
            List<Material> materias = new List<Material>();
            try
            {
                cmd = new SqlCommand(SQL_SELECT_MATERIAL, conn);
                open();

                cmd.Parameters.Add("@departamento", SqlDbType.Int).Value = material.Departamento.Codigo;
                cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = material.Titulo;
                cmd.Parameters.Add("@de", SqlDbType.DateTime).Value = de;
                cmd.Parameters.Add("@ate", SqlDbType.DateTime).Value = ate;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    material = new Material();

                    material.Codigo = (long)reader["codigo"];
                    material.Departamento = getDepartamento((int)reader["codigo_departamento"]);
                    material.Titulo = (String)reader["titulo"];
                    material.Conteudo = (String)reader["conteudo"];
                    material.Data = (DateTime)reader["data"];

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

        public void open()
        {
            conn.Open();
        }

        public void close()
        {
            if (conn != null)
                conn.Close();
        }

        public List<Material> getMateriais()
        {
            List<Material> materiais = new List<Material>();
            return materiais;
        }
    }
}