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
            if (movimentos.Count() > 0)
            {
                double sumEntradas = 0, sumSaidas = 0;

                if (movimentos.Where(i => i.Tipo == "Entrada").Count()>0)
                    sumEntradas = movimentos.Where(i => i.Tipo == "Entrada").Sum(i => i.Valor);

                if (movimentos.Where(i => i.Tipo == "Saída").Count() > 0)
                    sumSaidas = movimentos.Where(i => i.Tipo == "Saída").Sum(i => i.Valor);

                Total = sumEntradas - sumSaidas;
            }
            else
            {
                Total = 0;
            }
            return movimentos;
        }

    }
}
