using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caixa.DB;

namespace Caixa.Classes
{
    static class DBInstance
    {
        public static CaixaDBEntities DB { get; set; }

        public static CaixaDBEntities NewInstance()
        {
            return new CaixaDBEntities();
        }
    }
}
