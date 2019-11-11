using MySql.Data.MySqlClient;
using System.Configuration;

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
            string conn = ConfigurationManager.ConnectionStrings["MySQLConectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
