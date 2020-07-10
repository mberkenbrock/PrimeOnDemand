using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Dal;

namespace WindowsFormsApp1.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDal loginDao = new LoginDal();
            tem = loginDao.verificarLogin(login, senha);

            if (!string.IsNullOrEmpty(loginDao.mensagem))

                if (loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }

    }
}
