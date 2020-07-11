using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Dal
{
    class LoginDal
    {
        public bool tem = false;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from  logins where cod_usuario = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return tem;
        }
        public String cadastrar(String cod_usuario, String email, String senha)
        {
            cmd.CommandText = "insert into logins values (@cod_usuario, @email, @senha)";
            cmd.Parameters.AddWithValue("@cod_usuario", cod_usuario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao conectar o Banco de Dados";
            }
            return mensagem;
        }

    }
}
