using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caixa.DB;

namespace Caixa.Classes
{

    public class UserLogin
    {

        public static bool Authenticate (string username, string password, out Login AuthUser, out List<Features> Permissoes)
        {
            Login user = (from i in DBInstance.DB.Login
                         where i.Username.ToUpper().Equals(username) &&
                               i.Password.Equals(password) &&
                               i.Ativo.Equals(true)
                         select i).FirstOrDefault();
            if (user != null)
            {
                AuthUser = user;
                Permissoes = GetPermissoes(user);
                return true;
            }
            AuthUser = null;
            Permissoes = null;
            return false;
        }

        public static List<Features> GetPermissoes(Login user)
        {
            if (user != null)
            {
                List<Features> perms = new List<Features>();

                var items = from i in user.GruposUsuarios
                            from j in i.Permissoes
                            where i.Ativo == true && j.Ativo == true
                            select j.Features;

                perms.AddRange(items);

                return perms;
            }
            return null;
        }

    }
}
