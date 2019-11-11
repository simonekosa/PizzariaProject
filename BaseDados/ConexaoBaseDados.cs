using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDados
{
    public class ConexaoBaseDados
    {
        private static readonly ConexaoBaseDados instanciaMysql = new ConexaoBaseDados();

        public static ConexaoBaseDados getInstancia()
        {
            return instanciaMysql;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MysqlConectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
