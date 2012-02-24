using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caixa;
using Caixa.DB;
using Caixa.Classes;

namespace Caixa.Classes
{
    static class Sistema
    {
        public static Login LoggedUser { get; set; }
        public static List<Features> Permissoes { get; set; }
    }
}
