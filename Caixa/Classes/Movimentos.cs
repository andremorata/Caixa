using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Caixa.Classes
{
    public static class Movimentos
    {
        public static CaixaDBEntities DB { get; set; }

        public static IQueryable GetData(DateTime DataInicio, DateTime DataFim, out double Total)
        {            
            var movimentos = (from i in DB.Movimentos
                              where i.Data >= DataInicio && i.Data <= DataFim
                              select new
                              {
                                  ID = i.Id,
                                  Descricao = i.Descricao,
                                  Data = i.Data,
                                  Valor = i.Valor,
                                  Tipo = i.Tipo.Descricao
                              });
            double sum = movimentos.Sum(i => i.Valor);            
            Total = sum;
            return movimentos;
        }

    }
}
