using Entidades.Entidades;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class UsuarioBD
    {
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT codigo, 
                                                   nome AS descricao, 
                                                   situacao 
                                            FROM usuario
                                            WHERE situacao = @situacao;";
                    comando.Parameters.AddWithValue("Situacao", (int)status);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Descricao = reader["descricao"].ToString();
                        oEntidade.Status =(Status)Convert.ToInt16(reader["situacao"]);
                        
                        listaEntidades.Add(oEntidade);
                                                                     
                    }

                }
                catch (MySqlException mysqle)
                {
                    throw new System.Exception(mysqle.ToString());
                }
                finally
                {
                    conexao.Close();
                }


            }

            return listaEntidades;
        }

        public List<Usuario> ListarUsuariosAtivos()
        {
            var listaUsuarios = new List<Usuario>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "select * from usuario where situacao=1;";

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oUsuario = new Usuario();
                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oUsuario.TipoUsuario = new TipoUsuario(Convert.ToInt32(reader["codigo_tipo_usuario"].ToString()), string.Empty);
                        oUsuario.Nome = reader["Nome"].ToString();
                        oUsuario.Login = reader["Login"].ToString();
                        oUsuario.Senha = reader["Senha"].ToString();
                        oUsuario.Status = (Status)Convert.ToInt16(reader["Situacao"]);
                        oUsuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaUsuarios.Add(oUsuario);

                    }

                }
                catch (MySqlException mysqle)
                {
                    throw new System.Exception(mysqle.ToString());
                }
                finally
                {
                    conexao.Close();
                }


            }

            return listaUsuarios;
        }

    }

}

