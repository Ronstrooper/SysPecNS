using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    /// <summary>
    /// Claase estática (não necessita declaração de instância) de conexão de Banco de Dados MySql
    /// </summary>
    public class Banco
    {
        /// <summary>
        /// Método abrir da classe Banco é utilizado para representar comandos SQL
        /// no servidor informado, cujo dados foram informados na string de conexão (strconn) 
        /// </summary>
        /// <returns>Entra um objeto de comandos, que serão executados na conexão informada </returns>
        public static MySqlCommand Abrir()
        {
            // dados da conexão   
            string strconn = @"server=10.91.45.20;database=syspecdb;user=root;password=root"; //variável para conectar ao banco de dados
            MySqlConnection cn = new MySqlConnection(strconn); //valor da viariável para acessar o banco de dados
            MySqlCommand cmd = new();
            try //tratamento de excessão
            {
                cn.Open(); // cn objeto do tipo mysqlconnection //azul bebê sempre representa objeto, verde turquesa sempre representa classe.
                cmd.Connection = cn;
            }
            catch (Exception)
            {

                throw;
            }
            return cmd; 
        }
    }
}
