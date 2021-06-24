using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace Sistec
{
    public class ClienteDAO
    {
        
     string Conexao01 = @"Server=LAPTOP-IFSV24AO\SQLEXPRESS;Database=dbsistec;Trusted_Connection=True";
        

        public ClienteDAO()
        {

        }

        ///CRUD
        public void InserirCliente(Cliente cliente)
        {
            /*using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConexaoMyql))
            {
                conn.Open();
                conn.Insert<Usuario>(usuario);
            }*/
            
            //Conectar ao Banco de Dados e dar um insert
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                conn.Insert<Cliente>(cliente);
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            //Conectar ao Banco de Dados e dar um insert
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                conn.Update<Cliente>(cliente);
            }
        }

        public void ExcluirCliente(Cliente cliente)
        {
          using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                conn.Delete<Cliente>(cliente);
            }  
        }

        public Cliente BuscarCliente(int ClienteId)
        {
            //string sql = "Select * from TB_Usuario Where USUID=@USUID";
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                return conn.Get<Cliente>(ClienteId);
                //return conn.Query<Usuario>(sql,new{USUID=UsuarioId}).FirstOrDefault();
            } 
        }

        public IList<Cliente> BuscarClientes()
        {
            //string sql = "Select * from TB_Usuario";
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexao01))
            {
                conn.Open();
                return conn.GetAll<Cliente>().ToList();
                //return conn.Query<Usuario>(sql).ToList();
            } 
        }

    }
}
